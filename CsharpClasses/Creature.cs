﻿using System;
using static System.Console; 
namespace CsharpClasses
{
    public class Creature
    {
        // Fields "The variable that lives inside of the object" //
        // public = access modifier //
        // string = type //
        // Name = identifier //
        public string Name;
        public int Age;
        public string Species;
        public bool IsAwake;
        // Can't be accessed due to protection level //
        private int ExperiencePoints;

        // Greet Method //
        public void Greet()
        {
            WriteLine($"My name is {Name}, the {Species}. ");
            WriteLine($"I am {Age} years old. ");
            
        }

        public void Sleep()
        {
            WriteLine("It is time to go to sleep.");
            IsAwake = false; 
        }
    }
}

