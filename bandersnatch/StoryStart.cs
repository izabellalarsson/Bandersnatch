using System;
namespace bandersnatch
{
    public class StoryStart
    {
        public StoryStart()
        {

        }

        public void whoAreYou()
        {
            var user = "human";

            while (user == "human")
            {
                Console.WriteLine("\"Are you a Wizard or a Barbarian?\"- Werd man");
                Console.Write(">");
                var typeOfUser = Console.ReadLine().ToLower();
                if (typeOfUser == "wizard" || typeOfUser == "barbarian")
                {
                    user = "hej";
                    Console.WriteLine("\"What's your name?\" - Werd man");
                    Console.Write(">");
                    var userName = Console.ReadLine();
                    Console.WriteLine($"Hello {typeOfUser} {userName}");
                    Console.WriteLine();
                    Console.WriteLine("\"I fear this is a very scary cave, you might never return\" - Werd man");
                }
                else
                {
                    Console.WriteLine("\"As werd as you look you must be someting else then a human\" - Werd man" );
                }
            }
        }
    }
}
