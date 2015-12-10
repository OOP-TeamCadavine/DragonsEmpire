using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPG_Game.Interfaces
{
    public interface ICharacter : IAttack, IDefense
    {
        int HealthPoints { get; set; }

        int DefensePoints { get; set;}

        int AttackPoints { get; set;}

        Point Position { get; }
    }
}
