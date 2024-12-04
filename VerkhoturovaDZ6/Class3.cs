using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkhoturovaDZ6
{
    class MultiLevelParking : Parking
    {
        public int Levels { get; set; }
        public MultiLevelParking(string name, int capacity, int levels) : base(name, capacity)
        {
            Levels = levels;
        }
        public override void DisplayInfo()
        {
            Console.WriteLine($"Многоуровневый Паркинг: {Name}, Вместимость: {Capacity}, Уровни: {Levels}");
        }
    }
}
