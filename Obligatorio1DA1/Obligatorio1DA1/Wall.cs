using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{ 
    static class ConstantsWall {
        public const int MAXLENGTH = 5;
        public const int BLOCKLENGTH = 50;
    }

    public class Wall
    {
        public int[] Coordinates; // [ HorizontalOrigin, VerticalOrigin, HorizontalDestination, VerticalDestination ]

        public Wall(int[] someCoordinates) {
            this.Coordinates = someCoordinates;
        }

        public int CalculateLength() {
            return (int)Math.Sqrt(Math.Pow((this.Coordinates[3] - this.Coordinates[1]), 2) + Math.Pow((this.Coordinates[2] - this.Coordinates[0]), 2));
        }

        public int CheckLength() {
            return (int) (this.CalculateLength() / ConstantsWall.MAXLENGTH);
        }

        public void ApproximateLines()
        {
            int approximation = 0;
            for (int i = 0; i < Coordinates.Length; i++)
            {
                if ((approximation = this.Coordinates[i] % ConstantsWall.BLOCKLENGTH) <= ConstantsWall.BLOCKLENGTH)
                {
                    this.Coordinates[i] -= approximation;
                }
                else
                {
                    this.Coordinates[i] += ConstantsWall.BLOCKLENGTH - approximation;
                }
            }
        }

        public bool InSameLine()
        {
            return this.Coordinates[0] == this.Coordinates[2] || this.Coordinates[1] == this.Coordinates[3];
        }

    }
}
