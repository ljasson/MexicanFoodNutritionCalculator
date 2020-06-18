using System;
using System.Runtime.CompilerServices;

namespace MexicanFoodNutritionCalculator
{
    class Program
    {

        // EnergyTotal, ProteinTotal, FatTotal, SatFatTotal, CarbTotal, SugarTotal, SodiumTotal;
       


        static void Filling()
        {
            Console.WriteLine("What filling would you like?");
            string[] Fillings = { "Barbacoa Beef", "Chicken", "Pork", "Lamb", "Cauliflower", "Vegetarian" };

            for (int i = 0; i < Fillings.Length; i++)
            {
                Console.WriteLine((i + 1) + ".  " + Fillings[i]);
            }
        }

        static void Burrito()
        {
            Console.WriteLine("Which Burrito would you like?");
            string[] BurritoTypes = {"Classic", "Power", "IQ" };
            for (int i = 0; i < BurritoTypes.Length; i++)
            {
                Console.WriteLine((i + 1) + ".  " + BurritoTypes[i]);
            }
        }

        static Double[] AddNutrients(double[,] FoodItem, int x, double[] Nutrients)
        {
            for(int i=0; i < 7; i++)
            {
                Nutrients[i] += FoodItem[x, i];
            }

            return Nutrients;
        }


        static void Main(string[] args)
        {
        Double[] Nutrients = { 0, 0, 0, 0, 0, 0, 0 };


            // Console.WriteLine("Hello World!"); 
           /* Double EnergyTotal, ProteinTotal, FatTotal, SatFatTotal, CarbTotal, SugarTotal, SodiumTotal; */


            Console.WriteLine("Welcome to Zambreros, what can I get you?");
            String[] FoodCategories = { "Burrito", "Bowl", "Nachos", "Hard Taco", "Soft Taco", "Dos CAPAS", "Quesadilla" };
            for (int i = 0; i < FoodCategories.Length; i++)
            {
                Console.WriteLine((i + 1) + ".  " + FoodCategories[i]);
            }

            string ChoiceOfFoodCategory = Console.ReadLine();

            
            if(ChoiceOfFoodCategory == "1")
            {   //if Burrito

                Double[,] ClassicBurrito = {
                    {3154, 36.8, 30.4, 14.8, 82, 13.5, 1521},   // Barbacoa Beef
                    {3025, 30.3, 29, 13.1, 84, 9.9, 1331},  // Chicken
                };

                Burrito();
                string ChoiceOfFoodItem = Console.ReadLine();
                int choice = (Int32.Parse(ChoiceOfFoodItem) - 1);
                if (ChoiceOfFoodItem == "1")
                {
                    Nutrients = AddNutrients(ClassicBurrito, choice, Nutrients);
                }

                /*
                for(int i=0; i < Nutrients.Length; i++)
                {
                    Console.WriteLine(i + ".  " + Nutrients[i]);
                }
                */



                
                
                
                
               

            }
           
        }

   
    }
}
