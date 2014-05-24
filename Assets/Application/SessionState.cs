using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Game.Application
{
    class SessionState
    {
        private static SessionState instance = null;
        private static readonly object padlock = new object();

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
