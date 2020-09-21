using System;
using System.Runtime.InteropServices.ComTypes;

namespace BMICalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your age?");
            int age = Int32.Parse(Console.ReadLine());
            

            if (age < 20)
            {
                Console.WriteLine("You are too young to use the calculator");
            } else if (age >= 60)
            {
                Console.WriteLine("You are too old to use the calculator");
            } else
            { 
                double hight;
                double Result;
                Console.WriteLine("Enter your height");
                hight = Double.Parse(Console.ReadLine());
                Console.WriteLine($"your height is {hight} meters.");

                double weight;
                Console.WriteLine("Enter your weight");
                weight = Double.Parse(Console.ReadLine());
                Console.WriteLine($"your weight is {weight} kg.");
                double height2 = hight * hight;
                Result = weight / height2;

                Console.WriteLine($"Your BMI is {Result} kg/m2.");

                if (Result <= 19)
                {
                    Console.WriteLine("You are underweight");
                }
                else if (Result <= 25)
                {
                    Console.WriteLine("You have normalweight");
                }
                else if (Result <= 30)
                {
                    Console.WriteLine("You are overweight");


                }
                else if (Result <= 31)
                    {
                    Console.WriteLine("You are extrimely overweight");
                    }




            }    









        }
    }
}
