using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Game
{
    class MovingObject
    {
        /// <summary>3
        /// /dasdas
        /// </summary>
        private int movingObstacleX, movingObstacleY, width = 20, height = 10;
        private int movingObstacleX2, movingObstacleY2;
        private int movingObstacleX3, movingObstacleY3; 
        public Rectangle movingObstacle;
        public Rectangle movingObstacle2;
        public Rectangle movingObstacle3;
        public MovingObject(Random Rand)
        {
            Spawn(Rand);
            movingObstacle = new Rectangle(movingObstacleX, movingObstacleY, width, height);
            movingObstacle2 = new Rectangle(movingObstacleX2, movingObstacleY2, width, height);
            movingObstacle3 = new Rectangle(movingObstacleX3, movingObstacleY3, width, height);


        }
    
    public void draw(Graphics g)
    {
            g.FillRectangle(Brushes.Brown, movingObstacle);
            g.FillRectangle(Brushes.Brown, movingObstacle2);
            g.FillRectangle(Brushes.Brown, movingObstacle3);
        }
        public void Spawn(Random Rand)
        {
            movingObstacleX = Rand.Next(0,460);
            movingObstacleY = Rand.Next(0,140);
            movingObstacleX2 = Rand.Next(0, 460);
            movingObstacleY2 = Rand.Next(0, 140);
            movingObstacleX3 = Rand.Next(0, 460);
            movingObstacleY3 = Rand.Next(0, 140);

        }
        public void Moving(Random Speed, int Obstacledirection)
        {
            switch (Obstacledirection)
            {
                case 0:
                    int speedValue = Speed.Next(5, 20);
                    movingObstacle.X -= speedValue;
                    // Obstacle 2
                    int speedValue3 = Speed.Next(5, 20);
                    movingObstacle2.X -= speedValue3;
                    // obstacle 3
                    int speedValue5 = Speed.Next(5, 20);
                    movingObstacle3.X -= speedValue5;
                    break;
                case 1:
                    int speedValue2 = Speed.Next(5, 20);
                    movingObstacle.X += speedValue2;
                    //obstacle 2
                    int speedValue4 = Speed.Next(5, 20);
                    movingObstacle2.X += speedValue4;
                    //obstacle 3
                    int speedValue6 = Speed.Next(5, 20);
                    movingObstacle3.X += speedValue6;
                    break;
            
            }
        }
    }
}

