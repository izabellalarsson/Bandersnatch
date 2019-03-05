using System;
using System.Collections.Generic;
using System.Linq;

namespace bandersnatch
{
    public class Quests
    {
        public List<string> Intro = new List<string>() {
            " ",
            "The people of Winterfall has requested your",
            "help to enter the big and scary cave.",
            "You accept the quest.",
            "Outside you meet a man, he warns you to",
            "enter the cave and ask you who you are.",
            " "
        };

        public List<string> Intro2 = new List<string>() {
            " ",
            "You decide to enter the cave without ",
            "knowing if you'll ever come out of it... ",
            "Inside the cave you hear loud screams and  ",
            "instantly regret you entered it. ",
            "You turn around to get out but realise ",
            "it is alredy too late, the entrance is blocked.",
            " ",
            "You now have no choice but ",
            "to find another way out... ",
            " ",
            "With help of the flashlight you start walking. ",
            "The screams seems to disappear for a while.",
            "In front of you is a crossroad.",
            " "
        };  

        public List<string> Right = new List<string>() {
            "",
            "You walk from the screams. You are not ready yet",
            "In the distance you see a light.",
            "",
            " You follow it and find yourself in a bar.",
            " The bar is empty, but you find a receipt.",
            "",
            "You read it:",
            ""
        };        

        public List<string> Right1 = new List<string>() {
            " ",
            "You can't make any sense out of it but put it in your pocket.",
            " "
        };       

        public List<string> Left = new List<string>() {
            "",
            "You chose the left path and keep on walking.",
            ""
        };        

        public List<string> Left1 = new List<string>() {
            "",
            "Suddenly you stumble on something.",
            ""
        };

        public List<string> Left2 = new List<string>() {
            " ",
            "You stop for a second as you see the passage is narrowing down.",
            "At the same time the flashlight start to flicker,",
            "you can't see the end of the passage and wonder",
            "for how long you have to walk in this condition. ",
            " "
        };

        public List<string> Yes = new List<string>() {
            " ",
            "Underneath a pile of soil you find a purse.",
            "You don't know the use of it but pick it up anyway.",
            " "
        };        

        public List<string> No = new List<string>() {
            "",
            "Keep on going forward.",
            ""
        };

        public List<string> Run = new List<string>() {
            "",
            "You hope for the best and start to run. ",
            "The flashlight continues to flicker as you run through the narrow passage.",
            "When you see the end of the passage you also see smoke covering it. ",
            "Suddenly the flashlight dies. ",
            ""
        };

        public List<string> Back = new List<string>() {
            "",
            "You are back at the beginning.",
            ""
        };

        public List<string> Crawl = new List<string>() {
            "",
            "After crawling for a while you see a red light in front of you",
            "You continue towards it and soon you see a pair of shoes. ",
            "As you look up you see the weird man you met outside the cave.",
            "He starts to laugh and tells you to get up. ",
            "As you raise he follows it up with only two words:",
            ""
        };        

        public List<string> Cool = new List<string>() {
            "",
            "After playing it cool for a while you see a red light in front of you.",
            "You continue towards it and soon you see the weird man you met outside the cave.",
            "He also plays it cool and says only two words:",
            ""
        };        

        public List<string> Receipt1 = new List<string>() {
            " ",
            "You remember the receipt from the bar and give it to the man.",
            " "
        };        

        public List<string> Receipt2 = new List<string>() {
            "",
            "The weird man opens a hidden door to let you in.",
            ""
        };        

        public List<string> Receipt3 = new List<string>() {
            " ",
            "You don't know what he talks about!",
            "You need to go back to the beginning.",
            " "
        };        

        public List<string> Receipt4 = new List<string>() {
            " ",
            "You need to go back to the beginning.",
            " "
        };

        public List<string> Party = new List<string>() {
            "",
            "You walk through the door and meet deafening screams. ",
            "You now understand that it's a party going on.",
            "You chill for a bit before you recognize some people having a laugh in the corner.",
            "You go over to see what's so funny. It's a balloon machine. ",
            ""
        };        

        public List<string> Balloon = new List<string>() {
            " ",
            "You buy a balloon which takes you up...",
            " "
        };        

        public List<string> NoCoins = new List<string>() {
            "",
            "Unfortunally you don't have any coins.",
            "You died.",
            ""
        };        

        public List<string> NoBalloon = new List<string>() {
            " ",
            "The only thing you can do is take drugs and die a slow death.",
            "You died.",
            " "
        };        

        public List<string> Forward = new List<string>() {
            " ",
            "You walk forward and hear the screams once again.",
            "You now have the choice to follow the screams",
            "or walk towards the scary silence. ",
            " "
        };        

        public List<string> Silence = new List<string>() {
            " ",
            "The silence is creeping up on you but you keep on walking. ",
            "Suddenly the ground disappear under you feet.",
            "You fall and fall until you find yourself at a party.",
            "There is no way out. ",
            "The only thing you can do is take drugs and die a slow death.",
            " ",
            "You died.",
            " "
        };        

        public List<string> HasPurse = new List<string>() {
            "",
            "You find some coins in the old cashier and realise why you have the purse.",
            "You put the coins in the purse and continues. ",
            ""
        };        

        public List<string> HasNoPurse = new List<string>() {
            "",
            "You find some coins in the old cashier but don't know where to put them.",
            "You have to leave the cashier.",
            ""
        };        

        public List<string> Scream = new List<string>() {
            "",
            "There's a door on your left. You open it.",
            ""
        };        

        public Quests()
        {
        }
    }
}
