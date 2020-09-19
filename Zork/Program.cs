﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;

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
        private static string CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }

        }

        // private static (int row, int col) Location;
        // private static bool moveIsVaild = false;
        static void Main(string[] args)
        {
            // Location.col = 1;
            // Location.row = 1;

            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.WriteLine(CurrentRoom);
                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                // check if the move is vaild
                // moveIsVaild = CanMove(command);
                // Console.Write("You at : " + currentRoom + "moveIsVaild :" + moveIsVaild + "\n");
                // string outputString;
                switch (command)
                {       
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
                        break;
                    case Commands.LOOK:
                        Console.WriteLine("This is an open field west of a white house, with a boarded front door.\n" +
                        "A rubber mat saying 'Welcome to Zork!' lies by the door.");
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:
                        if (Move(command) == false)
                        {
                            Console.WriteLine("The way is shut");
                        }
                        break;
                    default:
                        Console.WriteLine("Unkown command.");
                        break;
                }
            }  
        }
           
        private static bool Move (Commands command)
        {
            Assert.IsTrue(IsDirection(command), "Invalid direction.");
            bool isValidMove = true;

            switch(command)
            {
                case Commands.NORTH when Location.Row < Rooms.GetLength(0) - 1:
                    Location.Row++;
                    break;

                case Commands.SOUTH when Location.Row > 0:
                    Location.Row--;
                    break;

                case Commands.EAST when Location.Column < Rooms.GetLength(1) - 1:
                    Location.Column++;
                    break;

                case Commands.WEST when Location.Column > 0:
                    Location.Column--;
                    break;

                default:
                   isValidMove = false;
                    break;
            }

            return isValidMove;
        }
        private static bool IsDirection(Commands command)
        {
            return Directions.Contains(command);
        }

        private static Commands ToCommand(string commandString) => 
        (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);

        private static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        private static (int Row, int Column) Location = (1, 1);
    }
   
}

