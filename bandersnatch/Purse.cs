using System;
namespace bandersnatch
{
    public class Purse
    {
        public Purse()
        {
        }

        public void PickUpPurse()
        {
            var notChosen = false;
            var choice = new yesOrNo();

            while (!notChosen)
            {
                Console.WriteLine("Should you take a look? [yes]/[no]");
                Console.Write("> ");
                var userInput = Console.ReadLine().ToLower();
                if (userInput == "yes")
                {
                    notChosen = true;
                    choice.yes();
                    choice.YesNo();

                }
                else if (userInput == "no")
                {
                    notChosen = true;
                    choice.no();
                    choice.YesNo();
                }
            }
        }
    }
}
