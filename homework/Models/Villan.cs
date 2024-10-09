using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework.Models
{
    public class Villan : Sprite
    {
        public Hero Opponent { get; set; }
        public Villan()
        {
            Type = HeroType.Villan;
        }

        public override void Attack(Sprite opponent)
        {
            base.Attack(opponent);
            Console.WriteLine($"{Name} attacks {opponent.Name} for {1} life!");
        }
    }
}
