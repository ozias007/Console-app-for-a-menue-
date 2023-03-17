using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project2
{
    enum Menu                                           // enum for main menu
    {
        Breakfast = 1,
        Burgers,
        ComboMeals,
        Sides,
        HappyMeals,
        Desserts,
        Drinks,
        Checkout,
        ClearBasket
    }

    public enum Breakfast                               // enum for breakfast menu
    {
        EggMcmuffinMeal = 1,
        SausageMcmuffinMeal,
        MegaMcmuffinMeal,
        SouthAfricanBreakfastMeal,
        BoerieAndEggWithShortFilterWithFries,
        BoerieAndHashbrownWithStackShortFilterCoffee,
        SausageMcmuffinWithEggMeal,
        Breakfast_Back
    }

    enum Burgers                                        // enum for burgers menu
    {
        BigTasty = 1,
        BigTastyMealSmall,
        BigTastyMealMedium,
        BigTastyMealLarge,
        BigMac,
        QuarterPounderWithCheese,
        McFeast,
        McRoyale,
        Hamburger,
        Cheeseburger,
        GrandChicken,
        ChickenBurger,
        McChicken,
        Filet_O_Fish,
        VeggieBurger,
        JalapenoBurger,
        BoerieBurger,
        BBQBurger,
        Burgers_Back
    }

    enum ComboMeals                                     // enum for Combo Meals menu
    {
        BigMacShareBag = 1,
        ComboMeals_Back
    }

    enum Sides                                          // enum for Sides menu
    {
        ChickenFoldover = 1,
        McNuggets4pc,
        McNuggets6pc,
        McNuggets10pc,
        McBites10pc,
        GardenSalad,
        CrispyChickenSalad,
        SmallFries,
        MediumFries,
        LargeFries,
        ExtraLargeFries,
        MiniCorn,
        MediumCorn,
        Sides_Back
    }

    enum HappyMeals                                    // enum for Happy Meals menu
    {
        CheeseburgerHappyMealWithCorn = 1,
        CheeseburgerHappyMealWithFries,
        ChickenBurgerHappyMealWithCorn,
        ChickenBurgerHappyMealWithFries,
        HamburgerHappyMealWithCorn,
        HamburgerHappyMealWithFries,
        McNuggetsHappyMealWithCorn,
        McNuggetsHappyMealWithFries,
        HappyMeals_Back
    }

    enum Desserts                                      // enum for Desserts menu
    {
        OreoMcFlurry = 1,
        ChocCaramelMcFlurry,
        CaramelSundae,
        ChocolateSundae,
        StrawberrySundae,
        PlainSundae,
        ApplePie,
        Desserts_Back
    }

    enum DrinksSub                                      // enum for the Main Drinks menu before it splits into HotDrinks and ColdDrinks menu
    {
        HotDrinks = 1,
        ColdDrinks,
        DrinksSub_Back
    }

    enum HotDrinks                                          // enum for Hot Drinks menu
    {
        Cappuccino = 1,
        Latte,
        FilterWhiteCoffee,
        Americano,
        HotChocolate,
        HotDrink_Back
    }

    enum ColdDrinks                                             // enum for Cold Drinks menu   
    {
        McFizzDrink = 1,
        PeachFuzeTea,
        OrangeJuice,
        AppleJuice,
        Powerade,
        Thickshake,
        SoftDrink,
        ColdDrinks_Back
    }

    internal class Program
    {
        static void Main(string[] args)                                 // Main Method
        {
            var arrList = new List<string>();                           // arraylist to hold the Item name, Price and quantity
            bool CheckOut = false;                                      //Value used in while loop to loop the menu
            while (CheckOut == false)                                   //While Loop
            {
                int input;                                              //Input is the variable that is used to get input throughout the program
                DisplayMenu();                                          //Method that displays the main menu
                input = Convert.ToInt32(Console.ReadLine());
                switch ((Menu)input)                                    //Main Switch Case Statement
                {
                    case Menu.Breakfast:                                //Menu Breakfast
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("You have selected Breakfast");
                        DisplayBreakfast();                                                 // Method that displays Menu Breakfast
                    RetryBreakfast:
                        input = Convert.ToInt32(Console.ReadLine());
                        switch ((Breakfast)input)
                        {
                            case Breakfast.EggMcmuffinMeal:                                     //First item on menu Breakfast
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());                    // How many items are bought of that item
                                arrList.Add("Egg McMuffin Meal");                               // Adds item name to arrList
                                arrList.Add(Convert.ToString(48.80));                           // Adds item price to arrList
                                arrList.Add(Convert.ToString(input));                           // Adds item quantity to arrList
                                break;

                            case Breakfast.SausageMcmuffinMeal:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Sausage Mcmuffin Meal");
                                arrList.Add(Convert.ToString(48.80));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Breakfast.MegaMcmuffinMeal:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Mega Mcmuffin Meal");
                                arrList.Add(Convert.ToString(63.20));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Breakfast.SouthAfricanBreakfastMeal:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("South African Breakfast Meal");
                                arrList.Add(Convert.ToString(69.60));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Breakfast.BoerieAndEggWithShortFilterWithFries:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Boerie & Egg with Short Filter and Fries");
                                arrList.Add(Convert.ToString(44.40));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Breakfast.BoerieAndHashbrownWithStackShortFilterCoffee:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Boerie & Hashbrown Stack with Short Filter Coffee");
                                arrList.Add(Convert.ToString(41.70));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Breakfast.SausageMcmuffinWithEggMeal:                                          //Last item on menu Breakfast
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Sausage Mcmuffin with Egg Meal");
                                arrList.Add(Convert.ToString(51.80));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Breakfast.Breakfast_Back:                                      // This does nothing because it is the Back option
                                break;

                            default:
                                Console.WriteLine("Wrong input\nPlease try again");             // This is so that the correct input is achieved...If wrong input is given the  
                                goto RetryBreakfast;                                            //program will ask you to re-enter your option
                        }
                        Console.Clear();
                        break;

                    case Menu.Burgers:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("You have selected Burgers");
                        DisplayBurgers();                                                               // Method that displays Menu Burgers
                    RetryBurgers:
                        input = Convert.ToInt32(Console.ReadLine());
                        switch ((Burgers)input)
                        {
                            case Burgers.BigTasty:                                                      //First item on menu Burgers
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());                            // How many items are bought of that item
                                arrList.Add("Big Tasty");                                               // Adds item name to arrList
                                arrList.Add(Convert.ToString(59.50));                                   // Adds item price to arrList
                                arrList.Add(Convert.ToString(input));                                   // Adds item quantity to arrList
                                break;

                            case Burgers.BigTastyMealSmall:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Big Tasty Meal Small");
                                arrList.Add(Convert.ToString(74.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.BigTastyMealMedium:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Big Tasty Meal Medium");
                                arrList.Add(Convert.ToString(84.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.BigTastyMealLarge:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Big Tasty Meal Large");
                                arrList.Add(Convert.ToString(89.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.BigMac:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Big Mac");
                                arrList.Add(Convert.ToString(31.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.QuarterPounderWithCheese:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Quarter Pounder with Cheese (burger only)");
                                arrList.Add(Convert.ToString(42.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.McFeast:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("McFeast");
                                arrList.Add(Convert.ToString(59.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.McRoyale:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("McRoyale");
                                arrList.Add(Convert.ToString(42.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.Hamburger:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Hamburger");
                                arrList.Add(Convert.ToString(16.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.Cheeseburger:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Cheeseburger");
                                arrList.Add(Convert.ToString(19.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.GrandChicken:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Grand Chicken");
                                arrList.Add(Convert.ToString(46.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.ChickenBurger:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Chicken Burger");
                                arrList.Add(Convert.ToString(18.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.McChicken:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("McChicken");
                                arrList.Add(Convert.ToString(28.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.Filet_O_Fish:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Filet-O-Fish");
                                arrList.Add(Convert.ToString(29.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.VeggieBurger:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Veggie Burger");
                                arrList.Add(Convert.ToString(23.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.JalapenoBurger:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Jalapeno Burger");
                                arrList.Add(Convert.ToString(18.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.BoerieBurger:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Boerie Burger");
                                arrList.Add(Convert.ToString(19.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.BBQBurger:                                                     //Last item on menu Burgers
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("BBQ Burger");
                                arrList.Add(Convert.ToString(39.90));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Burgers.Burgers_Back:                                                  // This does nothing because it is the Back option
                                break;

                            default:                                                            // This is so that the correct input is achieved...If wrong input is given the
                                Console.WriteLine("Wrong input\nPlease try again");             //program will ask you to re-enter your option
                                goto RetryBurgers;
                        }
                        Console.Clear();
                        break;

                    case Menu.ComboMeals:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("You have selected Combo Meals");
                        DisplayComboMeals();                                                // Method that displays Menu Combo Meals
                    RetryComboMeals:
                        input = Convert.ToInt32(Console.ReadLine());
                        switch ((ComboMeals)input)
                        {
                            case ComboMeals.BigMacShareBag:                                                 //First and only item on menu Combo meals
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());                        // How many items are bought of that item
                                arrList.Add("Big Mac Sharebag");                                        // Adds item name to arrList
                                arrList.Add(Convert.ToString(177.00));                                  // Adds item price to arrList
                                arrList.Add(Convert.ToString(input));                                   // Adds item quantity to arrList
                                break;

                            case ComboMeals.ComboMeals_Back:                                        // This does nothing because it is the Back option
                                break;

                            default:
                                Console.WriteLine("Wrong input\nPlease try again");                                 // This is so that the correct input is achieved...If wrong input is given the
                                goto RetryComboMeals;                                                               // program will ask you to re-enter your option
                        }
                        Console.Clear();
                        break;

                    case Menu.Sides:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("You have selected Sides");
                        DisplaySides();                                                             // Method that displays Menu Sides
                    RetrySides:
                        input = Convert.ToInt32(Console.ReadLine());
                        switch ((Sides)input)
                        {
                            case Sides.ChickenFoldover:                                             //First item on menu Sides
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());                            // How many items are bought of that item
                                arrList.Add("Chicken Foldover");                                        // Adds item name to arrList
                                arrList.Add(Convert.ToString(44.00));                                   // Adds item price to arrList
                                arrList.Add(Convert.ToString(input));                                   // Adds item quantity to arrList
                                break;

                            case Sides.McNuggets4pc:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("4pc McNuggets");
                                arrList.Add(Convert.ToString(23.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.McNuggets6pc:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("6pc McNuggets");
                                arrList.Add(Convert.ToString(30.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.McNuggets10pc:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("10pc McNuggets");
                                arrList.Add(Convert.ToString(44.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.McBites10pc:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("10pc McBites");
                                arrList.Add(Convert.ToString(20.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.GardenSalad:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Garden Salad");
                                arrList.Add(Convert.ToString(31.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.CrispyChickenSalad:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Crispy Chicken Salad");
                                arrList.Add(Convert.ToString(52.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.SmallFries:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Small Fries");
                                arrList.Add(Convert.ToString(11.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.MediumFries:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Medium Fries");
                                arrList.Add(Convert.ToString(17.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.LargeFries:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Large Fries");
                                arrList.Add(Convert.ToString(20.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.ExtraLargeFries:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Extra Large Fries");
                                arrList.Add(Convert.ToString(25.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.MiniCorn:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Mini Corn");
                                arrList.Add(Convert.ToString(10.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.MediumCorn:                                                      //Last item on menu Breakfast
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Medium Corn");
                                arrList.Add(Convert.ToString(15.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Sides.Sides_Back:                                                  // This does nothing because it is the Back option
                                break;

                            default:
                                Console.WriteLine("Wrong input\nPlease try again");                       // This is so that the correct input is achieved...If wrong input is given the
                                goto RetrySides;                                                          // program will ask you to re-enter your option  
                        }
                        Console.Clear();
                        break;

                    case Menu.HappyMeals:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("You have selected Happy Meals");
                        DisplayHappyMeals();                                                        // Method that displays Menu Happy Meals
                    RetryHappyMeals:
                        input = Convert.ToInt32(Console.ReadLine());
                        switch ((HappyMeals)input)
                        {
                            case HappyMeals.CheeseburgerHappyMealWithCorn:                                                      //First item on menu Happy Meals
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());                                // How many items are bought of that item
                                arrList.Add("Cheeseburger Happy Meal with Corn");                           // Adds item name to arrList
                                arrList.Add(Convert.ToString(37.50));                                       // Adds item price to arrList
                                arrList.Add(Convert.ToString(input));                                       // Adds item quantity to arrList
                                break;

                            case HappyMeals.CheeseburgerHappyMealWithFries:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Cheeseburger Happy Meal with Fries");
                                arrList.Add(Convert.ToString(37.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case HappyMeals.ChickenBurgerHappyMealWithCorn:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Chicken Burger Happy Meal with Corn");
                                arrList.Add(Convert.ToString(36.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case HappyMeals.ChickenBurgerHappyMealWithFries:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Chicken Burger Happy Meal with Fries");
                                arrList.Add(Convert.ToString(36.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case HappyMeals.HamburgerHappyMealWithCorn:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Hamburger Happy Meal with Corn");
                                arrList.Add(Convert.ToString(35.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case HappyMeals.HamburgerHappyMealWithFries:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Hamburger Happy Meal with Fries");
                                arrList.Add(Convert.ToString(34.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case HappyMeals.McNuggetsHappyMealWithCorn:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("McNuggets Happy Meal with Corn");
                                arrList.Add(Convert.ToString(38.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case HappyMeals.McNuggetsHappyMealWithFries:                                        //Last item on menu Happy Meals
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("McNuggets Happy Meal with Fries");
                                arrList.Add(Convert.ToString(38.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case HappyMeals.HappyMeals_Back:                                        // This does nothing because it is the Back option
                                break;

                            default:
                                Console.WriteLine("Wrong input\nPlease try again");             // This is so that the correct input is achieved...If wrong input is given the
                                goto RetryHappyMeals;                                           // program will ask you to re-enter your option
                        }
                        Console.Clear();
                        break;

                    case Menu.Desserts:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("You have selected Desserts");
                        DisplayDesserts();                                                              // Method that displays Menu Desserts
                    RetryDesserts:
                        input = Convert.ToInt32(Console.ReadLine());
                        switch ((Desserts)input)
                        {
                            case Desserts.OreoMcFlurry:                                             //First item on menu Dessets
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());                        // How many items are bought of that item
                                arrList.Add("Oreo McFlurry");                                       // Adds item name to arrList
                                arrList.Add(Convert.ToString(28.00));                               // Adds item price to arrList
                                arrList.Add(Convert.ToString(input));                               // Adds item quantity to arrList
                                break;

                            case Desserts.ChocCaramelMcFlurry:
                                Console.WriteLine("How many would you like to order");
                                input=Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Choc Caramel McFlurry");
                                arrList.Add(Convert.ToString(28.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Desserts.CaramelSundae:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Caramel Sundae");
                                arrList.Add(Convert.ToString(18.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Desserts.ChocolateSundae:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Chocolate Sundae");
                                arrList.Add(Convert.ToString(18.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Desserts.StrawberrySundae:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Strawberry Sundae");
                                arrList.Add(Convert.ToString(18.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Desserts.PlainSundae:
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Plain Sundae");
                                arrList.Add(Convert.ToString(17.00));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Desserts.ApplePie:                                                 //Last item on menu Dessets
                                Console.WriteLine("How many would you like to order");
                                input = Convert.ToInt32(Console.ReadLine());
                                arrList.Add("Apple Pie");
                                arrList.Add(Convert.ToString(17.50));
                                arrList.Add(Convert.ToString(input));
                                break;

                            case Desserts.Desserts_Back:                                    // This does nothing because it is the Back option
                                break;

                            default:
                                Console.WriteLine("Wrong input\nPlease try again");         // This is so that the correct input is achieved...If wrong input is given the
                                goto RetryDesserts;                                         // program will ask you to re-enter your option
                        }
                        Console.Clear();
                        break;

                    case Menu.Drinks:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("You have selected Drinks");
                        DisplayDrinksMenu();                                                        // Method that displays Main Menu Drinks
                    RetryDrinksSub:
                        input = Convert.ToInt32(Console.ReadLine());
                        switch ((DrinksSub)input)
                        {
                            case DrinksSub.HotDrinks:                                                               //First item on menu DrinksSub
                                Console.Clear();
                                DisplayHotDrink();                                                      // Method that displays Menu Hot Drinks
                            RetryHotDrinks:
                                input = Convert.ToInt32(Console.ReadLine());
                                switch ((HotDrinks)input)
                                {
                                    case HotDrinks.Cappuccino:                                                              //First item on menu Hot Drinks                         
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());                                            // How many items are bought of that item
                                        arrList.Add("Cappuccino");                                                              // Adds item name to arrList
                                        arrList.Add(Convert.ToString(19.00));                                                   // Adds item price to arrList
                                        arrList.Add(Convert.ToString(input));                                                   // Adds item quantity to arrList
                                        break;

                                    case HotDrinks.Latte:
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Latte");
                                        arrList.Add(Convert.ToString(20.00));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case HotDrinks.FilterWhiteCoffee:
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Filter White Coffee");
                                        arrList.Add(Convert.ToString(16.00));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case HotDrinks.Americano:
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Americano");
                                        arrList.Add(Convert.ToString(15.00));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case HotDrinks.HotChocolate:                                            //Last item on menu Hot Drinks
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Hot Chocolate");
                                        arrList.Add(Convert.ToString(22.50));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case HotDrinks.HotDrink_Back:                                       // This does nothing because it is the Back option
                                        Console.Clear();
                                        DisplayDrinksMenu();
                                        goto RetryDrinksSub;

                                    default:
                                        Console.WriteLine("Wrong input\nPlease try again");                 // This is so that the correct input is achieved...If wrong input is given the
                                        goto RetryHotDrinks;                                                //program will ask you to re-enter your option
                                }
                                break;

                            case DrinksSub.ColdDrinks:
                                Console.Clear();
                                DisplayColdDrinks();                                                    // Method that displays Menu Cold Drinks
                            RetryColdDrinks:
                                input = Convert.ToInt32(Console.ReadLine());
                                switch ((ColdDrinks)input)
                                {
                                    case ColdDrinks.McFizzDrink:                                                //First item on menu Cold Drinks
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());                            // How many items are bought of that item
                                        arrList.Add("McFizz Drink");                                            // Adds item name to arrList
                                        arrList.Add(Convert.ToString(20.50));                                   // Adds item price to arrList
                                        arrList.Add(Convert.ToString(input));                                   // Adds item quantity to arrList
                                        break;

                                    case ColdDrinks.PeachFuzeTea:
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Peach Fuze Tea");
                                        arrList.Add(Convert.ToString(20.50));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case ColdDrinks.OrangeJuice:
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Orange Juice");
                                        arrList.Add(Convert.ToString(16.00));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case ColdDrinks.AppleJuice:
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Apple Juice");
                                        arrList.Add(Convert.ToString(17.00));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case ColdDrinks.Powerade:
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Powerade");
                                        arrList.Add(Convert.ToString(22.50));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case ColdDrinks.Thickshake:
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Thickshake");
                                        arrList.Add(Convert.ToString(21.50));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case ColdDrinks.SoftDrink:                                                      //Last item on menu Cold Drinks
                                        Console.WriteLine("How many would you like to order");
                                        input = Convert.ToInt32(Console.ReadLine());
                                        arrList.Add("Soft Drink");
                                        arrList.Add(Convert.ToString(11.90));
                                        arrList.Add(Convert.ToString(input));
                                        break;

                                    case ColdDrinks.ColdDrinks_Back:                                        // This does nothing because it is the Back option
                                        Console.Clear();
                                        DisplayDrinksMenu();
                                        goto RetryDrinksSub;

                                    default:
                                        Console.WriteLine("Wrong input\nPlease try again");             // This is so that the correct input is achieved...If wrong input is given the
                                        goto RetryColdDrinks;                                           //program will ask you to re-enter your option
                                }
                                break;

                            case DrinksSub.DrinksSub_Back:                                  // This does nothing because it is the Back option
                                break;


                            default:
                                Console.WriteLine("Wrong input\nPlease try again");            // This is so that the correct input is achieved...If wrong input is given the                             
                                goto RetryDrinksSub;                                                // program will ask you to re-enter your option
                        }   
                        Console.Clear();
                        break;

                    case Menu.Checkout:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("You have selected Checkout");
                        DisplayCheckOut(arrList);                                                               // Method that displays Checkout...This method displays what the user has bought
                        Console.WriteLine("Thank you for your purchase");
                        Console.WriteLine("Do you want to exit" + "\n1 for YES" + "\n2 for NO");               //Askes if the user wants to exit
                    RetryCheckout:
                        input = Convert.ToInt32(Console.ReadLine());
                        if (input == 1 || input == 2)                                                   // Checks if user only enters 1 or 2
                        {
                            if (input == 1)                                                             // Exits the program if users enters 1...2 does nothing
                            {
                                Console.WriteLine("Thank you for Eating at McDonalds");
                                Thread.Sleep(2000);
                                CheckOut = true;
                                Environment.Exit(0);
                            }
                        }
                        else                                                                       // If wrong input then the program will loop and ask user to re-enter value
                        {
                            Console.WriteLine("Wrong input try again");
                            goto RetryCheckout;
                        }
                        Console.Clear();
                        break;

                    case Menu.ClearBasket:
                        Console.Clear();
                        Console.WriteLine("------------------------------------------------");
                        Console.WriteLine("You have selected to Clear your basket");
                        Console.WriteLine("Are you sure you want to clear your basket: " + "\n 1 for YES" + "\n 2 for NO" + "\n 3 for Back");                       //Asks for input
                    RetryClearBasket:
                        input = Convert.ToInt32(Console.ReadLine());
                        if (input == 1 || input == 2 || input == 3)                                         //Checks if input is only 1 2 or 3
                        {
                            if (input == 1)                                     //If 1 is entered then arrList is cleared and return back to main menu
                            {                                                                   //2 and 3 do nothing...only return back to main
                                arrList.Clear();
                                Console.WriteLine("Your basket has been cleared" + "\nPlease Wait");
                                Console.WriteLine("------------------------------------------------");
                                Thread.Sleep(1000);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Wrong input try again");                                 //If input is not 1 2 or 3 then the program will loop and ask for user to re-enter value
                            goto RetryClearBasket;
                        }
                        Console.Clear();
                        break;

                    default:                                                                                //If the wrong value is entered the program will loop and ask user to re-enter value
                        Console.WriteLine("You have chosen an invalid option \nRetry");
                        break;
                }
            }
        }

        public static void DisplayMenu()                                                    // Method for Displaying Main Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Welcome to Mc'Donalds Menu");
            Console.WriteLine("Press 1 for Breakfast");
            Console.WriteLine("Press 2 for Burgers");
            Console.WriteLine("Press 3 for Combo Meals");
            Console.WriteLine("Press 4 for Sides");
            Console.WriteLine("Press 5 for Happy Meals");
            Console.WriteLine("Press 6 for Desserts");
            Console.WriteLine("Press 7 for Drinks");
            Console.WriteLine("Press 8 for Checkout");
            Console.WriteLine("Press 9 for Clear Basket");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }

        public static void DisplayBreakfast()                                                   // Method for Displaying Breakfast Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 1 for Egg Mcmuffin Meal 48.80");
            Console.WriteLine("Press 2 for Sausage Mcmuffin Meal 48.80");
            Console.WriteLine("Press 3 for Mega Mcmuffin Meal 63.20");
            Console.WriteLine("Press 4 for South African Breakfast Meal 69.60");
            Console.WriteLine("Press 5 for Boerie & Egg with Short Filter and Fries 44.40");
            Console.WriteLine("Press 6 for Boerie & Hashbrown Stack with Short Filter Coffee 41.70");
            Console.WriteLine("Press 7 for Sausage Mcmuffin with Egg Meal 51.80");
            Console.WriteLine("Press 8 for Back");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }

        public static void DisplayBurgers()                                                     // Method for Displaying Burgers Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 1 for Big Tasty 59.50");
            Console.WriteLine("Press 2 for Big Tasty Meal Small 74.50");
            Console.WriteLine("Press 3 for Big Tasty Meal Medium 84.50");
            Console.WriteLine("Press 4 for Big Tasty Meal Large 89.50");
            Console.WriteLine("Press 5 for Big Mac 31.00");
            Console.WriteLine("Press 6 for Quarter Pounder with Cheese (burger only) 42.00");
            Console.WriteLine("Press 7 for McFeast 59.50");
            Console.WriteLine("Press 8 for McRoyale 42.00");
            Console.WriteLine("Press 9 for Hamburger 16.50");
            Console.WriteLine("Press 10 for Cheeseburger 19.00");
            Console.WriteLine("Press 11 for Grand Chicken 46.00");
            Console.WriteLine("Press 12 for Chicken Burger 18.50");
            Console.WriteLine("Press 13 for McChicken 28.00");
            Console.WriteLine("Press 14 for Filet-O-Fish 29.00");
            Console.WriteLine("Press 15 for Veggie Burger 23.50");
            Console.WriteLine("Press 16 for Jalapeno Burger 18.50");
            Console.WriteLine("Press 17 for Boerie Burger 19.50");
            Console.WriteLine("Press 18 for BBQ Burger 39.00");
            Console.WriteLine("Press 19 for Back");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }

        public static void DisplayComboMeals()                                                  // Method for Displaying Combo Meals Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 1 for Big Mac Sharebag 177.00");
            Console.WriteLine("Press 2 for Back");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }

        public static void DisplaySides()                                                       // Method for Displaying Sides Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 1 for Chicken Foldover 44.00");
            Console.WriteLine("Press 2 for 4pc McNuggets 23.50");
            Console.WriteLine("Press 3 for 6pc McNuggets 30.50");
            Console.WriteLine("Press 4 for 10pc McNuggets 44.00");
            Console.WriteLine("Press 5 for 10pc McBites 20.00");
            Console.WriteLine("Press 6 for Garden Salad 31.50");
            Console.WriteLine("Press 7 for Crispy Chicken Salad 52.50");
            Console.WriteLine("Press 8 for Small Fries 11.50");
            Console.WriteLine("Press 9 for Medium Fries 17.50");
            Console.WriteLine("Press 10 for Large Fries 20.50");
            Console.WriteLine("Press 11 for Extra Large Fries 25.50");
            Console.WriteLine("Press 12 for Mini Corn 10.00");
            Console.WriteLine("Press 13 for Medium Corn 15.00");
            Console.WriteLine("Press 14 for Back");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }

        public static void DisplayHappyMeals()                                                      // Method for Displaying Happy Meals Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 1 for Cheeseburger Happy Meal with Corn 37.50");
            Console.WriteLine("Press 2 for Cheeseburger Happy Meal with Fries 37.00");
            Console.WriteLine("Press 3 for Chicken Burger Happy Meal with Corn 36.50");
            Console.WriteLine("Press 4 for Chicken Burger Happy Meal with Fries 36.00");
            Console.WriteLine("Press 5 for Hamburger Happy Meal with Corn 35.00");
            Console.WriteLine("Press 6 for Hamburger Happy Meal with Fries 34.00");
            Console.WriteLine("Press 7 for McNuggets Happy Meal with Corn 38.50");
            Console.WriteLine("Press 8 for McNuggets Happy Meal with Fries 38.00");
            Console.WriteLine("Press 9 for Back");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }

        public static void DisplayDesserts()                                                        // Method for Displaying Desserts Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 1 for Oreo McFlurry 28.00");
            Console.WriteLine("Press 2 for Choc Caramel McFlurry 28.00");
            Console.WriteLine("Press 3 for Caramel Sundae 18.50");
            Console.WriteLine("Press 4 for Chocolate Sundae 18.50");
            Console.WriteLine("Press 5 for Strawberry Sundae 18.50");
            Console.WriteLine("Press 6 for Plain Sundae 17.00");
            Console.WriteLine("Press 7 for Apple Pie 17.50");
            Console.WriteLine("Press 8 for Back");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }

        public static void DisplayDrinksMenu()                                                  // Method for Displaying Main Drinks Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 1 for Hot Drinks");
            Console.WriteLine("Press 2 for Cold Drinks");
            Console.WriteLine("Press 3 for Back");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }
        
        public static void DisplayColdDrinks()                                                          // Method for Displaying Cold Drinks Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 1 for McFizz Drink 20.50");
            Console.WriteLine("Press 2 for Peach Fuze Tea 20.50");
            Console.WriteLine("Press 3 for Orange Juice 16.00");
            Console.WriteLine("Press 4 for Apple Juice 17.00");
            Console.WriteLine("Press 5 for Powerade 22.50");
            Console.WriteLine("Press 6 for Thickshake 21.50");
            Console.WriteLine("Press 7 for Soft Drink 11.90");
            Console.WriteLine("Press 8 for Back");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }

        public static void DisplayHotDrink()                                                            // Method for Displaying Hot Drinks Menu
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Press 1 for Cappuccino 19.00");
            Console.WriteLine("Press 2 for Latte 20.00");
            Console.WriteLine("Press 3 for Filter White Coffee 16.00");
            Console.WriteLine("Press 4 for Americano 15.00");
            Console.WriteLine("Press 5 for Hot Chocolate 22.50");
            Console.WriteLine("Press 6 for Back");
            Console.WriteLine("Please make your choice:");
            Console.WriteLine("------------------------------------------------");
        }

        public static List<string> DisplayCheckOut(List<string> arrList)                      // Method used to calculate and display the users orders and total amount
        {
            Console.WriteLine("------------------------------------------------");
            Console.WriteLine("Your basket:");
            Console.WriteLine("------------------------------------------------");
            int maxItems = (arrList.Count/3);                                                   // The max amount of items in arrList...Every 3 items for one set
            double price = 0;                                                                   // Final total amount
            for (int i = 0; i < maxItems; i++)                                                  // The loop and algorithm have been make to diplay items in sets of 3...1 Item Name...2 Price...3 Quantity
            {
                int algoritm = 3 * i;                                                           //Algorithm used to calculate the place of every item
                Console.WriteLine( arrList[0 + algoritm] + " R" + Convert.ToDouble(arrList[1 + algoritm]) + " times " + Convert.ToInt32(arrList[2 + algoritm]) );       //Displays item name price and quantity
                price += (Convert.ToDouble(arrList[1 + algoritm]) * Convert.ToInt32(arrList[2 + algoritm]));                                                            //Calculates the total amount
            }
            Console.WriteLine("\nYour total is: R" + Convert.ToString(price));                      //Displays total amount
            arrList.Clear();
            Console.WriteLine("------------------------------------------------");
            return arrList;                                                                     //Returns empty arrList
        }
    }
}
