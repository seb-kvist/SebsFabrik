# SebsFabrik Console Application

## Overview
SebsFabrik is a simple C# console application created for Multifabriken AB, allowing customers to place orders for different types of products. The application offers the ability to create and list products, which include cars, candy, pipes, and oat milk. The program provides an interactive menu where users can select the product type, enter the required information, and view a list of products they have ordered.

### Key Features:
- **Product Menu:** Displays a list of product types (Cars, Candy, Pipes, Oat Milk) for the user to choose from.
- **Product Creation:** Users can enter specific details for each product type:
  - **Cars:** Enter registration number, color, and make.
  - **Candy:** Enter flavor and quantity.
  - **Pipes:** Enter diameter and length.
  - **Oat Milk:** Enter fat content and quantity in liters.
- **List Orders:** View a list of all products the user has ordered so far.
- **Exit Program:** Option to exit the application.

## Files:
- **Program.cs:** The main file that holds the structure and logic for user interaction and program flow.
- **SebsFabrik.csproj:** The project file for the application.
- **Product Classes:** Separate classes for each product type (Car, Candy, Pipe, OatMilk).
  - **Car.cs:** Defines the properties and methods for a car.
  - **Candy.cs:** Defines the properties and methods for candy.
  - **Pipe.cs:** Defines the properties and methods for pipes.
  - **OatMilk.cs:** Defines the properties and methods for oat milk.

## Installation

1. Clone this repository:
```
git clone https://github.com/seb-kvist/SebsFabrik.git
```

2. Open the solution in Visual Studio or your preferred C# IDE.

3. Build and run the application.

## Usage

- When you start the program, a menu will be displayed with the following options:
1. **Order a Car** - Enter registration number, color, and make.
2. **Order Candy** - Enter flavor and quantity.
3. **Order a Pipe** - Enter diameter and length.
4. **Order Oat Milk** - Enter fat content and quantity in liters.
5. **List Orders** - Displays all products you have ordered so far.
6. **Exit** - Exits the application.

- Select an option by entering the corresponding number.
- After placing an order, you will be prompted to enter the necessary details for the product type.
- Once you choose "List Orders," all your previous orders will be displayed.
- The program will continue running until you choose the option to exit.

## Development

To modify or extend the functionality of the app, you can:

- Modify the `Program.cs` file to change how the main menu and product selection are displayed.
- Edit or add new classes for additional product types.
- Update the order listing functionality or add more features as needed.

## Technologies Used
- C#
- .NET Core 8.0
