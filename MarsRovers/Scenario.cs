using System;
using System.Collections.Generic;
using System.Text;
using MarsRovers.Interfaces;

namespace MarsRovers
{
    public class Scenario
    {
        private IMarsMap _marsMap;
        private IRover _rover;
        private string _roverInstructions;

        public Scenario(IMarsMap marsMap, IRover rover, string roverInstructions)
        {
            _marsMap = marsMap;
            _rover = rover;
            _roverInstructions = roverInstructions;
        }

        public string Run()
        {
            _rover.Run(_marsMap, _roverInstructions);

            string result = _rover.ShowStatus();
            Console.WriteLine(result);
            return result;
        }
    }
}
