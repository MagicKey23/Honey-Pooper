using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    
    class Player
    {
        /// <summary>3
        /// This is the Player class, the player held the movement
        /// 
        /// </summary>

        private Image spriteTop;
        private Image spriteRight;
        private Image spriteLeft;
        private int x = 514/2, y = 360, width = 30, height = 50;
        public Rectangle player;
        
         
              
          public Player() {
            player = new Rectangle(x, y, width, height);
            spriteTop = Game.Properties.Resources.BearTop;
            spriteRight = Game.Properties.Resources.BearRight;
            spriteLeft = Game.Properties.Resources.Bearleft;
        }




        public void draw(Graphics g, int direction)
        {

            //g.FillRectangle(Brushes.Green, player);
            switch (direction) {
                case 0:
            g.DrawImage(spriteRight, player);
                    break;
                case 1:
            g.DrawImage(spriteLeft, player);
                    break;
                case 2: 
            g.DrawImage(spriteTop, player);
                    break;
        }
        }
        public void movement(int direction)
        {
            
            switch (direction)
            {
                case 0: // Go Right
                    player.X += 15;
                   
                    break;
                case 1:// Go Left
                    player.X -= 15;
                  
                 
                    break;
                case 2: //Go up
                    player.Y -= 30;
                    break;
                
                default:
                    break;

            }

        }


    }
    

}
