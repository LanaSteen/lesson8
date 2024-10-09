using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace homework.Models
{
    //სახელი - Name
    //ფული - Money
    //სიცოცხლე - Health
    public class Sprite
    {
        public string Name { get; set; }
        
      
        private decimal money;
        public decimal Money
        {
            get
            {
                return money;
            }
            set
            {
                if (value >= 0)
                {
                    money = value;
                }
                else
                {
                    throw new ArgumentException("Money can't be under 0");
                }
            }
        }
        private int health;
        public int Health
        {
            get
            {
                return health;
            }
            set
            {
                if (value >= 0)
                {
                    health = value;
                }
                else
                {
                    throw new ArgumentException("health can't be under 0");
                }
            }
        }
        public Sprite()
        {

        }

        private HeroType type;
        public HeroType Type { 
            get 
            { 
                return type; 
            }
            set
            {
                if (value == HeroType.Hero || value == HeroType.Villan)
                {
                    type = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Not correct hero type - {value}");
                }
            }
        
        
        }
        private PowerType power;
        public PowerType Power
        {
            get
            {
                return power;
            }
            set
            {
                if (value == PowerType.DarkAbility || value == PowerType.LightAbility)
                {
                    power = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException($"Not correct power type - {value}");
                }
            }


        }

        public virtual string AboutMe()
        {
            return $"Hi, my name is {Name}, I'm a {Type}, I have {Health} health, and {Money} " +
                   $"money on my balance, my power is {Power}";
        }
        public virtual void Attack(Sprite opponent)
        {
            this.Money -= 1;

            opponent.Money += 1;

            if (this.Money < 0) this.Money = 0;
            if (opponent.Money < 0) opponent.Money = 0;
        }

    }

    public enum HeroType {
        Villan,
        Hero
    }

    public enum PowerType
    {
        LightAbility,
        DarkAbility
    }

}