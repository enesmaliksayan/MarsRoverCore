using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Service.Directions
{
    public class EastDirection : IDirection
    {
        public Tuple<int, int> Move(int[,] marsSurface, int xCoordinate, int yCoordinate)
        {
            xCoordinate++;
            if (xCoordinate > marsSurface.GetLength(0))
                xCoordinate = 0;

            return new Tuple<int, int>(xCoordinate, yCoordinate);
        }

        public IDirection Turn(char way)
        {
            if (way == Commands.Left)
                return new NorthDirection();
            else
                return new SouthDirection();
        }
    }
}
