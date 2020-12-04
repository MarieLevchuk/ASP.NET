using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IBoss: ICharacter
    {
        public string Class { get; set; }
    }
}
