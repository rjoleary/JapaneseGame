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
        protected LevelManager level;

        public string Name 
        {
            get; set;
        }
        public void UpdateStatus(Status status) {
        
        }

        public void GainExperience(List<Experience> exp){
        
        }
        public void UseItem(Item item){
        
        }

    }
}
