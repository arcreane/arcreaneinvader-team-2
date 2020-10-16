using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Projet_SN_1.Pawn
{
    class Boss
    {
    }
}

namespace Projet_SN_1
{
    public enum Sprites
    {
        BOSS,
        PAWN,
        PROJECTILE,
        BONUS,
        PROTECTION,
        SPACESHIP
    }
    public abstract class Sprite
    {
        public int Max_Wall = 50; // Sera definit avec interface
        public int Wall = 0;
        public int Floor = 0;
        public abstract void Create(Sprite p_SpriteToCreate);// Cree une instance Sprite
        public abstract void Set_Position(Sprite p_SpriteSetPosition);// Definir le quel Sprite doit etre Deplacer et Ou X,Y
        public abstract void Destroy(Sprite p_SpriteToDestroy);// Definir le quel Sprite doit etre detruit

        public abstract void Shoot(Sprite p_SpriteWhoShoot);//Definir le missile d'ou il est envoyé et de quel direction il va

        public abstract void HitBox(Sprite p_SpriteHitBox); //Definir la zone ou le sprite est considerer comme "toucher"

        
    }
}

