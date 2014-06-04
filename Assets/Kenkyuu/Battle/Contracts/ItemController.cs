using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Inventory.Contracts;

namespace Assets.Kenkyuu.Battle.Contracts
{
    public interface ItemController
    {
        List<string> GetStringList();

        Item GetByStringName(string name);
    }
}
