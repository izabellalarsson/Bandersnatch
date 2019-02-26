using System;
namespace bandersnatch
{
    public class HiddenDoor
    {

        //public HiddenDoor(bool HasReceipt) : base(HasReceipt) 
        //{
        //}
        public HiddenDoor()
        {

        }

        public void ManQuestion()
        {
            Console.WriteLine("Do you know what he talks about? [yes] / [no]");
            Console.Write("> ");
            var UserInput = Console.ReadLine().ToLower();

            if (UserInput == "yes")
            {
                //if (HaveReceipt)
                //{
                //    Console.WriteLine("hej");
                //}
                //else
                //{
                //    Console.WriteLine("dont know");
                //}
            }
        }

    }
}
