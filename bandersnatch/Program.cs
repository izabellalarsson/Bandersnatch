using System;
using System.Drawing;
using Console = Colorful.Console;

namespace bandersnatch
{
    class Program
    {


        static void Main(string[] args)
        {
            string textToEnter = "A game made by Izabella and Lovisa";
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(textToEnter);
            //Console.WriteLine(String.Format("{0," + ((Console.WindowWidth / 2) + (textToEnter.Length / 2)) + "}", textToEnter));
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("██████╗  █████╗ ███╗   ██╗██████╗ ███████╗██████╗  ", Color.Aqua);
            Console.WriteLine("██╔══██╗██╔══██╗████╗  ██║██╔══██╗██╔════╝██╔══██╗ ", Color.Aqua);
            Console.WriteLine("██████╔╝███████║██╔██╗ ██║██║  ██║█████╗  ██████╔╝ ", Color.Aqua);
            Console.WriteLine("██╔══██╗██╔══██║██║╚██╗██║██║  ██║██╔══╝  ██╔══██╗ ", Color.Aqua);
            Console.WriteLine("██████╔╝██║  ██║██║ ╚████║██████╔╝███████╗██║  ██║ ", Color.Aqua);
            Console.WriteLine("╚═════╝ ╚═╝  ╚═╝╚═╝  ╚═══╝╚═════╝ ╚══════╝╚═╝  ╚═╝ ", Color.Yellow);
            Console.WriteLine("                                                   ");
            Console.WriteLine("███████╗███╗   ██╗ █████╗ ████████╗ ██████╗██╗  ██╗", Color.Blue);
            Console.WriteLine("██╔════╝████╗  ██║██╔══██╗╚══██╔══╝██╔════╝██║  ██║", Color.Blue);
            Console.WriteLine("███████╗██╔██╗ ██║███████║   ██║   ██║     ███████║", Color.Blue);
            Console.WriteLine("╚════██║██║╚██╗██║██╔══██║   ██║   ██║     ██╔══██║", Color.Blue);
            Console.WriteLine("███████║██║ ╚████║██║  ██║   ██║   ╚██████╗██║  ██║", Color.Blue);
            Console.WriteLine("╚══════╝╚═╝  ╚═══╝╚═╝  ╚═╝   ╚═╝    ╚═════╝╚═╝  ╚═╝", Color.Yellow);
            Console.WriteLine("                                                   ");


            Console.WriteLine("Press <Enter> to start the game");
            var start = new Game();
           
            if(Console.ReadKey().Key == ConsoleKey.Enter)
            {
                start.StoryStart();
            }
        }
    }
}
