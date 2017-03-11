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
        /// <summary>
        /// This is the Player class, the player held the movement
        /// 
        /// </summary>
        private int x = 464/2, y = 200, width = 10, height = 25;
        public Rectangle player;
        
         
              
          public Player() {
            player = new Rectangle(x, y, width, height);
       
        }
       
        


        public void draw(Graphics g)
        {
          
            g.FillRectangle(Brushes.Green, player);
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
