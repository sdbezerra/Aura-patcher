namespace Patcher
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser = new System.Windows.Forms.WebBrowser();
            this.picPublisherLogo = new System.Windows.Forms.PictureBox();
            this.picGameLogo = new System.Windows.Forms.PictureBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.lblVersion = new System.Windows.Forms.Label();
            this.picTitleLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPublisherLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.picPublisherLogo);
            this.groupBox1.Controls.Add(this.picGameLogo);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.webBrowser);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // webBrowser
            // 
            this.webBrowser.IsWebBrowserContextMenuEnabled = false;
            resources.ApplyResources(this.webBrowser, "webBrowser");
            this.webBrowser.Name = "webBrowser";
            this.webBrowser.Url = new System.Uri("", System.UriKind.Relative);
            // 
            // picPublisherLogo
            // 
            resources.ApplyResources(this.picPublisherLogo, "picPublisherLogo");
            this.picPublisherLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picPublisherLogo.Name = "picPublisherLogo";
            this.picPublisherLogo.TabStop = false;
            this.picPublisherLogo.Click += new System.EventHandler(this.picPublisherLogo_Click);
            // 
            // picGameLogo
            // 
            resources.ApplyResources(this.picGameLogo, "picGameLogo");
            this.picGameLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGameLogo.Name = "picGameLogo";
            this.picGameLogo.TabStop = false;
            this.picGameLogo.Click += new System.EventHandler(this.picGameLogo_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.progressBar, "progressBar");
            this.progressBar.Name = "progressBar";
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // lblStatus
            // 
            resources.ApplyResources(this.lblStatus, "lblStatus");
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.ForeColor = System.Drawing.Color.Black;
            this.lblStatus.Name = "lblStatus";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.Color.Black;
            this.btnPlay.BackgroundImage = global::Patcher.Properties.Resources.button;
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.ForeColor = System.Drawing.Color.White;
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            this.btnPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.btnPlay_Paint);
            // 
            // lblVersion
            // 
            resources.ApplyResources(this.lblVersion, "lblVersion");
            this.lblVersion.BackColor = System.Drawing.Color.Transparent;
            this.lblVersion.ForeColor = System.Drawing.Color.Black;
            this.lblVersion.Name = "lblVersion";
            // 
            // picTitleLogo
            // 
            resources.ApplyResources(this.picTitleLogo, "picTitleLogo");
            this.picTitleLogo.Name = "picTitleLogo";
            this.picTitleLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.btnClose, "btnClose");
            this.btnClose.Name = "btnClose";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // frmMain
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picTitleLogo);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.frmMain_MouseUp);
            this.groupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picPublisherLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTitleLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox picPublisherLogo;
        private System.Windows.Forms.PictureBox picGameLogo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.PictureBox picTitleLogo;
        private System.Windows.Forms.Button btnClose;
    }
}

