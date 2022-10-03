using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class UserInfo
    {
        public string fio { get; private set; }
        public string mail { get; private set; }
        public string city { get; private set; }
        public UserInfo(string pFio, string pMail, string pCity)
        {
            fio = pFio;
            mail = pMail;
            city = pCity;
        }
    }
}
