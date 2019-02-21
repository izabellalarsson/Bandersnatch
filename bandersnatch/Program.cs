using System;

namespace bandersnatch
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("The people of Winerfall has requested your help to enter the big and scary cave. You accept the quest.\nOutside you meet a man, ha warns you to enter and ask you who you are. ");

            var start = new StoryStart();
            start.whoAreYou();

            Console.WriteLine();
            Console.WriteLine("You decide to enter the cave without knowing if you'll ever come out of it...");

        }
    }
}
