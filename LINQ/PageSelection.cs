using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using LINQ;

namespace LINQ
{
    public class PageSelection
    {
        public static char Page = ' ';

        public static void Selection(List<Contact> phonebook)
        {
            while (true)
            {
                IEnumerable<Contact> page = from contact in phonebook orderby contact.Name, contact.LastName select contact;

                Console.WriteLine("\n Введите номер желаемой страницы(1-3): ");
                Page = Console.ReadKey().KeyChar;
                Console.Clear();

                switch (Page)
                {
                    case ('1'):
                        page = page.Take(2);
                        break;
                    case ('2'):
                        page = page.Skip(2).Take(2);
                        break;
                    case ('3'):
                        page = page.Skip(4);
                        break;

                    default:
                        Console.WriteLine(" Такой страницы не существует.");
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
