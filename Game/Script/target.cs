using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    /* Function for target
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

        private int x, y, width = 20, height = 10;
        public Rectangle Target;
        public target(Random rand) {
            Generate(rand);
            Target = new Rectangle(x, y, width, height);
            

        }
        public void draw(Graphics g)
        {
            Target.X = x;
            Target.Y = y;
            g.FillRectangle(Brushes.Blue, Target);
        }



        public void Generate(Random rand)
        {
            x = rand.Next(10, 400);
            y = rand.Next(10, 140);


        }

    }
}