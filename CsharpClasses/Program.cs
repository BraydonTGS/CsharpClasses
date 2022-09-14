// Bringing in everything that exists in System.Console //
using CsharpClasses;
using static System.Console;

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
Creature werewolf = new Creature();
werewolf.Name = "Blaidd";
werewolf.Age = 150;
werewolf.Species = "Werewolf";
werewolf.IsAwake = true; 
WriteLine(">Creature 1");
werewolf.Greet();
werewolf.Sleep(); 
Creature basilisk = new Creature();
basilisk.Name = "Scales";
basilisk.Age = 175;
basilisk.Species = "Snake";
basilisk.IsAwake = false;
WriteLine(">Creature 2");
werewolf.Greet(); 
WriteLine("Press Any Key to Exit..."); 
ReadKey();
