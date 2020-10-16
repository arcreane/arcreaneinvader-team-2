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
                case BONUS_TYPE.Tir_multiple:
                    AddEffect1(p_spaceship);
                    break;
                case BONUS_TYPE.Bombe:
                    AddEffect2(p_spaceship);
                    break;
                case BONUS_TYPE.Tir_Puissant:
                    AddEffect3(p_spaceship);
                    break;
                case BONUS_TYPE.Invincibilite:
                    AddEffect4(p_spaceship);
                    break;
                case BONUS_TYPE.Vie_Supplementaire:
                    AddLife();
                    break;
                case BONUS_TYPE.Energie_Supplementaire:
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
