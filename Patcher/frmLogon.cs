using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Web;

namespace Patcher
{
    public partial class frmLogon : Form
    {
        public frmLogon()
        {
            InitializeComponent();            
        }
        private void bntAuth_Click(object sender, EventArgs e)
        {
            string md5Password;
            string authen;
            if (txtLogin.TextLength < 4)
            {
                MessageBox.Show("O Login deve ter mais de 4 caracteres!.");
            }
            else if (txtPassword.TextLength < 4)
            {
                MessageBox.Show("A Senha deve ter mais de 4 Caracteres!");
            }
            else
            {
                md5Password = getMD5Hash(txtPassword.Text);
                authen = GetResponse(txtLogin.Text, md5Password.ToLower());
                if (authen == "false")
                {
                    MessageBox.Show("Usuario ou Senha invalido!", "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else {
                    Global.pLogin = txtLogin.Text;
                    Global.pPassword = getMD5Hash(txtPassword.Text).ToLower();
                    this.Hide();
                    frmMain flmain = new frmMain();
                    flmain.ShowDialog();
                    this.Close();
                }
            }
            
        }
        private string GetResponse(string login, string password)
        {
            string data = "";
            try
            {
                WebRequest request = WebRequest.Create("http://teraworld.com.br/auth/auth.php?login=" + login + "&password=" + password);
                request.Timeout = 30000;
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                StreamReader reader = new StreamReader(response.GetResponseStream());
                data = reader.ReadToEnd();
                reader.Close();
                response.Close();
            }
            catch (InvalidCastException e)
            {
                MessageBox.Show(e.Message);
            }
            return data;
        }
        public string getMD5Hash(string input)
        {
            System.Security.Cryptography.MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hash = md5.ComputeHash(inputBytes);
            System.Text.StringBuilder sb = new System.Text.StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();
        }

        private void frmLogon_Load(object sender, EventArgs e)
        {

        }

        private void lnkRecuperarSenha_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://teraworld.com.br/painel/recover_pass.php");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://teraworld.com.br");
        }

        private void lnkRegistro_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://teraworld.com.br/painel/register.php");
        }

    }
}
