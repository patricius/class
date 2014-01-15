using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome2
{
    class Program
    {
        private static void Main(string[] args)
        {
           Program p = new Program();
           Console.WriteLine(p.isPalindrome("anna"));
            Console.ReadLine();

        }
        public bool isPalindrome(string sr){

        string str = string.Empty;
         
     

            int i = sr.Length;
            for (int j = sr.Length - 1; j >= 0; j--)
            {
                str = str + sr[j];
            }

            if (str == sr)
            {
                return true;
            }

            return false;
        }
    }
}
