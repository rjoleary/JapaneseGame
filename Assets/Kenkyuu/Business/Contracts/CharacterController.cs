using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Business.Properties;
using Assets.Kenkyuu.Business.Inventory;

namespace Assets.Kenkyuu.Business.Contracts
{
    public interface CharacterController
    {
        void UpdateStatus(Status status);
        void GainExperience(List<Experience> exp);
        void UseItem(Item item);
    }
}
