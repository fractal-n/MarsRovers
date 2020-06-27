using System;
using System.Data;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace MarsRovers
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPath = Directory.GetCurrentDirectory() + @"\Input.txt";
            string[] inputFile = File.ReadAllLines(inputPath);

            List<string> scenarioList = new List<string>();
            foreach (var line in inputFile)
            {
                if (line.StartsWith("//"))
                {
                    // You can use "//" for comments as well
                    Console.WriteLine(line);
                    
                    if (scenarioList.Count > 0)
                    {
                        ParseAndRunScenario(scenarioList.ToArray());
                        scenarioList.Clear();
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        scenarioList.Add(line);
                    }
                }
            }

            Console.WriteLine("******************");
            Console.WriteLine("done!!");
        }

        static void ParseAndRunScenario(string[] scenario)
        {
            string map = scenario[0];
            List<string> roverList = new List<string>();
            for (int index = 1; index < scenario.Length; index++)
            {
                roverList.Add(scenario[index]);
            }
            Scenario newCase = new Scenario(map, roverList.ToArray());
            newCase.Run();
        }
    }
}
