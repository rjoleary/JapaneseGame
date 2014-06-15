﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Business.Inventory;

namespace Assets.Kenkyuu.Business.Contracts
{
    public interface ItemController
    {
        List<string> GetStringList();

        Item GetByStringName(string name);
    }
}
