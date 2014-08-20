using Assets.Kenkyuu.Battle.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Kenkyuu.Inventory.Contracts
{
    interface Equipable
    {
        void ApplyChanges(CharacterController c);
        void UnEquip(CharacterController c);
    }
}
