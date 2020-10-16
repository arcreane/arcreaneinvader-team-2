using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SN_1
{
    public class Spaceship
    {
         public Bonus m_Bonus;

        internal Spaceship()
        {
            m_Bonus = new Bonus(Bonus_Types.IVINCIBLITY);
        }

        internal void Move(Spaceship p_SpaceshipToMove) { }
        internal void Shoot(Projectile p_ProjectileToShoot) { }
        internal void ApplyDamagesToEnnemy(Sprite p_SpriteToApplyDamage) { }
        internal void ReceiveDamage(Sprite p_SpriteToApplyDamage) { }
    }
}
