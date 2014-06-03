using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Business.Definitions;

namespace Assets.Kenkyuu.Business.Properties
{
    public class Experience
    {
        public ExperienceType Type
        {
            get;
            set;
        }
        public int? points
        {
            get;
            set;
        }

        public int? Uses
        {
            get;
            set;
        }

        public int? CorrectUses
        {
            get;
            set;
        }

    }
}
