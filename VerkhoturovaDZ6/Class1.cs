using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VerkhoturovaDZ6
{
    public abstract class Parking
    {
        public string Name { get; set; }
        public int Capacity { get; set; }
        public Parking(string name, int capacity)
        {
            Name = name;
            Capacity = capacity;
        }
        public abstract void DisplayInfo();
    }
}
