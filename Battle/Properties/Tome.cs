using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Kenkyuu.Battle.Properties
{
    public class Tome
    {
        private int maxLevel;
        private int curLevel;
        private List<string> word;
        public int Mastery
        {
            get { return Mastery; }
        }

        public int Repetition
        {
            get { return Mastery; }
        }

        public bool IsUsedInRecentBattle { get; set; }
    }
}
