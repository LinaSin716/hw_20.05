using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_20._05
{
    public interface IProperty
    {
        static string Type { get; set; }
        int Square { get; set; }
        int CountRooms { get; set; }
        string Address { get; set; }
    }
}
