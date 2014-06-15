using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Kenkyuu.Battle.Contracts
{
    public interface ICharacterFactory
    {
        CharacterController MakeMainCharacter();

        CharacterController MakeCharacter();


    }
}
