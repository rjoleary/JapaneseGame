using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Battle.Contracts;
using Assets.Kenkyuu.Battle;

namespace Assets.Kenkyuu.GameState
{
    public class PartyState
    {
        private static PartyState instance = null;
        private static readonly object padlock = new object();
        private static List<CharacterController> party = new List<CharacterController>();
        private static ICharacterFactory factory = new CharacterFactory();

        public static void NewGame(){
            party.Add(factory.MakeMainCharacter());
        }

        public static PartyState Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new PartyState();
                    return instance;
                }
            }
        }
    }
}
