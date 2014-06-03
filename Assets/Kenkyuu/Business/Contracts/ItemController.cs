using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Business.Inventory;

namespace Assets.Kenkyuu.Business.Contracts
{
    interface ItemController
    {
        public List<string> GetStringList();

        public Item GetByStringName(string name);
    }
}
