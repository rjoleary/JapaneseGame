using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Battle.Properties;
using Assets.Kenkyuu.Battle.Contracts;
using Assets.Kenkyuu.Inventory.Contracts;

namespace Assets.Kenkyuu.Battle
{
    public class Character : CharacterController
    {
        protected Statistic tempStats;
        protected Statistic baseStats;
        protected Mind mind;
        private Equipment equips;

        public string Name { get; set;  }

        public List<Statistic> GainExperience(List<TomeExperience> exp)
        {
            var gains = mind.Learn(exp);

            foreach (var gain in gains) {
                baseStats.AddStat(gain);
            }
            return gains;
        }
        public void UseItem(Item item){
        
        }

        public Equipable Equip(Equipable i) {
            throw new NotImplementedException();
        }

    }
}
