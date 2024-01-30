using System;

class Program
{
    static void Main()
    {
        // Program Structure
        Console.WriteLine("WELCOME TO MIKHAIL AUTO SHOP!");

        // Variables and Data Types
        int vehicleSold = 16;
        double pricePerVehicle = 5.999.99;
        string VehicleModel = "LAMBORGHINI";

        // Doing Math
        double totalRevenue = vehicleSold * pricePerVehicle;

        // More on Strings
        Console.WriteLine($"Car Model: {VehicleModel}\nVehicle Sold: {vehicleSold}\nPrice per Vehicle: ${pricePerVehicle}");

        // Concatenation and Interpolation
        string greeting = "Thank you for choosing and trusting Spark Ford Car Shop!";
        Console.WriteLine(greeting);

        // Comparison Operators
        if (vehicleSold > 0)
        {
            Console.WriteLine("Sparks Vehicles are Available");
        }
        else if (vehicleSold == 0)
        {
            Console.WriteLine("Sorr! We are out of stock of that vehicle.");
        }
        else
        {
            Console.WriteLine("Invalid vehicle quantity.");
        }

        // Logical Operators
        bool isDiscountAvailable = true;
        if (vehicleSold > 10 && isDiscountAvailable)
        {
            Console.WriteLine("Congratulations! You are qualified for Discount.");
        }

        // switch Statement
        string customerRating = "Great Choice!";
        switch (customerRating)
        {
            case "Excellent":
                Console.WriteLine("Thank you for your Great Choice!");
                break;
            case "Good":
                Console.WriteLine("We humbly appreciated your Feedback!");
                break;
            default:
                Console.WriteLine("We respect and love your Feedback");
                break;
        }

        // Ternary Operator
        string status = (vehicleSold > 0) ? "Available" : "Out of stock";
        Console.WriteLine($"Status: {status}");

        // for Loop
        for (int i = 1; i <= 6; i++)
        {
            Console.WriteLine($"Assisting customer {i}");
        }

        // while Loop
        int restockCount = 0;
        while (restockCount < 10)
        {
            Console.WriteLine($"Restocking vehicle inventory. Restock count: {restockCount + 5}");
            restockCount++;
        }

        // break and continue
        for (int i = 2; i <= 12; i++)
        {
            if (i % 2 == 0)
                continue; // Skip even bikes
            Console.WriteLine($"Assisting with Vehicle {i}");
        }

        // Methods, Parameters, and Returning from Methods
        double discountedTotalRevenue = CalculateDiscountedTotal(totalRevenue, 0.1);
        Console.WriteLine($"Discounted Total Revenue: ${discountedTotalRevenue}");
    }

    // Method with parameters and return statement
    static double CalculateDiscountedTotal(double total, double discountRate)
    {
        return total - (total * discountRate);
