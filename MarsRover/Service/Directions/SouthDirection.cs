using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Service.Directions
{
    public class SouthDirection : IDirection
    {
        public Tuple<int,int> Move(int[,] marsSurface, int xCoordinate, int yCoordinate)
        {
            yCoordinate--;
            if (yCoordinate < 0)
                yCoordinate = marsSurface.GetLength(1);

            return new Tuple<int, int>(xCoordinate, yCoordinate);
        }

        public IDirection Turn(char way)
        {
            if (way == Commands.Left)
                return new EastDirection();
            else
                return new WestDirection();
        }
    }
}
