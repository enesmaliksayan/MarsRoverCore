using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    public class Mars
    {
        private readonly int[,] marsSurface;
        private Rover _rover { get; set; }

        public Mars(int xLength, int yLength)
        {
            if (xLength < 0)
                xLength = 0;

            if (yLength < 0)
                yLength = 0;

            marsSurface = new int[xLength, yLength];
        }

        public void Init(int xCrd, int yCrd, char faceStr)
        {
            if (IsNotValidInitInput(xCrd, yCrd, faceStr))
                throw new InvalidProgramException("Coordinate or face is not valid.");

            var direction = DirectionHelper.GetDirection(faceStr);
            _rover = new Rover(xCrd, yCrd, direction);
        }

        public void Execute(string command)
        {
            command = command.Replace(" ", "");
            if (Commands.IsNotValidCommand(command))
                throw new ArgumentException("Invalid Command");

            if (Commands.IsCommandForProcess(command))
            {
                Commands.Execute(command, marsSurface, _rover);
            }
            else
                Init(Int32.Parse(command[0].ToString()), Int32.Parse(command[1].ToString()), command[2]);
        }

        public string GetCurrentInfo()
        {
            return _rover.xCoordinate.ToString() + " " + _rover.yCoordinate.ToString() + " " + DirectionHelper.GetDirectionChar(_rover.direction).ToString();
        }

        private bool IsNotValidInitInput(int xCrd, int yCrd, char faceStr)
        {
            if (xCrd < 0 || xCrd > marsSurface.GetLength(0) || yCrd < 0 || yCrd > marsSurface.GetLength(1))
                return true;

            return !DirectionHelper.IsValidDirection(faceStr);
        }
    }
}
