using MarsRovers.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    public class MarsMap : IMarsMap
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
