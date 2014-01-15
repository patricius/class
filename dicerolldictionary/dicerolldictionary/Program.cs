using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dicerolldictionary
{
   public class Program{

      static  void Main()
        {
            Program p = new Program();

      p.RollDice();
        }


       public void RollDice()
        {

            Dictionary<int, int> diceDictionary = new Dictionary<int, int>();

            diceDictionary.Add(1, 0);
            diceDictionary.Add(2,0);
            diceDictionary.Add(3, 0);
            diceDictionary.Add(4, 0);
            diceDictionary.Add(5, 0);
           diceDictionary.Add(6,0);
              
        

            Random rand = new Random();

           for (int i = 0; i < 100; i++)
           {

            int diceresult =   rand.Next(1, 7);

          
           switch (diceresult)
                {
                    case 1:
                        diceDictionary[1] ++ ;
                        break;
                    case 2:
                        diceDictionary[2]++;
                        break;
                    case 3:
                        diceDictionary[3]++;
                        break;
                    case 4:
                        diceDictionary[4]++;
                        break;
                    case 5:
                        diceDictionary[5]++;
                        break;
                    case 6:
                        diceDictionary[6]++;
                        break;
                }
            }

            foreach (KeyValuePair<int, int> roll in diceDictionary)
            {
                Console.WriteLine(string.Format("Key: {0}, NumberofOccurences: {1}", roll.Key, roll.Value));

            }
            Console.ReadLine();
        }

    }
}
