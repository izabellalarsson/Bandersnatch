using System;
namespace bandersnatch
{
    public class Right : StoryStart
    {
        public bool HasReceipt = true;

        //public Right(bool HasReceipt)
        //{
        //    this.HasReceipt = HasReceipt;
        //}

        public void RightWay()
        {
            Console.WriteLine("You walk from the screams. You are not ready yet!\nIn the distance you see a light. \nYou follow it and find yourself in a bar. \nThe bar is empty, but you find a receipt. \nYou read it.\n\nMap of receipt visual. \n\nYou can't make any sense of it but put it in your pocket.");
            HaveReceipt = true;

            Question();
        }

        public void Question()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("You can now either go forward or look more in the bar. \nWhat do you do? [forward]/[look]");
                Console.Write("> ");
                var userInput = Console.ReadLine();
                if (userInput == "forward")
                {
                    Console.WriteLine("You walk forward and hear the screams once again.\nYou now have the choice to follow the screams or walk towards the scary silence.");
                    notChosen = true;
                    var scream = new ScreamOrSilence();
                    scream.SilenceOrScream();

                }
                else if (userInput == "look")
                {
                    notChosen = true;
                    Console.WriteLine("hej");
                }

            }
        }
    }
}
