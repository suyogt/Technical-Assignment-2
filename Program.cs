using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Proj_2a1
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Ask the user for input
                Console.Write("Enter and Integer value between 1 and 25 to execute an iterative statement: ");

                //Catch block to validate user input

                try
                {
                    string input = Console.ReadLine(); // gather data from user input 

                    int value_of_input = int.Parse(input); //various iterative statements and is parsed as an integer 

                    if ((value_of_input > 0) && (value_of_input <= 25)) //for loop statement 

                    {
                        Console.WriteLine("Executing a For Loop!");
                        Console.WriteLine("The For Loop will iterate " + value_of_input.ToString() + " times. ");

                        //intiation of For loop

                        for (int i = 1; i <= value_of_input; i++)
                        {
                            Console.WriteLine("You have entered " + value_of_input.ToString() + ".This is the current integer value in the loop:" + i.ToString());
                        }

                        Console.WriteLine("Press any key to exit the program ..."); //pause and end program 
                        Console.ReadKey(true);
                    }
                }
                catch
                {
                    Console.WriteLine("Press any key to exit the program ..."); // pause and wait for user to press key to end program
                    Console.ReadKey(true);
                }
            }
        }
    }
}
