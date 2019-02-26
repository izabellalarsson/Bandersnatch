using System;
namespace bandersnatch
{
    public class Game
    {
        public bool playerHasReceipt = false;
        public bool playerHasPurse = false;
        public bool playerHasMoney = false;
        public string user = "human";

        public Game()
        {
            
        }

        public void StoryStart()
        {

            while (user == "human")
            {
                Console.WriteLine("\"Are you a Wizard or a Barbarian?\"- Weird man");
                Console.Write(">");
                var typeOfUser = Console.ReadLine().ToLower();
                if (typeOfUser == "wizard" || typeOfUser == "barbarian")
                {
                    user = $"{typeOfUser}";
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
                    Console.WriteLine("\"As weird as you look you must be someting else then a human\" - Weird man");
                }
            }

            Console.WriteLine();
            Console.WriteLine("You decide to enter the cave without knowing if you'll ever come out of it...");
            Console.WriteLine();
            // inside the cave
            Console.WriteLine("Inside the cave you hear load screams and instantly regret you entered the cave. \nYou think to yourself \"I should have listened to the weird man, maybe I should go back before it's too late\". \nBut as you turn around to get out you realise it's already too late, the entrance is blocked.\nYou now have no choice but to find another way out...\n");

            Console.WriteLine("With help of the light of the flashlight you start walking. The screams seems to disappear for a while. \nIn front of you you meet a crossroad.");
            WayQuest();
        }

        public void WayQuest()
        {
            var noWay = false;
            //var pickup = new Purse();

            while (!noWay)
            {
                Console.WriteLine("You can either go right or left. Which way do you go? [left]/[right]");
                Console.Write(">");
                var chosenWay = Console.ReadLine().ToLower();

                if (chosenWay == "left")
                {
                    noWay = true;
                    LeftWay();
                }
                else if (chosenWay == "right")
                {
                    noWay = true;
                    playerHasReceipt = true;
                    RightWay();

                }
            }
        }

        public void RightWay()
        {
            Console.WriteLine("You walk from the screams. You are not ready yet!\nIn the distance you see a light. \nYou follow it and find yourself in a bar. \nThe bar is empty, but you find a receipt. \nYou read it.\n\nMap of receipt visual. \n\nYou can't make any sense of it but put it in your pocket.");
            RightQuest();
        }

        public void LeftWay()
        {
            Console.WriteLine("You chose the left path and keep on walking. Suddenly you stumble on something.");
            LeftQuest();
        }

        public void LeftQuest()
        {
            var notChosen = false;
            while (!notChosen)
            {
                if(!playerHasPurse)
                {
                    Console.WriteLine("Should you take a look? [yes]/[no]");
                    Console.Write("> ");
                    var userInput = Console.ReadLine().ToLower();
                    if (userInput == "yes")
                    {
                        notChosen = true;
                        YesWay();
                        Console.WriteLine("You stop for a second as you see the passage is narrowing down. \nAt the same time the flashlight start to flicker, you can't see the end of the passage and wonder for how long you have to walk in this condition.");
                        RunOrBackQuest();
                    }
                    else if (userInput == "no")
                    {
                        notChosen = true;
                        NoWay();
                        Console.WriteLine("You stop for a second as you see the passage is narrowing down. \nAt the same time the flashlight start to flicker, you can't see the end of the passage and wonder for how long you have to walk in this condition.");
                        RunOrBackQuest();
                    }
                }
                RunOrBackQuest();
            }
        }

        public void YesWay()
        {
            playerHasPurse = true;
            Console.WriteLine("Underneath a pile of soil you find a purse. \nYou don't know the use of it but pick it up anyway.");

        }

        public void NoWay()
        {
            Console.WriteLine("Keep on going forward.");
        }

        public void RunOrBackQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("\nYou think to yourself \"Should I run the rest of the part [run]? Or should I go back to find something more [back]?\".");
                Console.Write("> ");
                var userInput = Console.ReadLine().ToLower();

                if (userInput == "run")
                {
                    Console.WriteLine("You hope for the best and start to run. \n\nThe flashlight continues to flicker as you run through the narrow passage.\nWhen you see the end of the passage you also see smoke covering it. \nSuddenly the flashlight dies. ");
                    notChosen = true;
                    CoolOrCrawlQuest();

                }
                else if (userInput == "back")
                {
                    notChosen = true;
                    Console.WriteLine("You are back at the beginning.");
                    WayQuest();

                }

            }
        }

        public void CoolOrCrawlQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("What are you going to do? Start crawling [crawl] or play it cool [cool]?");
                Console.Write("> ");
                var userInput = Console.ReadLine().ToLower();
                
                if (userInput == "crawl")
                {
                    Console.WriteLine("After crawling for a while you see a red light in front of you. \nYou continue towards it and soon you see a pair of shoes. \nAs you look up you see the weird man you met outside the cave. \nHe starts to laugh and says \"you can get up now\".\nAs you raise he follows it up with only two words \"Receipt please\".");
                    notChosen = true;
                    ManQuest();

                }
                else if (userInput == "cool")
                {
                    notChosen = true;
                    Console.WriteLine("After playing it cool for a while you see a red light in front of you. \nYou continue towards it soon you see the weird man you met outside the cave. \nHe also plays it cool and says only two words \"Receipt please\".");
                    ManQuest();
                }
            }
        }

        public void ManQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("Do you know what he talks about? [yes] / [no]");
                Console.Write("> ");
                var UserInput = Console.ReadLine().ToLower();

                if (UserInput == "yes")
                {
                    notChosen = true;
                    if (playerHasReceipt)
                    {
                        Console.WriteLine("You remember the receipt from the bar and give it to the man.");
                        Console.WriteLine("The receipt is visual and you need to spell the right buzzword.");
                        var buzzword = Console.ReadLine();

                        while(buzzword != "true")
                        {
                            Console.WriteLine("Please try again");
                        }

                        Console.WriteLine("\"Enjoy! - weird man\"");
                        Console.WriteLine("The weird man opens a hidden door to let you in.");
                        PartyWay();
                    }
                    else
                    {
                        Console.WriteLine("You don't know what he talks about! You need to go back to the beginning.");
                        WayQuest();
                    }
                }
                else if( UserInput == "no")
                {
                    notChosen = true;
                    Console.WriteLine("You need to go back to the beginning.");
                    WayQuest();
                }
            }
        }

        public void PartyWay()
        {
            Console.WriteLine("You walk through the door and meet deafening screams. \nYou now understand that it's a party going on.\nYou chill for a bit before you recognize some people having a laugh in the corner. \nYou go over to see what's so funny. \nIt's a balloon machine.");
            BallonQuest();
        }

        public void BallonQuest()
        {
            var notChosen = false;

            while(!notChosen)
            {
                Console.WriteLine("You want to buy one. Do you have any money? [yes] / [no]");
                var userInput = Console.ReadLine();

                if(userInput == "yes")
                {
                    if(playerHasPurse && playerHasMoney)
                    {
                        notChosen = true;
                        Console.WriteLine("You buy a balloon which takes you up...\n");
                        StoryEnd();
                    }
                    else
                    {
                        notChosen = true;
                        Console.WriteLine("Unfortunally you don't have any coins.");
                        StoryEnd();
                    }
                }
                else if (userInput == "no")
                {
                    Console.WriteLine("The only thing you can do is take drugs and die a slowly death. \nYou died.");
                    StoryEnd();
                }
            }

        }

        public void RightQuest()
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
                    SoundQuest();

                }
                else if (userInput == "look")
                {
                    notChosen = true;
                    LookMoreInBarQuest();
                }

            }
        }

        public void SoundQuest()
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
                    ScreamWay();

                }
                else if (userInput == "silence")
                {
                    notChosen = true;
                    SilenceWay();
                }
            }
        }

        public void SilenceWay()
        {
            Console.WriteLine("The silence is creeping up on you. But you keep on walking.\nSuddenly the ground disappear under you feet. \nYou fall and fall until you find yourself at a party.\nThere is no way out. \nThe only thing you can do is take drugs and die a slowly death. \nYou died.");
            StoryEnd();
        }

        public void LookMoreInBarQuest()
        {
            if(playerHasPurse)
            {
                playerHasMoney = true;
                Console.WriteLine("You find some coins in the old cashier and realise why you have the purse.\n You put the coins in the purse and continues.");
                SoundQuest();
            }
            else
            {
                Console.WriteLine("You find some coins in the old cashier but don't know where to put them.\n You have to leave the cashier.");
                SoundQuest();
            }
        }

        public void ScreamWay()
        {
            Console.WriteLine("There's a door on your left. You open it.");
            LeftWay();
        }

        public void StoryEnd()
        {
            Console.WriteLine("The next morning: \nYou wake up and realise you had the most fucked up dream ever!");
        }

    }
}
