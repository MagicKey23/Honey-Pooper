using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    /* Function for target3
     * Generate() random position when game start
     * Draw() the target
     * 
     * 
     */


    class target
    {
        /// <summary>
        ///  Construct Target, for player to hit to receive the point
        ///  the target spawn at random position when it called by main function
        /// </summary>
        Image Honey;
        private int x, y, width = 40, height = 40;
        public Rectangle Target;
        public target(Random rand) {
            Honey = Game.Properties.Resources.Honey;
            Generate(rand);
            Target = new Rectangle(x, y, width, height);
            

        }
        public void draw(Graphics g)
        {
            Target.X = x;
            Target.Y = y;
            //g.FillRectangle(Brushes.Blue, Target);
            g.DrawImage(Honey, Target);
        }



        public void Generate(Random rand)
        {
            x = rand.Next(10, 400);
            y = rand.Next(10, 140);


        }

    }
}