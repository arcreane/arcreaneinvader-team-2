using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SN_1
{
    public class SpaceShip : Sprite
    {
        public bool bIsDead = false;
        public string sSkin = "!_oZo_!";
        public Scene GameLoop { get; set; }
        public int MultipleShot { get; private set; }

        public Bonus m_Bonus;

        internal SpaceShip()
        {
            m_Bonus = new Bonus();
        }
        public void Move(Sprite p_SpriteToMove)
        {
            //Si flèche gauche => déplacer gauche
            //Si flèche droite => déplacer droite
        }

        internal void ActivateMultipleSHot()
        {
            MultipleShot = 2;
        }

        public void Shoot()
        {
            GameLoop.Add(new Projectile(Position.X,Position.Y));

            for (int i = 0;i < MultipleShot; i++)
            {
                GameLoop.Add(new Projectile(Position.X+i, Position.Y));
                GameLoop.Add(new Projectile(Position.X-i, Position.Y));
            }
        }
        //public override void ApplyDamagesToEnnemy(Sprite p_SpriteToApplyDamage) { // }
        //public override void ReceiveDamage(Sprite p_SpriteToApplyDamage) { // }
    }
}