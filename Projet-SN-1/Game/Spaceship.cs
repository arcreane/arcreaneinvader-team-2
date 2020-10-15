using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SN_1
{
    public class Spaceship : Sprite
    {
        public bool bIsDead = false;
        public string sSkin = "!_oZo_!";

        public Projectile m_Projectile;

        public override void Move(Sprite p_SpriteToMove) { }
        public override void Shoot(Projectile p_ProjectileToShoot) { }
        public override void ApplyDamagesToEnnemy(Sprite p_SpriteToApplyDamage) { }
        public override void ReceiveDamage(Sprite p_SpriteToApplyDamage) { }
    }
}
