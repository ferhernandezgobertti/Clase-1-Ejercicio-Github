using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    static class ConstantsChart
    {
        public const int BLOCKPIXELS = 50;
        public const int MAXLENGTH = 20;
    }

    public class Chart
    {

        private List<Wall> walls = new List<Wall>();
        private List<Hole> holes = new List<Hole>();
        private Client client;
        public int[] Dimensions; // [ Length, Width ]
        public String Name { get; set; }

        public Chart(int[] someDimensions) {
            this.Dimensions = someDimensions;
        }

        public void AddWall(Wall someWall) {
            this.walls.Add(someWall);
        }
        public void RemoveWall(Wall someWall) {
            this.walls.Remove(someWall);
        }
        public bool NoWall() {
            return this.walls.Count() == 0;
        }
        public void AddHole(Hole someHole) {
            this.holes.Add(someHole);
        }
        public void RemoveHole(Hole someHole) {
            this.holes.Remove(someHole);
        }
        public bool NoHole() {
            return this.holes.Count() == 0;
        }

        public bool CheckDimensions(int[] someDimensions) {
            return someDimensions[0] <= ConstantsChart.MAXLENGTH && someDimensions[1] <= ConstantsChart.MAXLENGTH;
        }
        public int[] GetPixels() {
            int[] chartPixels = new int[2];
            chartPixels[0] = this.Dimensions[0] * ConstantsChart.BLOCKPIXELS;
            chartPixels[1] = this.Dimensions[1] * ConstantsChart.BLOCKPIXELS;
            return chartPixels;
        }

    }
}
