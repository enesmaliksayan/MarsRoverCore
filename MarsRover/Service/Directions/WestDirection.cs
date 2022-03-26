using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Service.Directions
{
    public class WestDirection : IDirection
    {
        public Tuple<int, int> Move(int[,] marsSurface, int xCoordinate, int yCoordinate)
        {
            xCoordinate--;
            if (xCoordinate < 0)
                xCoordinate = marsSurface.GetLength(0);

            return new Tuple<int, int>(xCoordinate, yCoordinate);
        }

        public IDirection Turn(char way)
        {
            if (way == Commands.Left)
                return new SouthDirection();
            else
                return new NorthDirection();
        }
    }
}
