using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class extraBullet
    {
        private int x, y, width = 40, height = 40;
        public Rectangle theRock;
        private Image newRock;
        private Random Spawn = new Random();
        public int randomSpawn;
        //public readonly int _randomSpawn;

      
        public extraBullet(Random rand) {
            randomSpawn = Spawn.Next(0, 50);
            //_randomSpawn = randomSpawn;
            generate(rand);
            theRock = new Rectangle(x, y, width, height);
            
                newRock = Game.Properties.Resources.Rock;
          
        }
       public void Draw(Graphics g)
        {
         
            theRock.X = x;
            theRock.Y = y;
            if (randomSpawn <= 10)
            {
                g.DrawImage(newRock, theRock);
            }

        }
        public void generate(Random rand)
        {
            int positionX = rand.Next(50,700);
            int positionY = rand.Next(0,250);
            x = positionX;
            y = positionY;

        }

    }
}
