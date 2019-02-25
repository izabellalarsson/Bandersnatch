using System;
using System.Collections.Generic;
using System.Linq;

namespace bandersnatch
{
    public class leftOrRight
    {
        private List<IReceipt> holdReceipt = new List<IReceipt>();

        public leftOrRight()
        {
           
        }

        public void rightOrLeft()
        {
            var noWay = false;
            var pickup = new Purse();


            while (!noWay)
            {
                Console.WriteLine("You can either go right or left. Which way do you go? [left]/[right]");
                Console.Write(">");
                var chosenWay = Console.ReadLine().ToLower();
                
                if (chosenWay == "left")
                {
                    Console.WriteLine("You chose the left path and keep on walking. Suddenly you stumble on something.");
                    noWay = true;
                    pickup.PickUpPurse();
                    
                }
                else if (chosenWay == "right")
                {
                    noWay = true;
                    var right = new Right();
                    right.RightWay();

                    foreach (var item in holdReceipt)
                    {
                        item.HasReceipt(); 
                    }


                }
            }
        }
    }
}
