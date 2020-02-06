using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;

namespace TEST_06._02._2020
{
    public static class Testpoint
    {
        public static int GetQuarter(this Point current)
        {
            if (current.X < 0 && current.Y < 0) return 3;
            if (current.X < 0 && current.Y > 0) return 4;
            if (current.X > 0 && current.Y < 0) return 2;
            if (current.X > 0 && current.Y > 0) return 1;

            else
            {
                return 0;
            }
        }

    }
    //Point point = new Point(-1, 1);
    //Console.WriteLine(point.GetQuarter());
}
