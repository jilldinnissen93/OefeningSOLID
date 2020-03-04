using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Dag1Code
{
    public class Code
    {
        public int currentFloor { get; set; }
        public int startingFloor { get; set; }

        public string text = File.ReadAllText(@"D:\pad.txt");



        public int FollowPath()
        {
            currentFloor = startingFloor;
            foreach (char direction in text)
            {
                if (direction.Equals(')'))
                {
                    currentFloor--;
                }
                if (direction.Equals('('))
                {
                    currentFloor++;
                }
                Console.WriteLine(currentFloor);
            }
            return currentFloor;
        }
    }







    }

