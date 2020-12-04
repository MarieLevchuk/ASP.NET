using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IPlayer: ICharacter, IWeapon
    {
        public string GuildName { get; set; }   
    }
}
