using System;
namespace bandersnatch
{
    public class CoolOrCrawl
    {
        public CoolOrCrawl()
        {
        }

        public void Question()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("What are you going to do? Start crawling [crawl] or play it cool [cool]?");
                Console.Write("> ");
                var userInput = Console.ReadLine().ToLower();

                var hidden = new HiddenDoor();
                // have to find a way to set the hasRecepit to true or false


                if (userInput == "crawl")
                {
                   
                    Console.WriteLine("After crawling for a while you see a red light in front of you. \nYou continue towards it and soon you see a pair of shoes. \nAs you look up you see the weird man you met outside the cave. \nHe starts to laugh and says \"you can get up now\".\nAs you raise he follows it up with only two words \"Receipt please\".");
                    notChosen = true;
                    hidden.ManQuestion();

                }
                else if (userInput == "cool")
                {
                    notChosen = true;
                    Console.WriteLine("After playing it cool for a while you see a red light in front of you. \nYou continue towards it soon you see the weird man you met outside the cave. \nHe also plays it cool and says only two words \"Receipt please\".");
                    hidden.ManQuestion();
                }
            }

        }
    }
}