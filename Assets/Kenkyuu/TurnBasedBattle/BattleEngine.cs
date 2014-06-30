using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Battle.Contracts;

namespace Assets.Kenkyuu.TurnBasedBattle
{
    class BattleEngine
    {
        private List<CharacterController> enemies;
        private List<CharacterController> team;
        public BattleEngine(List<CharacterController> team, List<CharacterController> enemies) {
            this.team = team;
            this.enemies = enemies;
        }
        void Start() {
        
        }
    }
}
