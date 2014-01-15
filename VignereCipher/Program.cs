using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VignereCipher
{
    internal class Program
    {
        private static void Main(string[] args)
        {

            string alphabet, text, action, result = ""; // default declarations 
            int[] secretNums = new int[1024];
            int index = 0;

            alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"; // original alphabet 

            Console.WriteLine("(1) Please enter any text!");
            text = Console.ReadLine().ToUpper(); // make sure there are only capital letters. 

            Console.WriteLine("(2) Please enter the secret digits:");
            secretNums = numToArray(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Do you want to encrypt [e] or decrypt [d]?"); // select mode 
            action = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                if (action == "e") // encode 
                {
                    index = (alphabet.IndexOf(text[i]) + secretNums[i%secretNums.Length])%26;
                }
                else // decode 
                {
                    index = (alphabet.IndexOf(text[i]) - secretNums[i%secretNums.Length])%26;
                }
                result += alphabet[index];
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }



        private static int[] numToArray(int num)
        {
            string stringNum = num.ToString();
            int[] result = new int[stringNum.Length];

            for (int i = 0; i < stringNum.Length; i++)
            {
                result[i] = stringNum[i];
            }

            return result;
        }
    }
}