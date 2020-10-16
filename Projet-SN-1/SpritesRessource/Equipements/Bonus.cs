using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SN_1
{
    public enum Bonus_Types
    {
        MULTIPLE_SHOT,
        POWERFUL_SOT,
        BOMB,
        IVINCIBLITY,
        ADD_LIFE,
        ADD_ENERGY
    }


    public class Bonus : Sprite
    {

        public Bonus_Types m_BonusType;

        public void ApplyBonus(SpaceShip p_spaceship)
        {
            switch (m_BonusType)
            {
                case Bonus_Types.MULTIPLE_SHOT:
                    AddEffect6(p_spaceship);
                    break;
                case Bonus_Types.BOMB:
                    AddEffect5(p_spaceship);
                    break;
                case Bonus_Types.POWERFUL_SOT:
                    AddEffect4(p_spaceship);
                    break;
                case Bonus_Types.IVINCIBLITY:
                    AddEffect3(p_spaceship);
                    break;
                case Bonus_Types.ADD_LIFE:
                    AddLife();
                    break;
                case Bonus_Types.ADD_ENERGY:
                    AddEnergy();
                    break;
                default:
                    break;
            }
        }

        private void AddEffect6(SpaceShip p_spaceship) { }
        private void AddEffect5(SpaceShip p_spaceship) { }
        private void AddEffect4(SpaceShip p_spaceship) { }
        private void AddEffect3(SpaceShip p_spaceship) { }
        public void AddLife() { }
        public void AddEnergy() { }
    }
}
