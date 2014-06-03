using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Business.Properties;
using Assets.Kenkyuu.Business.Inventory;

namespace Assets.Kenkyuu.Business.Contracts
{
    interface CharacterController
    {
        public void UpdateStatus(Status status);
        public void GainExperience(List<Experience> exp);
        public void UseItem(Item item);
    }
}
