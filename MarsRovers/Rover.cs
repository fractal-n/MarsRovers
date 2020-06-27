using System;
using System.Collections.Generic;
using System.Text;

namespace MarsRovers
{
    public class Rover
    {
        private int _positionX = 0;
        private int _positionY = 0;
        private string _facing = String.Empty;

        public Rover(int positionX, int positionY, string facing)
        {
            _positionX = positionX;
            _positionY = positionY;
            _facing = facing;
        }

        public void Run(MarsMap map, string instructions)
        {
            foreach(var action in instructions)
            {
                //Console.WriteLine(ShowStatus() + " ==== " + action);
                
                if (!IsOutOfMap(map))
                {
                    switch (action)
                    {
                        case 'M':
                            MoveForward();
                            break;
                        case 'L':
                            TurnLeft();
                            break;
                        case 'R':
                            TurnRight();
                            break;
                        default:
                            Console.WriteLine("unknown instruction " + action);
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("oops!! rover falls off the cliff at " + action);
                    return;
                }
            }
        }

        public string ShowStatus()
        {
            return $"{_positionX} {_positionY} {_facing}";
        }

        private bool IsOutOfMap(MarsMap map)
        {
            return _positionX > map.CoorX || _positionY > map.CoorY;
        }

        private void MoveForward()
        {
            switch (_facing)
            {
                case "N":
                    _positionY++;
                    break;
                case "W":
                    _positionX++;
                    break;
                case "S":
                    _positionY--;
                    break;
                case "E":
                    _positionX--;
                    break;
                default:
                    Console.WriteLine("Unknown facing direction " + _facing);
                    break;
            }
        }

        private void TurnLeft()
        {
            switch (_facing)
            {
                case "N":
                    _facing = "E";
                    break;
                case "W":
                    _facing = "N";
                    break;
                case "S":
                    _facing = "W";
                    break;
                case "E":
                    _facing = "S";
                    break;
                default:
                    Console.WriteLine("Unknown facing direction " + _facing);
                    break;
            }
        }

        private void TurnRight()
        {
            switch (_facing)
            {
                case "N":
                    _facing = "W";
                    break;
                case "W":
                    _facing = "S";
                    break;
                case "S":
                    _facing = "E";
                    break;
                case "E":
                    _facing = "N";
                    break;
                default:
                    Console.WriteLine("Unknown facing direction " + _facing);
                    break;
            }
        }
    }
}
