using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martian
{
    public class Program
    {
        static void Main(string[] args)
        {

            var operationManager = new OperationManager();
            var robots = new Robot[2];

            string area = "";
            var arrayStr = new List<string>();
            var commandInput = "";

            commandInput = Console.ReadLine();
            area = commandInput.Trim().ToUpperInvariant();
            for (int i = 0; i < 2; i++)
            {
                var moveItem = new MoveItem();

                for (int j = 0; j < 2; j++)
                {
                    commandInput = Console.ReadLine();
                    arrayStr.Add(commandInput.Trim().ToUpperInvariant());
                }

                moveItem.Area = area;
                var robot = new Robot
                {
                    CurrentItem = operationManager.Commander(moveItem, arrayStr)
                };
                robots[i] = robot;
                arrayStr.Clear();
            }
            for (int i = 0; i < robots.Length; i++)
            {
                var r = robots[i];
                r.DoOperation();
                Console.WriteLine(r.Output());
            }

            Console.Read();
        }
    }
}