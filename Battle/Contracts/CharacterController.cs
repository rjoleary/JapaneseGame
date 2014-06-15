using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Assets.Kenkyuu.Battle.Properties;
using Assets.Kenkyuu.Inventory.Contracts;

namespace Assets.Kenkyuu.Battle.Contracts
{
    public interface CharacterController
    {
        void Equip(Equipable i);
        void UpdateStatus(Status status);
        List<Statistic> GainExperience(List<TomeExperience> exp);
        void UseItem(Item item);
        void Attack(CharacterController c);
        void TakeDamage(Statistic s);
    }
}
