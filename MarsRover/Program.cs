using System;

namespace MarsRover
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Mars r = null;

            do
            {
                try
                {
                    Console.Write("Please insert length of mars surface: ");
                    input = Console.ReadLine().Replace(" ", "");
                    var x = Int32.Parse(input[0].ToString());
                    var y = Int32.Parse(input[1].ToString());
                    r = new Mars(x, y);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            } while (r == null);

            do
            {
                try
                {

                    input = Console.ReadLine();
                    r.Execute(input);
                    Console.WriteLine("Current Position: " + r.GetCurrentInfo());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            } while (true);
        }
    }
}
