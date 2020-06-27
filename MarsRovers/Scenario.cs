using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    public class Scenario
    {
        private string[] _map;
        private List<Tuple<string, string>> _roverList;

        public Scenario(string map, string[] rovers)
        {
            _map = map.Split(' ');
            _roverList = new List<Tuple<string, string>>();
            GetRoverList(rovers);
        }

        public string Run()
        {
            string result = "";
            MarsMap map = new MarsMap(int.Parse(_map[0]), int.Parse(_map[1]));
            foreach (var roverInput in _roverList)
            {
                string[] roverPosition = roverInput.Item1.Split(' ');
                string roverInstructions = roverInput.Item2;
                Rover rover = new Rover(int.Parse(roverPosition[0]), int.Parse(roverPosition[1]), roverPosition[2]);
                rover.Run(map, roverInstructions);
                result += rover.ShowStatus() + Environment.NewLine;
            }
            Console.WriteLine(result);
            return result;
        }

        private void GetRoverList(string[] rovers)
        {
            for (int index = 0; index < rovers.Length; index++)
            {
                if (!String.IsNullOrEmpty(rovers[index]) && (index % 2 == 0))
                {
                    string location = rovers[index];
                    string instructions = rovers[index + 1];    // should not be out of bound here if input is right
                    _roverList.Add(new Tuple<string, string>(location, instructions));
                }
            }
        }
    }
}
