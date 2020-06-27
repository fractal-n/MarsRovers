using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    public class MarsMap
    {
        public int CoorX { get; set; }
        public int CoorY { get; set; }

        public MarsMap(int coorX, int coorY)
        {
            CoorX = coorX;
            CoorY = coorY;
        }
    }
}
