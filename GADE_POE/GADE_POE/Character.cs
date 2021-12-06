using System;
using System.Collections.Generic;
using System.Text;

namespace GADE_POE
{
    abstract class Character:Tile
    {
        protected int Hp;
        protected int MaxHp;
        protected int Damage;
        public Tile [] vision = new Tile[4]; 
        
        public int getHP
        {
            get { return Hp; }
            set { Hp = value; }
        }

        public int getMaxHP
        {
            get { return MaxHp; }
            set { MaxHp = value; }
        }

        public int getDamage
        {
            get { return Damage; }
            set { Damage = value; }
        }

        public Character(int x,int y,string symbol, @enum.Tiletype tiletype):base(x,y,symbol,tiletype)
        {

        }

        public virtual void attack(Character Target)
        {
            
            if (checkrange(Target))
            {
                Target.Hp= Target.Hp- Damage;
            }

        }

        
        public bool isdead()
        {
            if (Hp<= 0)
            {
                return true;
            }
            else return false;
        }


        
        public virtual bool checkrange(Character Target)
        {
            if (DistanceTo(Target) > 1 || DistanceTo(Target) == 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

       
        public int DistanceTo(Character character)
        {
            int num = X + Y;
            int num2 = character.X + character.Y;
            int num3 = Math.Abs(num - num2);
            return num3;
        }

        
        public void Move(@enum.movement move)
        {
            switch (move)
            {
                case @enum.movement.up:
                    Y = Y - 1;
                    break;
                case @enum.movement.down:
                    Y = Y + 1;
                    break;
                case @enum.movement.left:
                    X = X - 1;
                    break;
                case @enum.movement.right:
                    X = X + 1;
                    break;
                case @enum.movement.Nomovement:
                    break;
            }
        }

    }
}
