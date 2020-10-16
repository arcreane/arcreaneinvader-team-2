
﻿using System;
using System.Collections.Generic;
using System.Linq;
using Projet_SN_1;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography.X509Certificates;

namespace Projet_SN_1
{
    public class Projectile : Sprite
    {
        public Projectile(Sprite x, Sprite y)
        {
            Fire shoot = new Fire(x,y);
        }
        void Fire(Enemy p_enemy)
        {

        }
        void Fire(SpaceShip p_SpaceShip)
        { 
        }
        void Hit(Sprite p_Sprite)
        {
            //Sprite.Vie -= 1;
            //p_Sprite.Action();
        }
    }
}
