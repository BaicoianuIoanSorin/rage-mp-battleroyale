using System;
using GTANetworkAPI;

namespace mygamemode
{
    public class Player
    { 
        public static readonly String DataIndetifier = "PlayerInfo";
        public String Name {get;set;}
        public int Cash {get;set;}
        public int Level {get;set;}
        public int Age {get;set;}
        public int Health {get;set;}

        public Player(String name) {
            this.Name = name;
            this.Cash = 0;
            this.Level = 0;
            this.Age = 0;
            this.Health = 0;
        }


    }
}