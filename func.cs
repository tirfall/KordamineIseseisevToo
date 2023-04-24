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
            string vastwithout = vastus.Replace(" ","");
            char[] chars = vastwithout.ToCharArray();
            Array.Reverse(chars);
            string chars1 = chars.ToString();
            //bool result = vastwithout == chars1;
            //Console.WriteLine(result);
            Console.WriteLine(chars);
            Console.WriteLine(vastwithout);
            if (vastwithout == chars1) { answer = (vastus+" on polindromi sona!"); }
            else { answer = (vastus + " ei ole polindromi sona!"); }
            return answer;
        }
        
    }
}