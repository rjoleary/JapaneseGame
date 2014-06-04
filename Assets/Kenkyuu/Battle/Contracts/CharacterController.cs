using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Battle.Properties;
using Assets.Kenkyuu.Inventory.Contracts;

namespace Assets.Kenkyuu.Battle.Contracts
{
    public interface CharacterController
    {
        void UpdateStatus(Status status);
        void GainExperience(List<Experience> exp);
        void UseItem(Item item);
    }
}
