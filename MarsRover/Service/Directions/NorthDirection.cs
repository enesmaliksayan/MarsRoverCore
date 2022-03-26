using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Service.Directions
{
    public class NorthDirection : IDirection
    {
        public Tuple<int, int> Move(int[,] marsSurface, int xCoordinate, int yCoordinate)
        {
            yCoordinate++;
            if (yCoordinate > marsSurface.GetLength(1))
                yCoordinate = 0;

            return new Tuple<int, int>(xCoordinate, yCoordinate);
        }

        public IDirection Turn(char way)
        {
            if (way == Commands.Left)
                return new WestDirection();
            else
                return new EastDirection();
        }
    }
}
