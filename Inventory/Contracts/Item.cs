using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Battle.Contracts;

namespace Assets.Kenkyuu.Inventory.Contracts
{
    public interface Item
    {
        void use(Func<CharacterController, int> change); 
    }
}
