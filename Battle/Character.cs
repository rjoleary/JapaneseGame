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
        protected Statistic baseStatss;
        protected Mind mind;

        public string Name 
        {
            get; set;
        }

        public void UpdateStatus(Status status) {
        
        }

        public List<Statistic> GainExperience(List<TomeExperience> exp)
        {
            var gains = mind.Learn(exp);

            foreach (var gain in gains) {
                baseStatss.AddStat(gain);
            }

            return gains;
        }

        public void UseItem(Item item){
        
        }

        public void Attack(CharacterController c) { 
        
        }

        public void TakeDamage(Statistic s)
        { 
        
        }
    }
}
