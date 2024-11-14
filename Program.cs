using System;
using System.Collections.Generic;  // För att använda List<T>
using SebsFabrik;  // Detta är om du vill importera alla dina klasser från samma projekt

namespace SebsFabrik 
{
    class Program
    {
        static void Main (string[] argument)
        {
            List <Candy> candies = new List<Candy>();
            List <Pipe> pipes = new List<Pipe>();
            List <Car> cars = new List<Car>();
            List <Oatmilk> oatmilks = new List<Oatmilk>();

            bool active = true;
            while (active) 
            {
                //Console showing menu alternatives - will work as long as active is true.
                System.Console.WriteLine();
                System.Console.WriteLine("Welcome to Sebs Multifabrik!");
                System.Console.WriteLine("Please choose one option below to order, check your shopping cart or to exit the application:");
                System.Console.WriteLine("1. Candy");
                System.Console.WriteLine("2. Pipes");
                System.Console.WriteLine("3. Cars");
                System.Console.WriteLine("4. Oatmilk");
                System.Console.WriteLine("5. Your shopping cart");
                System.Console.WriteLine("6. Exit");

                //USER CHOISE
                string choice = Console.ReadLine();

                switch (choice)
                    {
                    case "1":
                        //ORDER
                        System.Console.WriteLine();
                        System.Console.WriteLine("You chose to order candy.");
                        System.Console.WriteLine();
                        string candyFlavor = InputValidator.GetValidString("What candy flavor do you wish to order?");
                        System.Console.WriteLine();
                        int candyAmount = InputValidator.GetValidInt("How many pieces of candy do you wish to order?");

                        //ADDING
                        Candy newCandy = new Candy(candyFlavor, candyAmount);
                        candies.Add(newCandy);
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("The product has been successfully added to your shopping cart");
                        Console.ResetColor();
                        break;

                    case "2":
                        //ORDER
                        System.Console.WriteLine();
                        System.Console.WriteLine("You chose to order pipes.");
                        double pipeDiameter = InputValidator.GetValidDouble("What diameter do you wish for the pipe? Decimals OK."); 
                        double pipeLength = InputValidator.GetValidDouble("How long in metres should the pipe be? Decimals OK.");

                        //ADDING
                        Pipe newPipe = new Pipe(pipeDiameter, pipeLength);
                        pipes.Add(newPipe);
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("The product has been successfully added to your shopping cart");
                        Console.ResetColor();
                        break;

                    case "3":
                        //ORDER
                        System.Console.WriteLine();
                        System.Console.WriteLine("You chose to order cars.");
                        string carModel = InputValidator.GetValidString("What model of car do you wish to order?"); 
                        string carColor = InputValidator.GetValidString("What color should the car be in?");
                        string carLicense = InputValidator.GetvalidCarLicense();
                        
                        //ADDING
                        Car newCar = new Car(carModel, carColor, carLicense);
                        cars.Add(newCar);
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("The product has been successfully added to your shopping cart");
                        Console.ResetColor();
                        break;

                    case "4":
                        System.Console.WriteLine();
                        System.Console.WriteLine("You chose to order oatmilk.");
                        System.Console.WriteLine();
                        double oatmilkFat = InputValidator.GetValidDouble("What amount of fat content do you wish the oatmilk to have?"); 
                        double oatmilkLiters = InputValidator.GetValidDouble("How many liters of oatmilk do you wish to order?");
                        
                        //ADDING
                        Oatmilk newOatmilk = new Oatmilk(oatmilkFat, oatmilkLiters);
                        oatmilks.Add(newOatmilk);
                        Console.ForegroundColor = ConsoleColor.Green;
                        System.Console.WriteLine("The product has been successfully added to your shopping cart");
                        Console.ResetColor();
                        break;

                    case "5": //SHOPPING CART
                        System.Console.WriteLine();
                        System.Console.WriteLine("You chose to view your shopping cart.");
                        if (candies.Count == 0 && pipes.Count == 0 && cars.Count == 0 && oatmilks.Count == 0)
                        {   
                            System.Console.WriteLine("Your shopping cart is empoty");
                        } else {
                            if (candies.Count > 0) {
                                System.Console.WriteLine("Candies: ");
                                foreach (var candy in candies)
                                {
                                    System.Console.WriteLine("Candy-flavor: " + candy.Flavor + ", Amount: " + candy.Amount);
                                }
                            }

                            if (pipes.Count > 0) {
                                System.Console.WriteLine("Pipes: ");
                                foreach (var pipe in pipes)
                                {
                                    System.Console.WriteLine("Pipe Diameter: " + pipe.Diameter + ", Length: " + pipe.Length);
                                }
                            }

                            if (cars.Count > 0) {
                                System.Console.WriteLine("Cars: ");
                                foreach (var car in cars)
                                {
                                    System.Console.WriteLine("Car-Model: " + car.Model + ", Color: " + car.Color + ", License plate: " + car.LicensePlate);
                                }
                            }

                            if (oatmilks.Count > 0)
                            {
                                System.Console.WriteLine("Oatmilk: ");
                                foreach (var oatmilk in oatmilks)
                                {
                                    System.Console.WriteLine("Fat content: " + oatmilk.Fat + ", Litres: " + oatmilk.Liters);
                                }
                            }
                        }
                        System.Console.WriteLine("Press enter to go back to the main menu");
                        Console.ReadLine();
                        break;

                    case "6":
                        System.Console.WriteLine("You chose to exit the application. Goodbye!");
                        active = false;
                        break;

                    default:
                        System.Console.WriteLine("Not a valid option, please try again.");
                        break;
                    }
            }
        }
    }
}