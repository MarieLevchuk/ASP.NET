using System;

namespace Game
{
    public class Player: ICharacter, IWeapon
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int Damage { get; set; }

        public void Attack()
        {
            //some code
        }
        /*Здесь применяется четвертый из принципов SOLID - разделение интерфейсов*/
    }
}
