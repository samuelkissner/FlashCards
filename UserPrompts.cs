using System;
using System.Collections.Generic;
using System.Text;

namespace FlashCards
{
    class UserPrompts
    {

        public static string askToDiscard()
        {
            string userInput = "";
            Console.WriteLine("Discard current card? \"y\" or \"n\"");
            while (true)
            {

                userInput = Console.In.ReadLine();
                if (userInput == "y" || userInput == "n")
                    break;
                else
                    Console.WriteLine("please enter either \"y\" or \"n\"");
            }

            return userInput;
        }
    }
}
