using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class AuthorizeInfo
    {
        private string login;
        private string password;

        public AuthorizeInfo(string pLogin, string pPassword)
        {
            login = pLogin;
            password = pPassword;
        }

        public override Boolean Equals(Object ob)
        {
            if(!(ob is AuthorizeInfo)) return false;
            AuthorizeInfo authorizeInfo = (AuthorizeInfo)ob;
            if ((this.login.Equals(authorizeInfo.login)) && (this.password.Equals(authorizeInfo.password))) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            int res = 1;
            res = (res * 31) + login.Length;
            res = (res * 31) + password.Length;
            return res;
        }
    }
}
