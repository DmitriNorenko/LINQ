using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LINQ;

namespace LINQ
{
    public class PageSelection
    {
        public static char Page = ' ';

        public static char Selection(List<Contact> phonebook)
        {
           
            IEnumerable<Contact> page = null;
            while (true)
            {
                Console.WriteLine("\n Введите номер желаемой страницы(1-3): ");
                Page = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (Page)
                {
                    case ('1'):
                        page = phonebook.Take(2);
                        break;
                    case ('2'):
                        page = phonebook.Skip(2).Take(2);
                        break;
                    case ('3'):
                        page = phonebook.Skip(4);
                        break;

                    default:
                        Console.WriteLine(" - Такой страницы не существует.");
                        continue;

                }
                Console.WriteLine();
                foreach (var name in page)
                {
                    Console.WriteLine("* " + name.Name + " - " + name.PhoneNumber);
                }
            }
        }
    }
}
