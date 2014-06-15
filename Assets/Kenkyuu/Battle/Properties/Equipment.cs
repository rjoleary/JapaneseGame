using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Inventory.Contracts;

namespace Assets.Kenkyuu.Battle.Properties
{
    class Equipment
    {
        private Equipable helm, armor, rhand, lhand, accessory;
        Equipable Wear(Equipment i) { 
            return helm;
        }

        Equipable Remove(Equipable i){
            return helm;
        }
    }
}
