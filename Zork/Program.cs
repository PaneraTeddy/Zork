﻿using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.IO;
using System.Linq;

namespace Zork
{
    class Program
    {
        static Program()
        {
            RoomMap = new Dictionary<string, Room>();
            foreach (Room room in Rooms)
            {
                RoomMap[room.Name] = room;
            }
        }

        private enum Fields
        {
            Name = 0,
            Description
        }
        private static Room CurrentRoom
        {
            get
            {
                return Rooms[Location.Row, Location.Column];
            }

        }

        private enum CommandLineArguments
        {
            RoomsFilename = 0
        }


        static void Main(string[] args)
        {
            // Location.col = 1;
            // Location.row = 1;
            const string defaultRoomsFilename = "Rooms.txt";
            string roomsFilename = (args.Length > 0 ? args[(int)CommandLineArguments.RoomsFilename] : defaultRoomsFilename);

            InitializeRoomDescriptions(roomsFilename);

            Console.WriteLine("Welcome to Zork!");
            Room previousRoom = null;
            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.WriteLine(CurrentRoom);
                if (previousRoom != CurrentRoom)
                {
                    Console.WriteLine(CurrentRoom.Description);
                    previousRoom = CurrentRoom;
                }

                Console.Write("> ");
                command = ToCommand(Console.ReadLine().Trim());

                switch (command)
                {       
                    case Commands.LOOK:
                        Console.WriteLine(CurrentRoom.Description);
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
                    case Commands.QUIT:
                        Console.WriteLine("Thank you for playing!");
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

        private static void InitializeRoomDescriptions(string roomsFilename)
        {
            const string fieldDelimiter = "##";
            const int expectedFieldCount = 2;

            var roomQueary = from line in File.ReadLines(roomsFilename)
                             let fields = line.Split(fieldDelimiter)
                             where fields.Length == expectedFieldCount
                             select (Name: fields[(int)Fields.Name],
                                     Description: fields[(int)Fields.Description]);

            foreach (var (Name, Description) in roomQueary)
            {
                RoomMap[Name].Description = Description;
            }
        }

        private static readonly Room[,] Rooms = {
            { new Room ("Rocky Trail"), new Room ("South of House"),new Room ("Canyon View") },
            { new Room("Forest"), new Room("West of House"), new Room("Behind House") },
            { new Room("Dense Woods"), new Room("North of House"), new Room("Clearing" )},

        };

        private static readonly List<Commands> Directions = new List<Commands>
        {
            Commands.NORTH,
            Commands.SOUTH,
            Commands.EAST,
            Commands.WEST
        };

        private static readonly Dictionary<string, Room> RoomMap;
        private static (int Row, int Column) Location = (1, 1);
        private static bool IsDirection(Commands command) => Directions.Contains(command);
        private static Commands ToCommand(string commandString) =>
        (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);

    }
   
}

