using System;
using System.ComponentModel.Design;

namespace Zork
{
    class Program
    {
        private static string[] Rooms = { "Forest", " West of the House", "Behind House", "Clearing", "Canyon View" };
        private static int currentRoom = 1;
        private static bool moveIsVaild = false;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            Commands command = Commands.UNKNOWN;
            while(command != Commands.QUIT)
            {
                Console.WriteLine(Rooms[currentRoom]);
                command = ToCommand(Console.ReadLine().Trim());
                moveIsVaild = CanMove(command);
                
                string outputString;
                switch (command)
                {
                    case Commands.LOOK:
                        outputString = "This is an open field west of a white house, with a boarded front door.\n" +
                        "A rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                        if (moveIsVaild == true)
                        { 
                            currentRoom ++;
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
                            currentRoom ++;
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
            int moveBond = Rooms.Length;

            switch(command)
            {
                case Commands.NORTH:
                case Commands.SOUTH:
                    return false;
                    
                case Commands.EAST:
                    if (currentRoom + 1 >= moveBond)
                    {
                        return false;
                    }
                    else
                    {
                        return false;
                    }
                case Commands.WEST:
                    if (currentRoom - 1 < moveBond)
                    {
                        return false;
                    }
                    else
                    {
                        return false;
                    }
                default:
                   return false;
            }
        }

        private static Commands ToCommand(string commandString) => 
        (Enum.TryParse<Commands>(commandString, true, out Commands result) ? result : Commands.UNKNOWN);
 

    }
   
}

