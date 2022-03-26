using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public static class Commands
    {
        public const char Left = 'L';
        public const char Rigth = 'R';
        public const char Move = 'M';

        public static void Execute(string command, int[,] marsSurface, Rover rover)
        {
            foreach (var cmd in command.ToCharArray())
            {
                if (cmd == Move)
                {
                    var newCoordinates = rover.direction.Move(marsSurface, rover.xCoordinate, rover.yCoordinate);
                    rover.xCoordinate = newCoordinates.Item1;
                    rover.yCoordinate = newCoordinates.Item2;
                }
                else
                    rover.direction = rover.direction.Turn(cmd);
            }
        }

        public static bool IsNotValidCommand(string command)
        {
            if (command.Length != 0 && (IsCommandForProcess(command) || command.Length == 3))
                return false;

            return true;
        }

        public static bool IsCommandForProcess(string command)
        {
            var commands = new char[] { Left, Rigth, Move };

            if ((command.StartsWith(Left) ||
                command.StartsWith(Rigth) ||
                command.StartsWith(Move)) &&
                command.All(x => commands.Contains(x)))
                return true;

            return false;
        }
    }
}
