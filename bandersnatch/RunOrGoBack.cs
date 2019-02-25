using System;
namespace bandersnatch
{
    public class RunOrGoBack
    {
        public RunOrGoBack()
        {
        }

        public void RunOrBack()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("\nYou think to yourself \"Should I run the rest of the part [run]? Or should I go back to find something more [back]?\".");
                Console.Write("> ");
                var userInput = Console.ReadLine().ToLower();

                if (userInput == "run")
                {
                    var CoolOrCrawl = new CoolOrCrawl();
                    Console.WriteLine("You hope for the best and start to run. \n\nThe flashlight continues to flicker as you run through the narrow passage.\nWhen you see the end of the passage you also see smoke covering it. \nSuddenly the flashlight dies. ");
                    notChosen = true;
                    CoolOrCrawl.Question();

                }
                else if (userInput == "back")
                {
                    var leftOrRight = new leftOrRight();
                    notChosen = true;
                    Console.WriteLine("You are back at the beginning.");
                    leftOrRight.rightOrLeft();

                }

            }

        }
    }
}
