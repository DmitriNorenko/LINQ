using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    public class PageSelection
    {
        public static char Page = ' ';
        
        public static char Selection()
        {
            while (true)
            {
                Console.WriteLine("Введите номер желаемой страницы(1-3): ");
                if (Page == 1 || Page == 2 || Page == 3)
                {
                    Page = Convert.ToChar(Console.ReadKey());
                    return Page;
                    
                }
                else
                {
                    Console.WriteLine("Такой страницы нет.");
                }
            }
        }
    }
}
