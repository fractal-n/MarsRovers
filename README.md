# Mars Rovers Problem

## Description

A squad of robotic rovers are to be landed by NASA on a plateau on Mars.
This plateau, which is curiously rectangular, must be navigated by the
rovers so that their on-board cameras can get a complete view of the
surrounding terrain to send back to Earth.
A rover's position and location is represented by a combination of x and y
co-ordinates and a letter representing one of the four cardinal compass
points. The plateau is divided up into a grid to simplify navigation. An
example position might be 0, 0, N, which means the rover is in the bottom
left corner and facing North.
In order to control a rover , NASA sends a simple string of letters. The
possible letters are 'L', 'R' and 'M'. 'L' and 'R' makes the rover spin 90
degrees left or right respectively, without moving from its current spot.
'M' means move forward one grid point, and maintain the same heading.
Assume that the square directly North from (x, y) is (x, y+1).

### INPUT

The first line of input is the upper-right coordinates of the plateau, the
lower-left coordinates are assumed to be 0,0.
The rest of the input is information pertaining to the rovers that have
been deployed. Each rover has two lines of input. The first line gives the
rover's position, and the second line is a series of instructions telling
the rover how to explore the plateau.
The position is made up of two integers and a letter separated by spaces,
corresponding to the x and y co-ordinates and the rover's orientation.
Each rover will be finished sequentially, which means that the second rover
won't start to move until the first one has finished moving.

### OUTPUT

The output for each rover should be its final co-ordinates and heading.

### Example

- Input

```bash
5 5
1 2 N
LMLMLMLMM
3 3 E
MMRMMRMRRM
```

- Expected Output:

```bash
1 3 N
1 5 E
```

## Solution

### Design

There are 2 main objects in this problem, Map and Rover.

- The Map class is the landscape for rover to run upon.
- Rover class represent the rover itself. It can perform actions based on the given instruction. It can also report its current location and alert user if it went over the map boundary.
- Scenario is the driver for these 2 objects. It parse input and coordiates the actions between the objects.
- Program is a mechanism to read input, create scenarios, and execute each of them.

### How to run

The following methods requires Visual Studio Professional.

#### Use 'input.txt'

Follow this following format.

```txt
// First test case
// Add comments using "//"
6 6
0 0 W
MMMMM
//////// --> This line to execute the instructions
```

#### Use unit test

Create a new scenario with this method template.

```c#
[TestMethod]
public void MyTest_Scenario4_MultipleRovers_GoRandom()
{
    string map = "10 10";
    string[] rovers = {
        "0 0 N", "MMMRMMMLMM",
        "5 5 S", "LMMLMMLMMLMM"
    };
    Scenario scenario = new Scenario(map, rovers);
    string result = scenario.Run();
    Assert.AreEqual(result.Trim(), "3 5 N\r\n5 5 S");
}
```
