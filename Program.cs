using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Menu menu = new Menu();
        InputValidator validator = new InputValidator();
        TollCalculator calculator = new TollCalculator();


        // to-do: remove the null initialization for vehicle and toll objects
        Vehicle? vehicle = null;
        Toll? toll = null;
        DateTime transactionTime = DateTime.MinValue;

        bool running = true;

        while (running)
        {
            Console.Clear();

            menu.Display();

            Console.Write("\nEnter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("\nInvalid choice!");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                continue;
            }

            switch (choice)
            {
                case 1:

                    Console.Clear();

                    Console.WriteLine("=========================================");
                    Console.WriteLine("         CALCULATE TOLL");
                    Console.WriteLine("=========================================\n");

                    vehicle = new Vehicle();

                    // Vehicle Number
                    while (true)
                    {
                        Console.Write("Vehicle Number : ");
                        string number = Console.ReadLine() ?? "";

                        if (!string.IsNullOrWhiteSpace(number))
                        {
                            vehicle.VehicleNumber = number;
                            break;
                        }

                        Console.WriteLine("Vehicle Number cannot be empty.\n");
                    }

                    // Vehicle Type
                    while (true)
                    {
                        Console.Write("Vehicle Type (Bike/Car/Bus/Truck): ");
                        string type = (Console.ReadLine() ?? "").ToLower();

                        if (validator.ValidateVehicleType(type))
                        {
                            vehicle.VehicleType = type;
                            break;
                        }

                        Console.WriteLine("Invalid Vehicle Type.\n");
                    }

                    // Journey Type
                    while (true)
                    {
                        Console.Write("Journey Type (One Way/Round Trip): ");
                        string journey = (Console.ReadLine() ?? "").ToLower();

                        if (validator.ValidateJourneyType(journey))
                        {
                            vehicle.JourneyType = journey;
                            break;
                        }

                        Console.WriteLine("Invalid Journey Type.\n");
                    }

                    // FASTag
                    while (true)
                    {
                        Console.Write("FASTag Available (Yes/No): ");
                        string input = (Console.ReadLine() ?? "").ToLower();

                        if (validator.ValidateYesNo(input))
                        {
                            vehicle.FASTagAvailable = input == "yes";
                            break;
                        }

                        Console.WriteLine("Enter Yes or No.\n");
                    }

                    // Peak Hour
                    while (true)
                    {
                        Console.Write("Peak Hour (Yes/No): ");
                        string input = (Console.ReadLine() ?? "").ToLower();

                        if (validator.ValidateYesNo(input))
                        {
                            vehicle.PeakHour = input == "yes";
                            break;
                        }

                        Console.WriteLine("Enter Yes or No.\n");
                    }

                    toll = calculator.CalculateToll(vehicle);
                    //Now - property of DateTime 
                    
                    transactionTime = DateTime.Now;

                    Console.WriteLine("\nToll calculated successfully!");

                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();

                    break;

                case 2:

                    Console.Clear();

                    if (vehicle == null || toll == null)
                    {
                        Console.WriteLine("No toll calculation available.");

                        Console.WriteLine("\nPress any key to continue...");
                        Console.ReadKey();
                        break;
                    }

                    Console.WriteLine("=========================================");
                    Console.WriteLine("             TOLL RECEIPT");
                    Console.WriteLine("=========================================\n");

                    Console.WriteLine($"Date & Time         : {transactionTime:dd-MM-yyyy hh:mm:ss tt}");

                    Console.WriteLine();

                    Console.WriteLine($"Vehicle Number      : {vehicle.VehicleNumber}");
                    Console.WriteLine($"Vehicle Type        : {vehicle.VehicleType}");
                    Console.WriteLine($"Journey Type        : {vehicle.JourneyType}");
                    Console.WriteLine($"FASTag Available    : {(vehicle.FASTagAvailable ? "Yes" : "No")}");
                    Console.WriteLine($"Peak Hour           : {(vehicle.PeakHour ? "Yes" : "No")}");

                    Console.WriteLine("\n-----------------------------------------");

                    Console.WriteLine($"Base Toll           : ₹{toll.BaseToll}");
                    Console.WriteLine($"Discount            : ₹{toll.Discount}");
                    Console.WriteLine($"Additional Charges  : ₹{toll.AdditionalCharges}");

                    Console.WriteLine("-----------------------------------------");

                    Console.WriteLine($"Final Toll Amount   : ₹{toll.FinalTollAmount}");

                    Console.WriteLine("\n=========================================");

                    Console.WriteLine("\nPress any key to return to the menu...");
                    Console.ReadKey();

                    break;

                case 3:

                    Console.Clear();

                    vehicle = null;
                    toll = null;
                    transactionTime = DateTime.MinValue;

                    Console.WriteLine("Current input cleared successfully.");

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                    break;

                case 4:

                    Console.Clear();

                    Console.WriteLine("=========================================");
                    Console.WriteLine("Thank you for using");
                    Console.WriteLine("Vehicle Toll Calculator");
                    Console.WriteLine("=========================================");

                    running = false;
                    break;

                default:

                    Console.WriteLine("\nInvalid menu choice.");

                    Console.WriteLine("\nPress any key to continue...");
                    Console.ReadKey();

                    break;
            }
        }
    }
}