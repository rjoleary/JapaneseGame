﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Business.Properties;
using Assets.Kenkyuu.Business.Contracts;

namespace Assets.Kenkyuu.Business.Inventory
{
    public interface Item
    {
        void use(Func<CharacterController, int> change); 
    }
}
