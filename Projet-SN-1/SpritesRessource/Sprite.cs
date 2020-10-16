using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SN_1
{
    public enum Sprite_Type
    {
        BOSS,
        PAWN,
        PROJECTILE,
        BONUS,
        PROTECTION,
        SPACESHIP
    }
    public struct Position
    {

        public Position(int x, int y) : this()
        {
            X = x;
            Y = y;
        }

        public int X{ get; set; }
        public int Y { get; set; }

    }
    public abstract class Sprite
    {
        public int Max_Wall = 50; // Sera definit avec interface
        public Position PositionSprite { get; set; }

        public Sprite(Position p)
        {
            PositionSprite = p;
             
        }

        //public abstract void Set_Position(Sprite p_SpriteSetPosition);// Definir le quel Sprite doit etre Deplacer et Ou X,Y
        //public abstract void Destroy(Sprite p_SpriteToDestroy);// Definir le quel Sprite doit etre detruit

        //public abstract void Shoot(Sprite p_SpriteWhoShoot);//Definir le missile d'ou il est envoyé et de quel direction il va

        //public abstract void HitBox(Sprite p_SpriteHitBox); //Definir la zone ou le sprite est considerer comme "toucher"


    }
}

