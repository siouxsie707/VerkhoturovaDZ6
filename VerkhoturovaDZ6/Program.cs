using System;
using VerkhoturovaDZ6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Введите название платного паркинга:");
        string paidParkingName = Console.ReadLine();
        Console.WriteLine("Введите вместимость:");

        int paidParkingCapacity;
        while (!int.TryParse(Console.ReadLine(), out paidParkingCapacity))
        {
            Console.WriteLine("Ошибка. Пожалуйста, введите корректный номер:");
        }

        Console.WriteLine("Введите цену за час:");
        double costPerHour;
        while (!double.TryParse(Console.ReadLine(), out costPerHour))
        {
            Console.WriteLine("Ошибка. Пожалуйста, введите корректную цену за час:");
        }

        PaidParking paidParking = new PaidParking(paidParkingName, paidParkingCapacity, costPerHour);
        paidParking.DisplayInfo();

        Console.WriteLine("Введите название многоуровневого паркинга:");
        string multiLevelParkingName = Console.ReadLine();
        Console.WriteLine("Введите вместимость:");

        int multiLevelParkingCapacity;
        while (!int.TryParse(Console.ReadLine(), out multiLevelParkingCapacity))
        {
            Console.WriteLine("Ошибка. Пожалуйста, введите корректный номер:");
        }

        Console.WriteLine("Введите количество уровней:");
        int levels;
        while (!int.TryParse(Console.ReadLine(), out levels))
        {
            Console.WriteLine("Ошибка. Пожалуйста, введите корректное количество уровней:");
        }

        MultiLevelParking multiLevelParking = new MultiLevelParking(multiLevelParkingName, multiLevelParkingCapacity, levels);
        multiLevelParking.DisplayInfo();

        Console.WriteLine("Введите номер парковочного места:");
        int spotNumber;
        while (!int.TryParse(Console.ReadLine(), out spotNumber))
        {
            Console.WriteLine("Ошибка. Пожалуйста, введите корректный номер парковочного места:");
        }

        ParkingSpot parkingSpot = new ParkingSpot(spotNumber);
        parkingSpot.DisplayStatus();
        parkingSpot.Occupy(); // занять место
        parkingSpot.DisplayStatus();
        parkingSpot.Free(); // освободить место
        parkingSpot.DisplayStatus();
    }
}