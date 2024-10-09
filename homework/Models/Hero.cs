using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Models
{
    public class Hero : Sprite
    {
        public Villan Opponent { get; set; }
        public Hero()
        {
            Type = HeroType.Hero;
        }

        public override void Attack(Sprite opponent)
        {
            base.Attack(opponent);
            Console.WriteLine($"{Name} attacks {opponent.Name} for {1} life!");
        }

        public void Heal(Sprite target, int amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentException("Healing amount must be positive.");
            }

            target.Health += amount;

            this.Health -= amount;

            if (this.Health < 0) this.Health = 0;
            if (target.Health < 0) target.Health = 0;

            Console.WriteLine($"{Name} heals {target.Name} for {amount} health!");
        }
    }
}
