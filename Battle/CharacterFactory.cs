using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Battle.Contracts;

namespace Assets.Kenkyuu.Battle
{
    public class CharacterFactory : ICharacterFactory

    {
        public CharacterController MakeMainCharacter() {
            return new MainCharacter();
        }

        public CharacterController MakeCharacter() {
            return new Character();
        }
    }
}
