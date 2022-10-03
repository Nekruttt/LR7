using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LR7
{
    class Programm
    {
        static void Main(string[] args)
        {
            UserStorage task = new UserStorage();
            Console.WriteLine("Введите логин : ");
            string login = Console.ReadLine();
            Console.WriteLine("Введите пароль : ");
            string pass = Console.ReadLine();
            UserInfo info = task.GetUser(new AuthorizeInfo(login, pass));
            if(info != null)
            {
                Console.WriteLine(info.fio +"\n"+info.mail+"\n"+info.city);
            }
            else
            {
                Console.WriteLine("Пользователь не найден");
            }
        }
    }
}
