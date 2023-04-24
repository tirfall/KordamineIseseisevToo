using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KordamineIseseisevToo
{
    public class func
    {
        public static string Palindrom (string vastus)
        {
            string answer;
            string vastwithout = vastus.Replace(" ","").ToLower();
            char[] chars = vastwithout.ToCharArray();
            Array.Reverse(chars);
            string reversed = new string(chars);
            Console.WriteLine(chars);
            Console.WriteLine(vastwithout);
            if (vastwithout == reversed) { answer = (vastus+" on polindromi sona!"); }
            else { answer = (vastus + " ei ole polindromi sona!"); }
            return answer;
        }
        public static string Matrics(int[,] myarr)
        {
            string nullid = "";
            int positiv = 0;
            int negativ = 0;
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 3; i++)
                {
                    int vastus = myarr [j,i];
                    if (vastus == 0) { nullid = $"[{i}, {j}]"; }
                    else if (vastus > 0) { positiv++; }
                    else if (vastus < 0) { negativ++; }  
                }
            }
            string answer = ("Positiivsed: " + positiv + "\nNegatiivsed: " + negativ + "\nNullid koordid: " + nullid);
            return answer;
        }
        
    }
}