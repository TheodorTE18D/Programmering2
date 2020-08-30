using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            String name = Console.ReadLine();

            Console.WriteLine("What is your age?");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Are you alive?");
            bool alive = false;
            if(Console.ReadLine() == "yes")
            {
                alive = true;
            }
                
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Age: " + age);

            if (alive)
            {
                Console.WriteLine("Lucky you!");
            }
            else
            {
                Console.WriteLine("RIP");
            }

            Console.ReadLine();

  
        }
    }
}