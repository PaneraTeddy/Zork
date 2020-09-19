using System;
using System.ComponentModel.Design;

namespace Zork
{
    class Program
    {
        private static readonly string[,] Rooms = 
        {
            { "Rocky Trail", "South of House", "Canyon View" },
            { "Forest", "West of House", "Behind House" },
            { "Dense Woods", "North of House", "Clearing" },

        };

        private static (int row, int col) Location;

        private static bool moveIsVaild = false;

        static void Main(string[] args)
        {
            Location.col = 1;
            Location.row = 1;

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.WriteLine(Rooms[Location.row, Location.col]);
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                // check if the move is vaild
                moveIsVaild = CanMove(command);
                // Console.Write("You at : " + currentRoom + "moveIsVaild :" + moveIsVaild + "\n");
                string outputString;
                switch (command)
                {
                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door.\n" +
                        "A rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                        if (moveIsVaild == true)
                        {
                            Location.row++;
                            outputString = "You moved " + command + ".";
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }
                        break;
                    case Commands.SOUTH:
                        if (moveIsVaild == true)
                        {
                            Location.row--;
                            outputString = "You moved " + command + ".";
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }
                        break;
                    case Commands.EAST:
                        if (moveIsVaild == true)
                        {
                            Location.col++;
                            outputString = "You moved " + command + ".";
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }
                        break;
                            
                    case Commands.WEST:
                        if (moveIsVaild == true)
                        {
                            Location.col--;
                            outputString = "You moved " + command + ".";
                        }
                        else
                        {
                            outputString = "The way is shut!";
                        }
                        break;

                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    default:
                        outputString = "Unkown command.";
                        break;
                }
                Console.WriteLine(outputString);
            }  
        }
           
        private static bool CanMove (Commands command)
        {   
            switch(command)
            {
                case Commands.NORTH:
                    if (Location.row + 1 >= Rooms.GetLength(0))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                case Commands.SOUTH:
                    if (Location.row - 1 <= -1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                case Commands.EAST:
                    if (Location.col + 1 >= Rooms.GetLength(1))
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }

                case Commands.WEST:
                    if (Location.col - 1 <= -1)
                    {
                        return false;
                    }
                    else
                    {
                        return true;
                    }
                default:
                   return false;
            }
        }

        private static Commands ToCommand(string commandString) => 
        (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);
 

    }
   
}

