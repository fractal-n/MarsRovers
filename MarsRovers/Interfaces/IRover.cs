using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers.Interfaces
{
    public interface IRover
    {
        void Run(IMarsMap map, string instructions);
        string ShowStatus();
    }
}
