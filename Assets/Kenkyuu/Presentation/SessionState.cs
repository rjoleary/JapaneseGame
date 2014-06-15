using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Business;

namespace Kenkyuu.Presentation
{
    public class SessionState
    {
        private static SessionState instance = null;
        private static readonly object padlock = new object();
        private static List<Character> party;
        SessionState()
        {
            //new game options
        }

        public static SessionState Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new SessionState();
                    return instance;
                }
            }
        }
    }
}
