using Petstore1;
using System;

class Program
{
    static void Main(string[] args)
    { 
        string userInput = string.Empty; 

        Console.WriteLine("Press 1 to add a product");

        Console.WriteLine("type 'exit' to quit"); 

        userInput = Console.ReadLine();

        while (userInput.ToLower() != "exit")  
            {        

            Console.WriteLine("Enter Product Name");

            userInput = Console.ReadLine(); 

            if (userInput == "dog leash") // using IF statements to expect 2 different answers
            {
                var dogleash = new DogLeash();

                dogleash.Name = Console.ReadLine();

                Console.WriteLine("Enter length"); 

                dogleash.LengthInches = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter what material product is made of");

                dogleash.Material = Console.ReadLine();
            }

            if (userInput == "cat food")
            {
                var catfood = new CatFood();

                catfood.Name = Console.ReadLine();

                Console.WriteLine("Enter weight in pounds"); 

                catfood.WeightPounds = double.Parse(Console.ReadLine());

                Console.WriteLine("Is this kitten food? true or false");

                catfood.IsKittenFood = bool.Parse(Console.ReadLine());

            }

        }

    }
}



    
