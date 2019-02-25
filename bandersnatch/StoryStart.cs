using System;
namespace bandersnatch
{
    public class StoryStart
    {
<<<<<<< Updated upstream
=======
        public bool HaveReceipt { get; set; }
>>>>>>> Stashed changes
        public StoryStart()
        {

        }

        public void whoAreYou()
        {
            var user = "human";

            while (user == "human")
            {
<<<<<<< Updated upstream
                Console.WriteLine("\"Are you a Wizard or a Barbarian?\"- Werd man");
=======
                Console.WriteLine("\"Are you a Wizard or a Barbarian?\"- Weird man");
>>>>>>> Stashed changes
                Console.Write(">");
                var typeOfUser = Console.ReadLine().ToLower();
                if (typeOfUser == "wizard" || typeOfUser == "barbarian")
                {
                    user = "hej";
<<<<<<< Updated upstream
                    Console.WriteLine("\"What's your name?\" - Werd man");
=======
                    Console.WriteLine("\"What's your name?\" - Weird man");
>>>>>>> Stashed changes
                    Console.Write(">");
                    var userName = Console.ReadLine();
                    Console.WriteLine($"Hello {typeOfUser} {userName}");
                    Console.WriteLine();
<<<<<<< Updated upstream
                    Console.WriteLine("\"I fear this is a very scary cave, you might never return\" - Werd man");
                }
                else
                {
                    Console.WriteLine("\"As werd as you look you must be someting else then a human\" - Werd man" );
=======
                    Console.WriteLine($"\"I fear this is a very scary cave and dark cave you might never return. Here you go little {typeOfUser}\" - Weird man");
                    Console.WriteLine("The Weird man hands over a flashlight to you");
                }
                else
                {
                    Console.WriteLine("\"As werd as you look you must be someting else then a human\" - Weird man" );
>>>>>>> Stashed changes
                }
            }
        }
    }
}
