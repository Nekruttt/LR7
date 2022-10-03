using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    internal class UserStorage
    {
        private Dictionary<AuthorizeInfo, UserInfo> data;

        public UserStorage()
        {
            data= new Dictionary<AuthorizeInfo, UserInfo>();
            data.Add(new AuthorizeInfo("Novak", "1"), new UserInfo("Novak E.A.", "novak@mail.ru","Stavropol"));
            data.Add(new AuthorizeInfo("Gumin", "2"), new UserInfo("Gumin.G.A.", "gumin@mail.ru", "Moscow"));
            data.Add(new AuthorizeInfo("Skripin", "3"), new UserInfo("Skripin K.E.", "skripin@yandex.ru", "Paris"));
        }

        public UserInfo GetUser(AuthorizeInfo ob)
        {
            if(data.ContainsKey(ob)) return data[ob];
            else return null;
        }
    }
}
