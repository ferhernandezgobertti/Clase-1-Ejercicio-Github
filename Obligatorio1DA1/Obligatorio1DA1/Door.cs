using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Door
    {
        public int[] Location { get; set; } // [Horizontal, Vertical]
        public int Orientation { get; set; } // {1,2,3,4} donde 1=0grados, 2=90grados, 3=180grados, 4=270grados


    }
}
