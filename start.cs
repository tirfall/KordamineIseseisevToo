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
            ////Esimene ulesanne
            //Console.WriteLine("Sisesta palindromi sõna:");
            //string sonavas = Console.ReadLine();
            //Console.WriteLine(func.Palindrom(sonavas));

            ////Teine ülesanne
            //int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 0, -1, -2 }, { 5, -6, 9 } };
            //Console.WriteLine(func.Matrics(matrix));

            //Kolmanda ulesanne
            Console.WriteLine("Sisesta sümbolid:");
            string ans = Console.ReadLine();
            Console.WriteLine(func.Sumbol(ans));

        }
    }
}
