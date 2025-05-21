using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Создадим реализацию для e-mail сообщений:

namespace FactoryMethodRealExample
{
    class EmailMessage : Message
    {
        public EmailMessage()
        {
            Console.WriteLine("e-mail отправлен");
        }
    }
}
