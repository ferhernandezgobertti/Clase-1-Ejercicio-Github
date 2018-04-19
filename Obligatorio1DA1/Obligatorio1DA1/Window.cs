using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Window
    {
        public int[] Location { get; set; } // [Horizontal, Vertical]
        public int Orientation { get; set; } // {1,2} donde 1=0grados, 2=180grados

    }
}
