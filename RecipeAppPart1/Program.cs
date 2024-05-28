﻿using System;
using System.Collections.Generic;
using RecipeAppPart1;

class Program
{
    delegate void DisplayRecipeDelegate(Recipe recipe);

    // Method to display a recipe
    static void DisplayRecipe(Recipe recipe)
    {
        recipe.DisplayRecipe();
    }

    // Method to list all recipes
    static void ListAllRecipes(List<Recipe> recipes)
    {
        foreach (var recipe in recipes)
        {
            Console.WriteLine(recipe.Name);
        }
    }

    static void Main(string[] args)
    {
        List<Recipe> recipes = new List<Recipe>();
        bool exit = false;

        while (!exit)
        {
            Console.Clear();
            Console.WriteLine("\n1. Enter Recipe Details");
            Console.WriteLine("2. Display Recipe");
            Console.WriteLine("3. Scale Recipe");
            Console.WriteLine("4. Reset Quantities");
            Console.WriteLine("5. Clear Data");
            Console.WriteLine("6. List All Recipes");
            Console.WriteLine("7. Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            // Validate user input
            if (!int.TryParse(input, out int choice))
            {
                Console.WriteLine("Invalid choice, please enter a number.");
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
                continue;
            }

            switch (choice)
            {
                case 1:
                    Recipe recipe = new Recipe();
                    recipe.EnterDetails();
                    recipes.Add(recipe);
                    break;
                case 2:
                    Console.Write("Enter recipe name to display: ");
                    string name = Console.ReadLine();
                    DisplayRecipeDelegate displayRecipe = DisplayRecipe;
                    Recipe selectedRecipe = recipes.Find(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
                    if (selectedRecipe != null)
                    {
                        displayRecipe(selectedRecipe);
                    }
                    else
                    {
                        Console.WriteLine("Recipe not found.");
                    }
                    break;
                case 3:
                    // Scale Recipe logic here
                    break;
                case 4:
                    // Reset Quantities logic here
                    break;
                case 5:
                    // Clear Data logic here
                    break;
                case 6:
                    ListAllRecipes(recipes);
                    break;
                case 7:
                    Console.Write("Are you sure you want to exit? (Y/N): ");
                    string exitChoice = Console.ReadLine().ToUpper();
                    if (exitChoice == "Y")
                    {
                        exit = true;
                        Console.WriteLine("Exiting...");
                    }
                    break;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }

            // Pause the console before clearing the screen
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}


////////////////////////////////////////////////////////////////////////////// 00 End Of File 00 ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////



