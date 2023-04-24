using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineIseseisevToo
{
    public class start
    {
        public static void Main()
        {
            Console.WriteLine("Sisesta palindromi sõna:");
            string sonavas = Console.ReadLine();
            Console.WriteLine(func.Palindrom(sonavas));

        }
    }
}
