using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class Bullet
    {
        /// <summary>3
        /// this is bullet class, it like player class but it has its limit 
        /// </summary>
        private int x = 514/2, y = 360, width = 10, height = 20;
        public Rectangle bullet;
        public Bullet()
        {
            bullet = new Rectangle(x, y, width, height);

        }
        public void Draw(Graphics g)
        {
            g.FillRectangle(Brushes.White, bullet);
        }
        public void bulletMove(int bulletFly)
        {

            switch (bulletFly)
            {
                case 0: // Go Right
                    bullet.X += 15;

                    break;
                case 1:// Go Left
                    bullet.X -= 15;


                    break;
                case 2: //Go up
                    bullet.Y -= 30;
                    break;

                default:
                    break;

            }
        }

    }
}
