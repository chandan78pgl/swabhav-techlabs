using System;
using System.Collections.Generic;
using System.Text;

namespace PlayerApp
{
    public class Player
    {
        private int _id;
        private string _name;
        private int _age = 18;

        public Player(int id, string name, int age):this(id,name)
        {
            this._age = age;
        }

        public Player(int id,string name)
        {
            this._id = id;
            this._name = name;
        }

        public Int32 Id
        {
            get
            {
                return this._id;
            }
        }

        public String Name
        {
            get
            {
                return this._name;
            }
        }

        public Int32 Age
        {
            get
            {
                return this._age;
            }
        }

        public Player WhoIsElder(Player player)
        {
            if (this.Age > player.Age)
            {
                return this;
            }
            return player;
        }

        public override bool Equals(object obj)
        {
            Player player = (Player)obj;
            if(player.Id==this.Id && player.Name==this.Name && player.Age == this.Age)
            {
                return true;
            }
            return false;
        }

        public override string ToString()
        {
            return "Player ID: "+Id
                +"\n Name: "+Name
                +"\n Age: "+Age;
        }
    }
}
