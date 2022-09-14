using System;
using static System.Console;
namespace CsharpClasses
{
    public class World
    {
       public void Run()
        {
            // Bringing in everything that exists in System.Console //
          

            Title = "=== Virtual Creature Simulator ===";
            WriteLine(@" __      ___      _               _    _____                _                       
 \ \    / (_)    | |             | |  / ____|              | |                      
  \ \  / / _ _ __| |_ _   _  __ _| | | |     _ __ ___  __ _| |_ _   _ _ __ ___  ___ 
   \ \/ / | | '__| __| | | |/ _` | | | |    | '__/ _ \/ _` | __| | | | '__/ _ \/ __|
    \  /  | | |  | |_| |_| | (_| | | | |____| | |  __/ (_| | |_| |_| | | |  __/\__ \
     \/   |_|_|   \__|\__,_|\__,_|_|  \_____|_|  \___|\__,_|\__|\__,_|_|  \___||___/
                                                                                    
                                                                                    ");
            WriteLine("Welcome to the Creature Simulator");
            WriteLine("");
            // Creature is a new type //
            // Followed by its identifier //
            // new Creature() = Constructs a Creature object //
            WriteLine(">Creature 1");
            Creature werewolf = new Creature("Blaidd", 150, "Werewolf", true);
            werewolf.Greet();
            werewolf.Sleep();
            werewolf.Eat("cheetos");
            WriteLine("");
            WriteLine(">Creature 2");
            Creature basilisk = new Creature("Scales", 175, "Snake", false);
            basilisk.Greet();
            basilisk.Sleep();
            werewolf.Eat("Mice");
            WriteLine("Press Any Key to Exit...");
            ReadKey();

        }
    }
}

