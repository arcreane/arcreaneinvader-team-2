
﻿using System;
using System.Collections.Generic;
using System.Linq;

using Projet_SN_1;

using System.Text;
using System.Threading.Tasks;

namespace Projet_SN_1
{
    class Projectile : Sprite
    {

        void Tire(Enemy p_enemy)
        {

        }
        void Tire(SpaceShip p_SpaceShip)
        { 
        }
        void Contact(Sprite p_Sprite)
        {
            //Sprite.Vie -= 1;
            //p_Sprite.Action();
        }
    }
}
