using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public interface IDirection
    {
        public IDirection Turn(char way);
        public Tuple<int,int> Move(int[,] marsSurface, int xCoordinate, int yCoordinate);
    }
}
