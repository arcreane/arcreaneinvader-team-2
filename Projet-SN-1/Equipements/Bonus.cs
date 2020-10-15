using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SN_1
{
    public enum BONUS_TYPE
    {
        Tir_multiple,
        Tir_Puissant,
        Bombe,
        Invincibilite,
        Vie_Supplementaire,
        Energie_Supplementaire
    }


    class Bonus
    {

        public BONUS_TYPE m_BonusType;

        public void ApplyBonus(Spaceship p_spaceship)
        {
            switch(m_BonusType)
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
                    AddEffect5(p_spaceship);
                    break;
                case BONUS_TYPE.Energie_Supplementaire:
                    AddEffect6(p_spaceship);
                    break;
                default:
                    break;
            }
        }

        private void AddEffect6(Spaceship p_spaceship) { }
        private void AddEffect5(Spaceship p_spaceship) { }
        private void AddEffect4(Spaceship p_spaceship) { }
        private void AddEffect3(Spaceship p_spaceship) { }
        private void AddEffect2(Spaceship p_spaceship) { }
        private void AddEffect1(Spaceship p_spaceship) { }
    }
}
