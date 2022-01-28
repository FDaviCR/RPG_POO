using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG___POO.src.Entities
{
    public class Wizard : Hero
    {
        public Wizard(string Name, int Level, string HeroType)
        {
            this.Name = Name;
            this.Level = Level;
            this.HeroType = HeroType;
        }
        public override string Attack()
        {
            return this.Name + " Lançou uma maldição";
        }

        public string Attack(string Shikigami, int Power)
        {
            if (Power > 6){
                return this.Name + " Lançou o shikigami " + Shikigami + ". Ataque poderoso";
            }
            else{
                return this.Name + " Lançou o shikigami " + Shikigami + ". Ataque fraco";
            }
            
        }
    }
}
