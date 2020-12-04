using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    public interface ICharacter
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }

        public void Attack();
    }
}
