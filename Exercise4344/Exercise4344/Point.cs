using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise4344
{
    class Point
    {
        public int xCoord;
        public int yCoord;

        public Point (int x, int y)
        {
            this.xCoord = x;
            this.yCoord = y;
        }
        
        public Point ()
        {

        }

        public void getInfo (int input)
        {
            var obj = this;
            Console.WriteLine(input);
        }
    }

    class Coordinate : Point
    {
        public Point coord;
    }
}
