using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace morse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write something:");
            String input = Console.ReadLine();
            input = input.ToUpper();
            MorseDictionary morsey = new MorseDictionary();
            morsey.ConvertWord(input);
        
            Console.WriteLine();
        }
    }
}
