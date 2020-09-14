using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nmr1 = 20;
            int nmr2 = 34;

            while (true) { 
            Console.WriteLine("Hello! Which number is greater than the other?");
            Console.WriteLine(nmr1 + " or " + nmr2);
            

                if (answer != null)
                {
                    break;
                }
            }
            bool correct = false;
            if (answer == nmr2)
            {
                Console.WriteLine("Correct!");
                correct = true;
            }
            else if(answer == nmr1){
                Console.WriteLine("Wrong!");
            }
            else
            {
                Console.WriteLine("Write " + nmr1 + " or " + nmr2);
            }

            switch (correct){

                case true:

                    break;
                    ;

                case false:
                    Console.WriteLine("Try again!");
                    break;
                    ;
            }
        }
    }
}