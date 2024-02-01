using System;
using System.Threading;

namespace JeuDuSerpent.Properties
{
    public class UserInterface
    {
        public void Start()
        {
            bool launch = true;
            Console.WriteLine("Press any key to start");
            while (!Console.KeyAvailable)
            {
                Thread.Sleep(10);
            }

            while (launch)
            {
                Console.Clear();
                Console.WriteLine("Do you want to play again ?(Y/N)");
                string answer = "";
                while (answer != "N" && answer != "Y")
                {
                    answer = Console.ReadLine();
                }

                if (answer == "N")
                    launch = false;
            }
        }
    }
}