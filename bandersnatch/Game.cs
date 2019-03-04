using System;
using System.Drawing;
using Console = Colorful.Console;
using System.Collections.Generic;
using System.Linq;

namespace bandersnatch
{


    public class Game : Quests
    {
        public bool playerHasReceipt = false;
        public bool playerHasPurse = false;
        public bool playerHasMoney = false;
        public string user = "human";

        public Game()
        {
            
        }

        static string ReadQuest(string prompt, string value1, string value2, string error)
        {
            while(true)
            {
                Console.WriteLine(prompt);
                Console.WriteLine("[" + value1 + "] / [" + value2 + "]", Color.Green);
                Console.Write("> ");

                var userInput = Console.ReadLine().ToLower();

                if(userInput == value1 || userInput == value2)
                {
                    return userInput;
                }

                Console.WriteLine(error);

                return userInput;
            }
        
        }

        static void PrintQuest(List<string> text)
        {
            var longestRow = text.OrderByDescending(x => x.Length).First().Length + 8;

            var topConers = ".";
            var topLeftCorner = "| .";
            var topRightCorner = ". |";
            var bottomLeftCorner = "| '";
            var bottomRightCorner = "' |"; 
            var bottomCorners = "'";
            var leftSide = "| | ";
            var rightSide = " | |";

            foreach (var dash in topConers)
            {
                var topLineLenght = longestRow - 2;
                var secondLineLength = longestRow - 6;
                var dashes = new string('-', topLineLenght);
                var secondDashes = new string('-', secondLineLength);

                var topLine = $"{topConers}{dashes}{topConers}";
                var secondLine = $"{topLeftCorner}{secondDashes}{topRightCorner}";
                Console.WriteLine(topLine, Color.Cyan);
                Console.WriteLine(secondLine, Color.Cyan);

            }

            foreach (var line in text)
            {
                var lineLenght = line.Length;
                var margin = longestRow - lineLenght - 8;
                var spaces = new string(' ', margin / 2);
                var currentLine = $"{leftSide}{spaces}{line}{spaces}{rightSide}";

                Console.WriteLine(currentLine, Color.Cyan);

            }

            foreach (var dash in bottomCorners)
            {
                var bottomLineLenght = longestRow - 2;
                var secondLineLength = longestRow - 6;
                var dashes = new string('-', bottomLineLenght);
                var secondDashes = new string('-', secondLineLength);

                var topLine = $"{bottomCorners}{dashes}{bottomCorners}";
                var secondLine = $"{bottomLeftCorner}{secondDashes}{bottomRightCorner}";
                Console.WriteLine(secondLine, Color.Cyan);
                Console.WriteLine(topLine, Color.Cyan);
            }
        }

        public void StoryStart()
        {
            Console.Clear();
            PrintQuest(Intro);

            while (user == "human")
            {
                var typeOfUser = ReadQuest("\"Are you a Wizard or a Barbarian?\" - Weird man", "wizard", "barbarian", "\"As weird as it look you must be something else than a human!\" - Weird man");

                if (typeOfUser == "wizard" || typeOfUser == "barbarian")
                {
                    user = $"{typeOfUser}";
                    Console.WriteLine("\"What's your name?\" - Weird man", Color.Yellow);
                    Console.Write("> ");
                    var userName = Console.ReadLine().ToLower();
                    Console.WriteLine();
                    Console.WriteLine($"\"Hello {typeOfUser} {userName}!", Color.Yellow);
                    Console.WriteLine("I fear this is a very scary and dark cave and you might never return ", Color.Yellow);
                    Console.WriteLine("but I want to give you a flashlight that can help you in there.", Color.Yellow);
                    Console.WriteLine($"Here you go little {typeOfUser}.\" - Weird man", Color.Yellow);
                    Console.WriteLine();
                }
            }

            PrintQuest(Intro2);

            WayQuest();
        }

        public void WayQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                var chosenWay = ReadQuest("You can either go right or left. Which way do you go?", "left", "right", "Sorry, but that is not an alternative");

                if (chosenWay == "left")
                {
                    notChosen = true;
                    LeftWay();
                }
                else if (chosenWay == "right")
                {
                    notChosen = true;
                    playerHasReceipt = true;
                    RightWay();

                }
            }
        }

        public void RightWay()
        {
            Console.Clear();
            PrintQuest(Right);

            //receipt
            Console.WriteLine("           ▄▄▄█████▓            ", Color.Red);
            Console.WriteLine("           ▓  ██▒ ▓▒            ", Color.Red);
            Console.WriteLine("           ▒ ▓██░ ▒░            ", Color.Red);
            Console.WriteLine("           ░ ▓██▓ ░             ", Color.Red);
            Console.WriteLine("             ▒██▒ ░             ", Color.Red);
            Console.WriteLine("             ▒ ░░               ", Color.Red);
            Console.WriteLine("               ░                ", Color.Red);
            Console.WriteLine("             ░                  ", Color.Red);
            Console.WriteLine("   █    ██              ██▀███  ", Color.Red);
            Console.WriteLine("   ██  ▓██▒            ▓██ ▒ ██▒", Color.Red);
            Console.WriteLine("  ▓██  ▒██░            ▓██ ░▄█ ▒", Color.Red);
            Console.WriteLine("  ▓▓█  ░██░            ▒██▀▀█▄  ", Color.Red);
            Console.WriteLine("  ▒▒█████▓             ░██▓ ▒██▒", Color.Red);
            Console.WriteLine("  ░▒▓▒ ▒ ▒             ░ ▒▓ ░▒▓░", Color.Red);
            Console.WriteLine("  ░░▒░ ░ ░               ░▒ ░ ▒░", Color.Red);
            Console.WriteLine("   ░░░ ░ ░               ░░   ░ ", Color.Red);
            Console.WriteLine("     ░                    ░     ", Color.Red);
            Console.WriteLine("              ▓█████            ", Color.Red);
            Console.WriteLine("              ▓█   ▀            ", Color.Red);
            Console.WriteLine("              ▒███              ", Color.Red);
            Console.WriteLine("              ▒▓█  ▄            ", Color.Red);
            Console.WriteLine("              ░▒████▒           ", Color.Red);
            Console.WriteLine("              ░░ ▒░ ░           ", Color.Red);
            Console.WriteLine("               ░ ░  ░           ", Color.Red);
            Console.WriteLine("                 ░              ", Color.Red);
            Console.WriteLine("                 ░  ░           ", Color.Red);

            PrintQuest(Right1);

            RightQuest();
        }

        public void LeftWay()
        {
            Console.Clear();
            PrintQuest(Left);

            LeftQuest();
        }

        public void LeftQuest()
        {
            if(!playerHasPurse)
            {
                var notChosen = false;

                while (!notChosen)
                {
                    PrintQuest(Left1);

                    var userInput = ReadQuest("Should you take a look?", "yes", "no", "Sorry, but that is not an alternative");

                    if (userInput == "yes")
                    {
                        notChosen = true;

                        YesWay();

                        PrintQuest(Left2);

                        RunOrBackQuest();
                    }
                    else if (userInput == "no")
                    {
                        notChosen = true;

                        NoWay();

                        PrintQuest(Left2);

                        RunOrBackQuest();
                    }
                }

            }
            else {
                RunOrBackQuest();
            }
        }

        public void YesWay()
        {
            playerHasPurse = true;

            Console.Clear();

            PrintQuest(Yes);
        }

        public void NoWay()
        {
            Console.Clear();

            PrintQuest(No);
        }

        public void RunOrBackQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                var userInput = ReadQuest("Should you run the rest of the part or go back to see if you can find something more?", "run", "back", "Sorry, but that is not an alternative");

                if (userInput == "run")
                {
                    Console.Clear();

                    PrintQuest(Run);

                    notChosen = true;

                    CoolOrCrawlQuest();

                }
                else if (userInput == "back")
                {
                    notChosen = true;

                    Console.Clear();

                    PrintQuest(Back);

                    WayQuest();

                }

            }
        }

        public void CoolOrCrawlQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                var userInput = ReadQuest("What are you going to do? Start crawling or play it cool?", "crawl", "cool", "Sorry, but that is not an alternative");
                
                if (userInput == "crawl")
                {
                    notChosen = true;

                    Console.Clear();

                    PrintQuest(Crawl);

                    Console.WriteLine("\"Receipt, please.\"", Color.Yellow);

                    ManQuest();

                }
                else if (userInput == "cool")
                {
                    notChosen = true;

                    Console.Clear();

                    PrintQuest(Cool);

                    Console.WriteLine("\"Receipt, please.\"", Color.Yellow);

                    ManQuest();
                }
            }
        }

        public void ManQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                var userInput = ReadQuest("Do you know what he talks about?", "yes", "no", "Sorry, but that is not an alternative");

                if (userInput == "yes")
                {
                    notChosen = true;

                    if (playerHasReceipt)
                    {
                        Console.Clear();

                        PrintQuest(Receipt1);

                        Console.WriteLine("           ▄▄▄█████▓            ", Color.Red);
                        Console.WriteLine("           ▓  ██▒ ▓▒            ", Color.Red);
                        Console.WriteLine("           ▒ ▓██░ ▒░            ", Color.Red);
                        Console.WriteLine("           ░ ▓██▓ ░             ", Color.Red);
                        Console.WriteLine("             ▒██▒ ░             ", Color.Red);
                        Console.WriteLine("             ▒ ░░               ", Color.Red);
                        Console.WriteLine("               ░                ", Color.Red);
                        Console.WriteLine("             ░                  ", Color.Red);
                        Console.WriteLine("   █    ██              ██▀███  ", Color.Red);
                        Console.WriteLine("   ██  ▓██▒            ▓██ ▒ ██▒", Color.Red);
                        Console.WriteLine("  ▓██  ▒██░            ▓██ ░▄█ ▒", Color.Red);
                        Console.WriteLine("  ▓▓█  ░██░            ▒██▀▀█▄  ", Color.Red);
                        Console.WriteLine("  ▒▒█████▓             ░██▓ ▒██▒", Color.Red);
                        Console.WriteLine("  ░▒▓▒ ▒ ▒             ░ ▒▓ ░▒▓░", Color.Red);
                        Console.WriteLine("  ░░▒░ ░ ░               ░▒ ░ ▒░", Color.Red);
                        Console.WriteLine("   ░░░ ░ ░               ░░   ░ ", Color.Red);
                        Console.WriteLine("     ░                    ░     ", Color.Red);
                        Console.WriteLine("              ▓█████            ", Color.Red);
                        Console.WriteLine("              ▓█   ▀            ", Color.Red);
                        Console.WriteLine("              ▒███              ", Color.Red);
                        Console.WriteLine("              ▒▓█  ▄            ", Color.Red);
                        Console.WriteLine("              ░▒████▒           ", Color.Red);
                        Console.WriteLine("              ░░ ▒░ ░           ", Color.Red);
                        Console.WriteLine("               ░ ░  ░           ", Color.Red);
                        Console.WriteLine("                 ░              ", Color.Red);
                        Console.WriteLine("                 ░  ░           ", Color.Red);

                        Console.WriteLine("\"You need to spell the right buzzword.\" - Weird man", Color.Yellow);

                        var buzzword = Console.ReadLine();

                        while (buzzword != "true")
                        {                         
                            Console.WriteLine("Please try again");
                            buzzword = Console.ReadLine().ToLower();
                        }

                        Console.WriteLine("\"Enjoy! - Weird man\"", Color.Yellow);

                        Console.Clear();
                        PrintQuest(Receipt2);

                        PartyWay();
                    }
                    else
                    {
                        Console.Clear();
                        PrintQuest(Receipt3);

                        WayQuest();
                    }
                }
                else if(userInput == "no")
                {
                    notChosen = true;

                    Console.Clear();
                    PrintQuest(Receipt4);

                    WayQuest();
                }
            }
        }

        public void PartyWay()
        {
            PrintQuest(Party);

            BallonQuest();
        }

        public void BallonQuest()
        {
            var notChosen = false;

            while(!notChosen)
            {
                var userInput = ReadQuest("You want to buy one. Do you have any money?", "yes", "no", "Sorry, but that is not an alternative");

                if(userInput == "yes")
                {
                    if(playerHasPurse && playerHasMoney)
                    {
                        notChosen = true;

                        Console.Clear();
                        PrintQuest(Balloon);

                        StoryEnd();
                    }
                    else if (playerHasPurse && !playerHasMoney)
                    {
                        notChosen = true;

                        Console.Clear();
                        PrintQuest(NoCoins);

                        StoryEnd();
                    }
                }
                else if (userInput == "no")
                {
                    notChosen = true;

                    Console.Clear();
                    PrintQuest(NoBalloon);

                    StoryEnd();
                }
            }

        }

        public void RightQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                var userInput = ReadQuest("You can now either go forward or look more in the bar. What do you do?", "forward", "look", "Sorry, but that is not an alternative");

                if (userInput == "forward")
                {
                    Console.Clear();
                    PrintQuest(Forward);

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
                var userInput = ReadQuest("Which way do you choose?", "scream", "silence", "Sorry, but that is not an alternative");

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
            Console.Clear();
            PrintQuest(Silence);

            StoryEnd();
        }

        public void LookMoreInBarQuest()
        {
            if(playerHasPurse)
            {
                playerHasMoney = true;

                Console.Clear();
                PrintQuest(HasPurse);
            
                SoundQuest();
            }
            else
            {
                Console.Clear();
                PrintQuest(HasNoPurse);

                SoundQuest();
            }
        }

        public void ScreamWay()
        {
            Console.Clear();
            PrintQuest(Scream);

            LeftWay();
        }

        public void StoryEnd()
        {
            // not using the printquest function since it's another color
            Console.WriteLine(".--------------------------------------------------------------------.", Color.DarkRed);
            Console.WriteLine("| .----------------------------------------------------------------. |", Color.DarkRed);
            Console.WriteLine("| |                                                                | |", Color.DarkRed);
            Console.WriteLine("| |                      The next morning:                         | |", Color.DarkRed);
            Console.WriteLine("| |                                                                | |", Color.DarkRed);
            Console.WriteLine("| | You wake up and realise you had the most fucked up dream ever! | |", Color.DarkRed);
            Console.WriteLine("| |                                                                | |", Color.DarkRed);
            Console.WriteLine("| '----------------------------------------------------------------' |", Color.DarkRed);
            Console.WriteLine("'--------------------------------------------------------------------'", Color.DarkRed);

            RestartGame();
        }

        public void RestartGame()
        {
            playerHasMoney = false;
            playerHasPurse = false;
            playerHasReceipt = false;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press <Enter> to restart the game");

            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                StoryStart();
            }
        }

    }
}
