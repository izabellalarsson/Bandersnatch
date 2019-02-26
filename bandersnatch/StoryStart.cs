using System;
namespace bandersnatch
{
    public class StoryStart
    {
        public bool HaveReceipt { get; set; }
        //public StoryStart()
        //{

        //}

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
                    Console.WriteLine("\"What's your name?\" - Weird man");
                    Console.Write(">");
                    var userName = Console.ReadLine();
                    Console.WriteLine($"Hello {typeOfUser} {userName}");
                    Console.WriteLine();
                    Console.WriteLine($"\"I fear this is a very scary cave and dark cave you might never return. Here you go little {typeOfUser}\" - Weird man");
                    Console.WriteLine("The Weird man hands over a flashlight to you");
                }
                else
                {
                    Console.WriteLine("\"As werd as you look you must be someting else then a human\" - Weird man" );
                }
            }
        }
    }
}
