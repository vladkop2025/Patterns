using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace SingletonRealExample
{
    class Program
    {
        static void Main(string[] args)
        {
            // создаем объект приложения
            Application app = new Application();

            // запускаем наше приложение (внутри создается соединение с базой данных по переданному адресу)
            app.Launch("10.30.60.80");
            Console.WriteLine(app.DbConnection.Configuration);

            // Теперь пробуем создать новое соединение с базой данных уже по другому адресу
            app.DbConnection = DbConnection.GetConnectionInstance("10.30.60.81");
            // у нас не получилось, так как объект уже существует
            Console.WriteLine(app.DbConnection.Configuration);
        }
    }
}