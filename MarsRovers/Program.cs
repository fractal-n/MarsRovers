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

            List<string> testCaseList = new List<string>();
            foreach (var line in inputFile)
            {
                if (line.StartsWith("//"))
                {
                    // Comment can start with "//" as well
                    Console.WriteLine(line);
                    
                    if (testCaseList.Count > 0)
                    {
                        ParseAndRunTestCase(testCaseList.ToArray());
                        testCaseList.Clear();
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (!String.IsNullOrEmpty(line))
                    {
                        testCaseList.Add(line);
                    }
                }
            }

            Console.WriteLine("******************");
            Console.WriteLine("done!!");
        }

        static void ParseAndRunTestCase(string[] testCase)
        {
            string map = testCase[0];
            List<string> roverList = new List<string>();
            for (int index = 1; index < testCase.Length; index++)
            {
                roverList.Add(testCase[index]);
            }
            TestCase newCase = new TestCase(map, roverList.ToArray());
            newCase.Run();
        }
    }
}
