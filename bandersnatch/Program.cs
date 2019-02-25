using System;

namespace bandersnatch
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The people of Winerfall has requested your help to enter the big and scary cave. You accept the quest.\nOutside you meet a man, ha warns you to enter and ask you who you are. ");

            //var start = new StoryStart();
            //start.whoAreYou();

            Console.WriteLine();
            Console.WriteLine("You decide to enter the cave without knowing if you'll ever come out of it...");
            Console.WriteLine();
            // inside the cave
            Console.WriteLine("Inside the cave you hear load screams and instantly regret you entered the cave. \nYou think to yourself \"I should have listened to the weird man, maybe I should go back before it's too late\". \nBut as you turn around to get out you realise it's already too late, the entrance is blocked.\nYou now have no choice but to find another way out...\n");

            Console.WriteLine("With help of the light of the flashlight you start walking. The screams seems to disappear for a while. \nIn front of you you meet a crossroad.");
            // choose left or right 
            var leftOrRight = new leftOrRight();
            leftOrRight.rightOrLeft();

        }
    }
}
