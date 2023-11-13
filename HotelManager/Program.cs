using System;

class HotelRoomOptions
{
    static void Main()
    {
        // Dynamic array to store hotel room options
        string[] roomOptions = new string[5];
        double[] roomPrices = new double[5];

        // Allocating room options and prices
        roomOptions[0] = "Basic Room";
        roomPrices[0] = 50.00;

        roomOptions[1] = "Standard Room";
        roomPrices[1] = 80.00;

        roomOptions[2] = "Deluxe Room";
        roomPrices[2] = 120.00;

        roomOptions[3] = "Suite";
        roomPrices[3] = 200.00;

        roomOptions[4] = "Presidential Suite";
        roomPrices[4] = 500.00;

        // Displaying the hotel room options with prices
        Console.WriteLine("Hotel Room Options (Cheapest to Most Expensive):");
        PrintRoomOptionsWithPrices(roomOptions, roomPrices);

        // Get user input for room selection and number of days
        Console.Write("\nEnter the number corresponding to the room you want: ");
        int selectedRoomIndex = int.Parse(Console.ReadLine()) - 1;

        Console.Write("Enter the number of days you will be staying: ");
        int numberOfDays = int.Parse(Console.ReadLine());

        // Calculate the total cost for the stay
        double totalCost = roomPrices[selectedRoomIndex] * numberOfDays;

        // Display the total cost
        Console.WriteLine($"\nTotal cost for {roomOptions[selectedRoomIndex]} stay ({numberOfDays} days): ${totalCost:F2}");
    }

    // Helper method to print the hotel room options with prices
    static void PrintRoomOptionsWithPrices(string[] options, double[] prices)
    {
        for (int i = 0; i < options.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]} - ${prices[i]:F2} per day");
        }
    }
}
