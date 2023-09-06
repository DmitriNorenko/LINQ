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
            while (true)
            {
                Console.WriteLine("Введите номер желаемой страницы(1-3): ");
                Page = Console.ReadKey().KeyChar;

                switch (Page)
                {
                    case ('1'):
                        var Page1 = phonebook.Take(2);
                        break;
                    case ('2'):
                        var Page2 = phonebook.Skip(2).Take(2);
                        break;
                    case ('3'):
                        var Page3 = phonebook.Skip(4);
                        break;

                    default:
                        Console.WriteLine("Такой страницы не существует.");
                        break;
                }
            }
        }
    }
}
