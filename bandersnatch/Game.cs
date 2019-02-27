using System;
using System.Drawing;
using Console = Colorful.Console;

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
            Console.WriteLine(".--------------------------------------------------.", Color.Cyan);
            Console.WriteLine("| .----------------------------------------------. |", Color.Cyan);
            Console.WriteLine("| |  The people of Winerfall has requested your  | |", Color.Cyan);
            Console.WriteLine("| |  help to enter the big and scary cave.       | |", Color.Cyan);
            Console.WriteLine("| |                                              | |", Color.Cyan);
            Console.WriteLine("| |              You accept the quest.           | |", Color.Cyan);
            Console.WriteLine("| |                                              | |", Color.Cyan);
            Console.WriteLine("| |  Outside you meet a man, he warns you to     | |", Color.Cyan);
            Console.WriteLine("| |  enter the cave and ask you who you are.     | |", Color.Cyan);
            Console.WriteLine("| '----------------------------------------------' |", Color.Cyan);
            Console.WriteLine("'--------------------------------------------------'", Color.Cyan);

            while (user == "human")
            {
                Console.WriteLine("\"Are you a Wizard or a Barbarian?\" - Weird man", Color.Yellow);
                Console.WriteLine("[wizard] / [barbarian]", Color.Green);
                Console.Write("> ");

                var typeOfUser = Console.ReadLine().ToLower();

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
                else
                {
                    Console.WriteLine($"\"As weird as it look you must be something else than a {typeOfUser}\" - Weird man", Color.Yellow);
                }
            }

            Console.WriteLine(".---------------------------------------------------.", Color.Cyan);
            Console.WriteLine("| .-----------------------------------------------. |", Color.Cyan);
            Console.WriteLine("| |                                               | |", Color.Cyan);
            Console.WriteLine("| |     You decide to enter the cave without      | |", Color.Cyan);
            Console.WriteLine("| |    knowing if you'll ever come out of it...   | |", Color.Cyan);
            Console.WriteLine("| |                                               | |", Color.Cyan);
            Console.WriteLine("| |   Inside the cave you hear load screams and   | |", Color.Cyan);
            Console.WriteLine("| |        instantly regret you entered it.       | |", Color.Cyan);
            Console.WriteLine("| |     You turn around to get out but realise    | |", Color.Cyan);
            Console.WriteLine("| |it is alredy too late, the entrance is blocked.| |", Color.Cyan);
            Console.WriteLine("| |                                               | |", Color.Cyan);
            Console.WriteLine("| |           You now have no choice but          | |", Color.Cyan);
            Console.WriteLine("| |            to find another way out...         | |", Color.Cyan);
            Console.WriteLine("| |                                               | |", Color.Cyan);
            Console.WriteLine("| | With help of the flashlight you start walking.| |", Color.Cyan);
            Console.WriteLine("| |  The screams seems to disappear for a while.  | |", Color.Cyan);
            Console.WriteLine("| |        In front of you is a crossroad.        | |", Color.Cyan);
            Console.WriteLine("| |                                               | |", Color.Cyan);
            Console.WriteLine("| '-----------------------------------------------' |", Color.Cyan);
            Console.WriteLine("'---------------------------------------------------'", Color.Cyan);

            WayQuest();
        }

        public void WayQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("You can either go right or left. Which way do you go?");
                Console.WriteLine("[left] / [right]", Color.Green);
                Console.Write("> ");

                var chosenWay = Console.ReadLine().ToLower();

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

            Console.WriteLine(".-------------------------------------------------------.", Color.Cyan);
            Console.WriteLine("| .---------------------------------------------------. |", Color.Cyan);
            Console.WriteLine("| |                                                   | |", Color.Cyan);
            Console.WriteLine("| | You walk from the screams. You are not ready yet! | |", Color.Cyan);
            Console.WriteLine("| |         In the distance you see a light.          | |", Color.Cyan);
            Console.WriteLine("| |                                                   | |", Color.Cyan);
            Console.WriteLine("| |     You follow it and find yourself in a bar.     | |", Color.Cyan);
            Console.WriteLine("| |     The bar is empty, but you find a receipt.     | |", Color.Cyan);
            Console.WriteLine("| |                                                   | |", Color.Cyan);
            Console.WriteLine("| |                   You read it:                    | |", Color.Cyan);
            Console.WriteLine("| |                                                   | |", Color.Cyan);
            Console.WriteLine("| '---------------------------------------------------' |", Color.Cyan);
            Console.WriteLine("'-------------------------------------------------------'", Color.Cyan);

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

            Console.WriteLine(".-------------------------------------------------------------------.", Color.Cyan);
            Console.WriteLine("| .---------------------------------------------------------------. |", Color.Cyan);
            Console.WriteLine("| |                                                               | |", Color.Cyan);
            Console.WriteLine("| | You can't make any sense out of it but put it in your pocket. | |", Color.Cyan);
            Console.WriteLine("| |                                                               | |", Color.Cyan);
            Console.WriteLine("| '---------------------------------------------------------------' |", Color.Cyan);
            Console.WriteLine("'-------------------------------------------------------------------'", Color.Cyan);

            RightQuest();
        }

        public void LeftWay()
        {
            Console.Clear();

            Console.WriteLine(".--------------------------------------------------.", Color.Cyan);
            Console.WriteLine("| .----------------------------------------------. |", Color.Cyan);
            Console.WriteLine("| |                                              | |", Color.Cyan);
            Console.WriteLine("| | You chose the left path and keep on walking. | |", Color.Cyan);
            Console.WriteLine("| |                                              | |", Color.Cyan);
            Console.WriteLine("| '----------------------------------------------' |", Color.Cyan);
            Console.WriteLine("'--------------------------------------------------'", Color.Cyan);

            LeftQuest();
        }

        public void LeftQuest()
        {
            if(!playerHasPurse)
            {
                var notChosen = false;

                while (!notChosen)
                {
                    Console.Clear();

                    Console.WriteLine(".----------------------------------------.", Color.Cyan);
                    Console.WriteLine("| .------------------------------------. |", Color.Cyan);
                    Console.WriteLine("| |                                    | |", Color.Cyan);
                    Console.WriteLine("| | Suddenly you stumble on something. | |", Color.Cyan);
                    Console.WriteLine("| |                                    | |", Color.Cyan);
                    Console.WriteLine("| '------------------------------------' |", Color.Cyan);
                    Console.WriteLine("'----------------------------------------'", Color.Cyan);

                    Console.WriteLine("Should you take a look?");
                    Console.WriteLine("[yes] / [no]", Color.Green);
                    Console.Write("> ");

                    var userInput = Console.ReadLine().ToLower();
                    
                    if (userInput == "yes")
                    {
                        notChosen = true;

                        YesWay();

                        Console.Clear();

                        Console.WriteLine(".---------------------------------------------------------------------.", Color.Cyan);
                        Console.WriteLine("| .-----------------------------------------------------------------. |", Color.Cyan);
                        Console.WriteLine("| |                                                                 | |", Color.Cyan);
                        Console.WriteLine("| | You stop for a second as you see the passage is narrowing down. | |", Color.Cyan);
                        Console.WriteLine("| |      At the same time the flashlight start to flicker,          | |", Color.Cyan);
                        Console.WriteLine("| |       you can't see the end of the passage and wonder           | |", Color.Cyan);
                        Console.WriteLine("| |       for how long you have to walk in this condition.          | |", Color.Cyan);
                        Console.WriteLine("| |                                                                 | |", Color.Cyan);
                        Console.WriteLine("| '-----------------------------------------------------------------' |", Color.Cyan);
                        Console.WriteLine("'---------------------------------------------------------------------'", Color.Cyan);

                        RunOrBackQuest();
                    }
                    else if (userInput == "no")
                    {
                        notChosen = true;

                        NoWay();

                        Console.Clear();

                        Console.WriteLine(".---------------------------------------------------------------------.", Color.Cyan);
                        Console.WriteLine("| .-----------------------------------------------------------------. |", Color.Cyan);
                        Console.WriteLine("| |                                                                 | |", Color.Cyan);
                        Console.WriteLine("| | You stop for a second as you see the passage is narrowing down. | |", Color.Cyan);
                        Console.WriteLine("| |      At the same time the flashlight start to flicker,          | |", Color.Cyan);
                        Console.WriteLine("| |       you can't see the end of the passage and wonder           | |", Color.Cyan);
                        Console.WriteLine("| |       for how long you have to walk in this condition           | |", Color.Cyan);
                        Console.WriteLine("| |                                                                 | |", Color.Cyan);
                        Console.WriteLine("| '-----------------------------------------------------------------' |", Color.Cyan);
                        Console.WriteLine("'---------------------------------------------------------------------'", Color.Cyan);

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

            Console.WriteLine(".---------------------------------------------------------.", Color.Cyan);
            Console.WriteLine("| .-----------------------------------------------------. |", Color.Cyan);
            Console.WriteLine("| |                                                     | |", Color.Cyan);
            Console.WriteLine("| |     Underneath a pile of soil you find a purse      | |", Color.Cyan);
            Console.WriteLine("| | You don't know the use of it but pick it up anyway. | |", Color.Cyan);
            Console.WriteLine("| |                                                     | |", Color.Cyan);
            Console.WriteLine("| '-----------------------------------------------------' |", Color.Cyan);
            Console.WriteLine("'---------------------------------------------------------'", Color.Cyan);
        }

        public void NoWay()
        {
            Console.Clear();

            Console.WriteLine(".-------------------------------------.", Color.Cyan);
            Console.WriteLine("| .---------------------------------. |", Color.Cyan);
            Console.WriteLine("| |                                 | |", Color.Cyan);
            Console.WriteLine("| |     Keep on going forward.      | |", Color.Cyan);
            Console.WriteLine("| |                                 | |", Color.Cyan);
            Console.WriteLine("| '---------------------------------' |", Color.Cyan);
            Console.WriteLine("'-------------------------------------'", Color.Cyan);
        }

        public void RunOrBackQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("Should you run the rest of the part or go back to see if you can find something more?");
                Console.WriteLine("[run] / [back]", Color.Green);
                Console.Write("> ");

                var userInput = Console.ReadLine().ToLower();

                if (userInput == "run")
                {
                    Console.Clear();

                    Console.WriteLine(".--------------------------------------------------------------------------------.", Color.Cyan);
                    Console.WriteLine("| .----------------------------------------------------------------------------. |", Color.Cyan);
                    Console.WriteLine("| |                                                                            | |", Color.Cyan);
                    Console.WriteLine("| |               You hope for the best and start to run.                      | |", Color.Cyan);
                    Console.WriteLine("| | The flashlight continues to flicker as you run through the narrow passage. | |", Color.Cyan);
                    Console.WriteLine("| | When you see the end of the passage you also see smoke covering it.        | |", Color.Cyan);
                    Console.WriteLine("| |                  Suddenly the flashlight dies.                             | |", Color.Cyan);
                    Console.WriteLine("| |                                                                            | |", Color.Cyan);
                    Console.WriteLine("| '----------------------------------------------------------------------------' |", Color.Cyan);
                    Console.WriteLine("'--------------------------------------------------------------------------------'", Color.Cyan); notChosen = true;

                    CoolOrCrawlQuest();

                }
                else if (userInput == "back")
                {
                    notChosen = true;

                    Console.Clear();

                    Console.WriteLine(".-------------------------------------.", Color.Cyan);
                    Console.WriteLine("| .---------------------------------. |", Color.Cyan);
                    Console.WriteLine("| |                                 | |", Color.Cyan);
                    Console.WriteLine("| |  You are back at the beginning. | |", Color.Cyan);
                    Console.WriteLine("| |                                 | |", Color.Cyan);
                    Console.WriteLine("| '---------------------------------' |", Color.Cyan);
                    Console.WriteLine("'-------------------------------------'", Color.Cyan);

                    WayQuest();

                }

            }
        }

        public void CoolOrCrawlQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("What are you going to do? Start crawling or play it cool?");
                Console.WriteLine("[crawl] / [cool]", Color.Green);
                Console.Write("> ");

                var userInput = Console.ReadLine().ToLower();
                
                if (userInput == "crawl")
                {
                    notChosen = true;

                    Console.Clear();

                    Console.WriteLine(".--------------------------------------------------------------------.", Color.Cyan);
                    Console.WriteLine("| .----------------------------------------------------------------. |", Color.Cyan);
                    Console.WriteLine("| |                                                                | |", Color.Cyan);
                    Console.WriteLine("| | After crawling for a while you see a red light in front of you | |", Color.Cyan);
                    Console.WriteLine("| |   You continue towards it and soon you see a pair of shoes.    | |", Color.Cyan);
                    Console.WriteLine("| | As you look up you see the weird man you met outside the cave. | |", Color.Cyan);
                    Console.WriteLine("| |          He starts to laugh and tells you to get up.           | |", Color.Cyan);
                    Console.WriteLine("| |       As you raise he follows it up with only two words:       | |", Color.Cyan);
                    Console.WriteLine("| |                                                                | |", Color.Cyan);
                    Console.WriteLine("| '----------------------------------------------------------------' |", Color.Cyan);
                    Console.WriteLine("'--------------------------------------------------------------------'", Color.Cyan);

                    Console.WriteLine("\"Receipt, please.\"", Color.Yellow);

                    ManQuest();

                }
                else if (userInput == "cool")
                {
                    notChosen = true;

                    Console.Clear();

                    Console.WriteLine(".--------------------------------------------------------------------------------------.", Color.Cyan);
                    Console.WriteLine("| .----------------------------------------------------------------------------------. |", Color.Cyan);
                    Console.WriteLine("| |                                                                                  | |", Color.Cyan);
                    Console.WriteLine("| |     After playing it cool for a while you see a red light in front of you        | |", Color.Cyan);
                    Console.WriteLine("| | You continue towards it and soon you see the weird man you met outside the cave. | |", Color.Cyan);
                    Console.WriteLine("| |        As you look up you see the weird man you met outside the cave.            | |", Color.Cyan);
                    Console.WriteLine("| |             He also plays it cool and says only two words:                       | |", Color.Cyan);
                    Console.WriteLine("| |                                                                                  | |", Color.Cyan);
                    Console.WriteLine("| '----------------------------------------------------------------------------------' |", Color.Cyan);
                    Console.WriteLine("'--------------------------------------------------------------------------------------'", Color.Cyan);

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
                Console.WriteLine("Do you know what he talks about?");
                Console.WriteLine("[yes] / [no]", Color.Green);
                Console.Write("> ");

                var userInput = Console.ReadLine().ToLower();

                if (userInput == "yes")
                {
                    notChosen = true;

                    if (playerHasReceipt)
                    {
                        Console.Clear();

                        Console.WriteLine(".-------------------------------------------------------------------.", Color.Cyan);
                        Console.WriteLine("| .---------------------------------------------------------------. |", Color.Cyan);
                        Console.WriteLine("| |                                                               | |", Color.Cyan);
                        Console.WriteLine("| | You remember the receipt from the bar and give it to the man. | |", Color.Cyan);
                        Console.WriteLine("| |                                                               | |", Color.Cyan);
                        Console.WriteLine("| '---------------------------------------------------------------' |", Color.Cyan);
                        Console.WriteLine("'-------------------------------------------------------------------'", Color.Cyan);

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

                        Console.WriteLine(".------------------------------------------------------.", Color.Cyan);
                        Console.WriteLine("| .--------------------------------------------------. |", Color.Cyan);
                        Console.WriteLine("| |                                                  | |", Color.Cyan);
                        Console.WriteLine("| | The weird man opens a hidden door to let you in. | |", Color.Cyan);
                        Console.WriteLine("| |                                                  | |", Color.Cyan);
                        Console.WriteLine("| '--------------------------------------------------' |", Color.Cyan);
                        Console.WriteLine("'------------------------------------------------------'", Color.Cyan); 

                        PartyWay();
                    }
                    else
                    {
                        Console.Clear();

                        Console.WriteLine(".-------------------------------------------.", Color.Cyan);
                        Console.WriteLine("| .---------------------------------------. |", Color.Cyan);
                        Console.WriteLine("| |                                       | |", Color.Cyan);
                        Console.WriteLine("| |  You don't know what he talks about!  | |", Color.Cyan);
                        Console.WriteLine("| | You need to go back to the beginning. | |", Color.Cyan);
                        Console.WriteLine("| |                                       | |", Color.Cyan);
                        Console.WriteLine("| '---------------------------------------' |", Color.Cyan);
                        Console.WriteLine("'-------------------------------------------'", Color.Cyan); 

                        WayQuest();
                    }
                }
                else if(userInput == "no")
                {
                    notChosen = true;

                    Console.Clear();

                    Console.WriteLine(".-------------------------------------------.", Color.Cyan);
                    Console.WriteLine("| .---------------------------------------. |", Color.Cyan);
                    Console.WriteLine("| |                                       | |", Color.Cyan);
                    Console.WriteLine("| | You need to go back to the beginning. | |", Color.Cyan);
                    Console.WriteLine("| |                                       | |", Color.Cyan);
                    Console.WriteLine("| '---------------------------------------' |", Color.Cyan);
                    Console.WriteLine("'-------------------------------------------'", Color.Cyan); 

                    WayQuest();
                }
            }
        }

        public void PartyWay()
        {
            Console.Clear();

            Console.WriteLine(".----------------------------------------------------------------------------------------.", Color.Cyan);
            Console.WriteLine("| .------------------------------------------------------------------------------------. |", Color.Cyan);
            Console.WriteLine("| |                                                                                    | |", Color.Cyan);
            Console.WriteLine("| |             You walk through the door and meet deafening screams.                  | |", Color.Cyan);
            Console.WriteLine("| |                 You now understand that it's a party going on.                     | |", Color.Cyan);
            Console.WriteLine("| | You chill for a bit before you recognize some people having a laugh in the corner. | |", Color.Cyan);
            Console.WriteLine("| |            You go over to see what's so funny. It's a balloon machine.             | |", Color.Cyan);
            Console.WriteLine("| |                                                                                    | |", Color.Cyan);
            Console.WriteLine("| '------------------------------------------------------------------------------------' |", Color.Cyan);
            Console.WriteLine("'----------------------------------------------------------------------------------------'", Color.Cyan); 

            BallonQuest();
        }

        public void BallonQuest()
        {
            var notChosen = false;

            while(!notChosen)
            {
                Console.WriteLine("You want to buy one. Do you have any money?");
                Console.WriteLine("[yes] / [no]", Color.Green);

                var userInput = Console.ReadLine().ToLower();

                if(userInput == "yes")
                {
                    if(playerHasPurse && playerHasMoney)
                    {
                        notChosen = true;

                        Console.Clear();

                        Console.WriteLine(".---------------------------------------------.", Color.Cyan);
                        Console.WriteLine("| .-----------------------------------------. |", Color.Cyan);
                        Console.WriteLine("| |                                         | |", Color.Cyan);
                        Console.WriteLine("| | You buy a balloon which takes you up... | |", Color.Cyan);
                        Console.WriteLine("| |                                         | |", Color.Cyan);
                        Console.WriteLine("| '-----------------------------------------' |", Color.Cyan);
                        Console.WriteLine("'---------------------------------------------'", Color.Cyan); 

                        StoryEnd();
                    }
                    else if (playerHasPurse && !playerHasMoney)
                    {
                        notChosen = true;

                        Console.Clear();

                        Console.WriteLine(".---------------------------------------------.", Color.Cyan);
                        Console.WriteLine("| .-----------------------------------------. |", Color.Cyan);
                        Console.WriteLine("| |                                         | |", Color.Cyan);
                        Console.WriteLine("| |  Unfortunally you don't have any coins. | |", Color.Cyan);
                        Console.WriteLine("| |               You died.                 | |", Color.Cyan);
                        Console.WriteLine("| |                                         | |", Color.Cyan);
                        Console.WriteLine("| '-----------------------------------------' |", Color.Cyan);
                        Console.WriteLine("'---------------------------------------------'", Color.Cyan);

                        StoryEnd();
                    }
                }
                else if (userInput == "no")
                {
                    notChosen = true;

                    Console.Clear();

                    Console.WriteLine(".--------------------------------------------------------------------.", Color.Cyan);
                    Console.WriteLine("| .----------------------------------------------------------------. |", Color.Cyan);
                    Console.WriteLine("| |                                                                | |", Color.Cyan);
                    Console.WriteLine("| |  The only thing you can do is take drugs and die a slow death. | |", Color.Cyan);
                    Console.WriteLine("| |                         You died.                              | |", Color.Cyan);
                    Console.WriteLine("| |                                                                | |", Color.Cyan);
                    Console.WriteLine("| '----------------------------------------------------------------' |", Color.Cyan);
                    Console.WriteLine("'--------------------------------------------------------------------'", Color.Cyan); 

                    StoryEnd();
                }
            }

        }

        public void RightQuest()
        {
            var notChosen = false;

            while (!notChosen)
            {
                Console.WriteLine("You can now either go forward or look more in the bar. \nWhat do you do?");
                Console.WriteLine("[forward] / [look]", Color.Green);
                Console.Write("> ");

                var userInput = Console.ReadLine().ToLower();

                if (userInput == "forward")
                {
                    Console.Clear();

                    Console.WriteLine(".-------------------------------------------------------.", Color.Cyan);
                    Console.WriteLine("| .---------------------------------------------------. |", Color.Cyan);
                    Console.WriteLine("| |                                                   | |", Color.Cyan);
                    Console.WriteLine("| | You walk forward and hear the screams once again. | |", Color.Cyan);
                    Console.WriteLine("| |   You now have the choice to follow the screams   | |", Color.Cyan);
                    Console.WriteLine("| |        or walk towards the scary silence.         | |", Color.Cyan);
                    Console.WriteLine("| |                                                   | |", Color.Cyan);
                    Console.WriteLine("| '---------------------------------------------------' |", Color.Cyan);
                    Console.WriteLine("'-------------------------------------------------------'", Color.Cyan); 

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
                Console.WriteLine("Which way do you choose?");
                Console.WriteLine("[scream] / [silence]", Color.Green);
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
            Console.Clear();

            Console.WriteLine(".----------------------------------------------------------------------.", Color.Cyan);
            Console.WriteLine("| .------------------------------------------------------------------. |", Color.Cyan);
            Console.WriteLine("| |                                                                  | |", Color.Cyan);
            Console.WriteLine("| |    The silence is creeping up on you but you keep on walking.    | |", Color.Cyan);
            Console.WriteLine("| |          Suddenly the ground disappear under you feet.           | |", Color.Cyan);
            Console.WriteLine("| |      You fall and fall until you find yourself at a party.       | |", Color.Cyan);
            Console.WriteLine("| |                     There is no way out.                         | |", Color.Cyan);
            Console.WriteLine("| |   The only thing you can do is take drugs and die a slow death.  | |", Color.Cyan);
            Console.WriteLine("| |                                                                  | |", Color.Cyan);
            Console.WriteLine("| |                         You died.                                | |", Color.Cyan);
            Console.WriteLine("| |                                                                  | |", Color.Cyan);
            Console.WriteLine("| '------------------------------------------------------------------' |", Color.Cyan);
            Console.WriteLine("'----------------------------------------------------------------------'", Color.Cyan); 

            StoryEnd();
        }

        public void LookMoreInBarQuest()
        {
            if(playerHasPurse)
            {
                playerHasMoney = true;

                Console.Clear();

                Console.WriteLine(".--------------------------------------------------------------------------------.", Color.Cyan);
                Console.WriteLine("| .----------------------------------------------------------------------------. |", Color.Cyan);
                Console.WriteLine("| |                                                                            | |", Color.Cyan);
                Console.WriteLine("| | You find some coins in the old cashier and realise why you have the purse. | |", Color.Cyan);
                Console.WriteLine("| |               You put the coins in the purse and continues.                | |", Color.Cyan);
                Console.WriteLine("| |                                                                            | |", Color.Cyan);
                Console.WriteLine("| '----------------------------------------------------------------------------' |", Color.Cyan);
                Console.WriteLine("'--------------------------------------------------------------------------------'", Color.Cyan); 

                SoundQuest();
            }
            else
            {
                Console.Clear();

                Console.WriteLine(".-----------------------------------------------.", Color.Cyan);
                Console.WriteLine("| .-------------------------------------------. |", Color.Cyan);
                Console.WriteLine("| |                                           | |", Color.Cyan);
                Console.WriteLine("| |   You find some coins in the old cashier  | |", Color.Cyan);
                Console.WriteLine("| |      but don't know where to put them.    | |", Color.Cyan);
                Console.WriteLine("| |       You have to leave the cashier.      | |", Color.Cyan);
                Console.WriteLine("| |                                           | |", Color.Cyan);
                Console.WriteLine("| '-------------------------------------------' |", Color.Cyan);
                Console.WriteLine("'-----------------------------------------------'", Color.Cyan);

                SoundQuest();
            }
        }

        public void ScreamWay()
        {
            Console.Clear();

            Console.WriteLine(".-----------------------------------------------.", Color.Cyan);
            Console.WriteLine("| .-------------------------------------------. |", Color.Cyan);
            Console.WriteLine("| |                                           | |", Color.Cyan);
            Console.WriteLine("| | There's a door on your left. You open it. | |", Color.Cyan);
            Console.WriteLine("| |                                           | |", Color.Cyan);
            Console.WriteLine("| '-------------------------------------------' |", Color.Cyan);
            Console.WriteLine("'-----------------------------------------------'", Color.Cyan); 

            LeftWay();
        }

        public void StoryEnd()
        {
            Console.WriteLine(".--------------------------------------------------------------------.", Color.DarkRed);
            Console.WriteLine("| .----------------------------------------------------------------. |", Color.DarkRed);
            Console.WriteLine("| |                                                                | |", Color.DarkRed);
            Console.WriteLine("| |                      The next morning:                         | |", Color.DarkRed);
            Console.WriteLine("| |                                                                | |", Color.DarkRed);
            Console.WriteLine("| | You wake up and realise you had the most fucked up dream ever! | |", Color.DarkRed);
            Console.WriteLine("| |                                                                | |", Color.DarkRed);
            Console.WriteLine("| '----------------------------------------------------------------' |", Color.DarkRed);
            Console.WriteLine("'--------------------------------------------------------------------'", Color.DarkRed);
        }

    }
}
