using MarsRover.Service.Directions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public static class DirectionHelper
    {
        public const char North = 'N';
        public const char East = 'E';
        public const char South = 'S';
        public const char West = 'W';

        public static bool IsValidDirection(char direction)
        {
            return new char[] { North, East, South, West }.Contains(direction);
        }

        public static IDirection GetDirection(char direction)
        {
            switch (direction)
            {
                case North:
                    return new NorthDirection();
                case East:
                    return new EastDirection();
                case West:
                    return new WestDirection();
                case South:
                    return new SouthDirection();
                default:
                    throw new ApplicationException("Invalid direction");
            }
        }

        public static char GetDirectionChar(IDirection direction)
        {
            switch (direction)
            {
                case NorthDirection:
                    return North;
                case EastDirection:
                    return East;
                case WestDirection:
                    return West;
                case SouthDirection:
                    return South;
                default:
                    throw new ApplicationException("Invalid direction");
            }
        }
    }
}
