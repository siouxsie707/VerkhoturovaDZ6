using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkhoturovaDZ6
{
    class ParkingSpot
    {
        public int SpotNumber { get; set; }
        public bool IsOccupied { get; set; }
        public ParkingSpot(int spotNumber)
        {
            SpotNumber = spotNumber;
            IsOccupied = false; // по умолчанию место свободно
        }
        public void Occupy()
        {
            IsOccupied = true;
        }
        public void Free()
        {
            IsOccupied = false;
        }
        public void DisplayStatus()
        {
            string status = IsOccupied ? "Занято" : "Свободно";
            Console.WriteLine($"Парковочное место {SpotNumber}: {status}");
        }
    }
}
