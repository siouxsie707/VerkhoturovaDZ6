using System;
using VerkhoturovaDZ6;class Program
{
    
    static void Main(string[] args)
    {
            Console.WriteLine("Введите имя платного паркинга:");
            string paidParkingName = Console.ReadLine();
            Console.WriteLine("Введите вместимость:");
            int paidParkingCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите цену за час:");
            double costPerHour = double.Parse(Console.ReadLine()); PaidParking paidParking = new PaidParking(paidParkingName, paidParkingCapacity, costPerHour);
            paidParking.DisplayInfo(); Console.WriteLine("Введите имя многоуровневого паркинга:");
            string multiLevelParkingName = Console.ReadLine();
            Console.WriteLine("Введите вместимость:");
            int multiLevelParkingCapacity = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите количество уровней:");
            int levels = int.Parse(Console.ReadLine()); MultiLevelParking multiLevelParking = new MultiLevelParking(multiLevelParkingName, multiLevelParkingCapacity, levels);
            multiLevelParking.DisplayInfo();        // Пример использования парковочного места
            Console.WriteLine("Введите номер парковочного места:");
            int spotNumber = int.Parse(Console.ReadLine()); ParkingSpot parkingSpot = new ParkingSpot(spotNumber);
            parkingSpot.DisplayStatus(); // показать статус места
            parkingSpot.Occupy(); // занять место
            parkingSpot.DisplayStatus(); // показать статус места после занятия
            parkingSpot.Free(); // освободить место
            parkingSpot.DisplayStatus(); // показать статус места после освобождения
    }

}