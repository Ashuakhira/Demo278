using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Demoapp
{
    public class Flipcoin
    {
        public static void DisplayPercentage()
        {
            Console.WriteLine("please enter the value for number of flips");
            int Head = 0;
            int Tail = 0;
            int HeadCount = 0;
            int TailCount = 0;
            double HeadPercentage;
            double TailPercentage;
            int Flipcoin = Convert.ToInt32((Console.ReadLine()));
            if (Flipcoin >= 0)
            {
                for (int i = 1; i <= Flipcoin; i++)
                {
                    Random random = new Random();
                    int number = random.Next(2);
                    Console.WriteLine("The Random function is" + number);
                    if (number == 1)
                    {
                        HeadCount++;
                    } else if(number == 0);
                    {

                    }
                }
            }
        }
    }
}





                
