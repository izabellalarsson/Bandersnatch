using System;
namespace bandersnatch
{
    public class ScreamOrSilence
    {
        public ScreamOrSilence()
        {
        }

        public void SilenceOrScream()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("Which way do you choose? [scream]/[silence]");
                Console.Write("> ");
                var userInput = Console.ReadLine().ToLower();
                if (userInput == "scream")
                {
                    notChosen = true;
                    var followScreams = new leftOrRight();
                    followScreams.rightOrLeft();

                }
                else if (userInput == "silence")
                {
                    notChosen = true;
                }
            }
        }
    }
}
