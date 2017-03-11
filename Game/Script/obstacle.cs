using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Game
{
    class obstacle
    {
        /// <summary>3
        /// Obstacle this is how player going to lose, if they hit these obstacle they lose the game
        /// The obstacle also spawn randomly in the game
        /// </summary>
        
        private int width = 5, height = 5;
        private int obstacle1X, obstacle1Y;
        private int obstacle2X, obstacle2Y;
        private int obstacle3X, obstacle3Y;
        private int obstacle4X, obstacle4Y;
        private int obstacle5X, obstacle5Y;
        private int obstacle6X, obstacle6Y;
        private int obstacle7X, obstacle7Y;
        private int obstacle8X, obstacle8Y;

        public Rectangle obstacle1;
        public Rectangle obstacle2;
        public Rectangle obstacle3;
        public Rectangle obstacle4;
        public Rectangle obstacle5;
        public Rectangle obstacle6;
        public Rectangle obstacle7;
        public Rectangle obstacle8;
       

        public obstacle(Random rand) {
            generate(rand);
            obstacle1 = new Rectangle(obstacle1X,obstacle1Y,width,height);
            obstacle2 = new Rectangle(obstacle2X,obstacle2Y,width,height);
            obstacle3 = new Rectangle(obstacle3X,obstacle3Y,width,height);
            obstacle4 = new Rectangle(obstacle4X,obstacle4Y,width,height);
            obstacle5 = new Rectangle(obstacle5X, obstacle5Y, width, height);
            obstacle6 = new Rectangle(obstacle6X, obstacle6Y, width, height);
            obstacle7 = new Rectangle(obstacle7X, obstacle7Y, width, height);
            obstacle8 = new Rectangle(obstacle8X, obstacle8Y, width, height);

        }
        public void draw(Graphics g)
        {
       
            g.FillRectangle(Brushes.Red, obstacle1);
            g.FillRectangle(Brushes.Red, obstacle2);
            g.FillRectangle(Brushes.Red, obstacle3);
            g.FillRectangle(Brushes.Red, obstacle4);
            g.FillRectangle(Brushes.Red, obstacle5);
            g.FillRectangle(Brushes.Red, obstacle6);
            g.FillRectangle(Brushes.Red, obstacle7);
            g.FillRectangle(Brushes.Red, obstacle8);

        }

        public void generate(Random rand)
        {
            obstacle1X = rand.Next(0,464);
            obstacle1Y = rand.Next(0,140);
            obstacle2X = rand.Next(0, 464);
            obstacle2Y = rand.Next(0, 140);
            obstacle3X = rand.Next(0, 464);
            obstacle3Y = rand.Next(0, 140);
            obstacle4X = rand.Next(0, 464);
            obstacle4Y = rand.Next(0, 140);
            obstacle5X = rand.Next(0, 464);
            obstacle5Y = rand.Next(0, 140);
            obstacle6X = rand.Next(0, 464);
            obstacle6Y = rand.Next(0, 140);
            obstacle7X = rand.Next(0, 464);
            obstacle7Y = rand.Next(0, 140);
            obstacle8X = rand.Next(0, 464);
            obstacle8Y = rand.Next(0, 140);
            Random Speed = new Random();
            int flySpeed = Speed.Next(5, 10);
            int flySpeed2 = Speed.Next(5, 10);
            int flySpeed3 = Speed.Next(5, 10);
            int flySpeed4 = Speed.Next(5, 10);

            

            }
        }

    }
       


    
   

