using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Rover
    {
        public int xCoordinate { get; set; }
        public int yCoordinate { get; set; }
        public IDirection direction { get; set; }

        public Rover(int x,int y, IDirection d)
        {
            xCoordinate = x;
            yCoordinate = y;
            direction = d;
        }
    }
}
