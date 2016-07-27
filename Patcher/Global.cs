using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patcher
{
    public static class Global
    {
        private static string m_login = "";
        public static string pLogin
        {
            get { return m_login; }
            set { m_login = value; }
        }
        private static string m_password = "";
        public static string pPassword
        {
            get { return m_password; }
            set { m_password = value; }
        }
    }
}
