using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Final_Game
{
    public class Player
    {
        public int Intelligence;
        public int Power;
        public int Speed;
        public string Name;
        public bool Sword;
        public bool Magic;
        public int HP;
        
       
       
        


        public Player(int intelligence, int power, int speed, string name, bool sword, bool magic, int hp)
        {
            Intelligence = intelligence;
            Power = power;
            Speed = speed;
            Name = name;
            Sword = sword;
            Magic = magic;
            HP = hp;
        }
        
        
           
       
        // random number generator that returns a random number between 1-10
       

       
    }
}