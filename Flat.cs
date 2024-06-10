using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_20._05
{
    public struct Flat : IProperty
    {
        public string Type { get; set; }
        public int Square { get; set; }
        public int CountRooms { get; set; }
        public string Address { get; set; }
        public bool HasBalcony { get; set; }
        public bool HasGas { get; set; }
        public int Floor { get; set; }
    }
}
