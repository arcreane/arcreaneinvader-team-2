using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;
using System.Threading.Tasks;

namespace Projet_SN_1
{

   public class Scene
    {
        public Scene()
        {
            int NumberOfEnemies =  10 * (new Menu().Difficulty);//Recupere la difficulty
            int X = 200, Y = 200; // le plus haut a droite
            for (int i = 0; i < NumberOfEnemies; i++)
            {
                //Sprite sprite = new Sprite.Create(Pawn);
                //sprite.Position = [X,Y];
                X -= 1;
                if (X < 0)
                {
                    X = 200;
                    Y -= Y;
                }
            }
            int NumberOfProtections = 6 / ((new Menu().Difficulty)+1);
            for (int a = 0; a < NumberOfProtections; a++)
            {
                Y = 20;
                X = 200;
                int Pose = X / NumberOfProtections;
                //Sprite sprite = new Sprite.Create(Protection);
                //sprite.Position = [X,Y];
                X -= Pose;
            }
            //SpaceShip spaceShip = SpaceShip.Debut();
            // temps qu'il y a des pawns attends ici
            //Sprite sprite = new Sprite.Create(Boss)
            //Attend ici le boss
            // Gagne la partie
        }

        internal void Add(Projectile projectile)
        {
            
        }
        //public abstract void Create(Sprite p_SpriteToCreate);// Cree une instance Sprite
    }
}
