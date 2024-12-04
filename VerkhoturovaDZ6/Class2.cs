using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkhoturovaDZ6
{
    class PaidParking : Parking
    {
        public double CostPerHour { get; set; }
        public PaidParking(string name, int capacity, double costPerHour) : base(name, capacity)
        {
            CostPerHour = costPerHour;
        }
        public double CalculateCost(int hours)
        {
            return hours * CostPerHour;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Платный Паркинг: {Name}, Вместимость: {Capacity}, Цена за час: {CostPerHour}$");
        }
    }
}
