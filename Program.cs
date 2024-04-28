using Petstore1;
using System;

class Program
{
    static void Main(string[] args)
    { 
        string userInput = string.Empty; //Pet Shop 1: STARTING THE USER INTERFACE step 1

        Console.WriteLine("Press 1 to add a product");

        Console.WriteLine("type 'exit' to quit"); //Pet Shop 1: step 2

        userInput = Console.ReadLine(); // step 3

        // LOOPING INSTRUCTIONS for the while code
        while (userInput.ToLower() != "exit") // Handling uppercase instructions for the .ToLower code, congrats! that was the last step for #1 pet shop assignment!
            { 

            var dogleash = new DogLeash();// step 4

            Console.WriteLine("Enter Product Name");// step 5

            dogleash.Name = Console.ReadLine();

            Console.WriteLine("Enter length"); // ENTERING MORE PROPERTIES Step 1

            dogleash.LengthInches = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter what material product is made of");

            dogleash.Material = Console.ReadLine();

            Console.WriteLine("Press 1 to add a product");

            Console.WriteLine("type 'exit' to quit"); //Pet Shop 1: step 2

            userInput = Console.ReadLine(); // step 3

            // need to do the same for CatFood

        }

    }
}



    
