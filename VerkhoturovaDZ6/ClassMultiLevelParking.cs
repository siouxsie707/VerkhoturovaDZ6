using System;

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
