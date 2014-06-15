using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Kenkyuu.Battle.Properties
{
    public class Statistic
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public int Psychic { get; set; }
        public int Agility { get; set; }
        public int Defense { get; set; }
        public int Resistance { get; set; }
        public int SpellVampire { get; set; }
        public int Dodge { get; set; }
        public int HealthRegeneration { get; set; }
        public int ManaRegeration { get; set; }
        public int Critical { get; set; }
        public int ArmourPenetration { get; set; }
        public int ResistPenetration { get; set; }


        public void AddStat(Statistic gain)
        {
            MaxHealth += gain.MaxHealth;
            Psychic += gain.Psychic;
            Agility += gain.Agility;
            Defense += gain.Defense;
            Resistance += gain.Resistance;
            SpellVampire += gain.SpellVampire;
            Dodge += gain.Dodge;
            HealthRegeneration += gain.HealthRegeneration;
            ResistPenetration += gain.ResistPenetration;
        }
    }
}
