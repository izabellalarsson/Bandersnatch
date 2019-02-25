using System;
namespace bandersnatch
{
    public class yesOrNo
    {
        public yesOrNo()
        {

        }

        public void yes()
        {
            var runOrBack = new RunOrGoBack();
            Console.WriteLine("Underneath a pile of soil you find a purse. \nYou don't know the use of it but pick it up anyway.");
            Console.WriteLine(YesNo());
            runOrBack.RunOrBack();

        }

        public void no()
        {
            var runOrBack = new RunOrGoBack();
            Console.WriteLine("Keep on going forward.");
            Console.WriteLine(YesNo());
            runOrBack.RunOrBack();
        }

        public string YesNo()
        {
            return "You stop for a second as you see the passage is narrowing down. \nAt the same time the flashlight start to flicker, you can't see the end of the passage and wonder for how long you have to walk in this condition.";
        }

    }
}
