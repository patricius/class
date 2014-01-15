using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace diceuser
{
 public class Program
    {
         static void Main(string[] args)
        {
            Program p = new Program();


            p.DiceRoll();
        }

        public void DiceRoll()
        {
            Console.WriteLine("What number of sides do you want?");
            int UserInput = int.Parse(Console.ReadLine());
            Console.WriteLine("How many times do you want to roll?");
            int UserInput2 = int.Parse(Console.ReadLine());
            Random Dicey = new Random();
          




            Dictionary<int, int> DiceDictionary = new Dictionary<int, int>();
            for (int i = 0; i < UserInput; i++)
            {
                DiceDictionary.Add(i, 0);

               int DiceResult = Dicey.Next(1, UserInput);
            
            if (DiceDictionary.ContainsKey(i))
                {
                    DiceDictionary[i]++;
                }

                foreach (var entry in DiceDictionary)
                {
                    Console.WriteLine("{0} occured {1} times", entry.Key, entry.Value);
                    
                }

                Console.ReadLine();
            }

        }
    }
}