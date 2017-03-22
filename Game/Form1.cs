using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{





    public partial class Linear : Form
    {

        // Wow Bunch of variables

        private int ammunition = 1;
        private int ammunitionHolder = 3;
        private bool ammunitionCondition = true;
        private int bulletFire = 0;
        private int score = 0;
        private int direction = 0;
        private Random rand = new Random();
        private Graphics g;
        private target Target;
        private obstacle Obstacle;
        private Player p;
        private Timer gameLoop = new Timer();
        private Bullet b;
        private bool reload = true;
        private bool drawingObject = false;
        private MovingObject movingObject;
        private Random Speed = new Random();
        private int obstacleDirection = 1;
        private extraBullet extrabullet;
       
     
        public Linear()
        {
            // Call the object
            InitializeComponent();
            extrabullet = new extraBullet(rand);
            Target = new target(rand);
            Obstacle = new obstacle(rand);
            p = new Player();
            gameLoop.Interval = 100;
            gameLoop.Tick += Update;
            b = new Bullet();
            movingObject = new MovingObject(rand);

      
    }
      
        private void Linear_keyDown(Object sender, KeyEventArgs e)
        {
            // Player Input Key

            switch (e.KeyData)
            {
              
                case Keys.Enter:
                    if (author_lbl.Visible)
                    {
                        author_lbl.Visible = false;
                    }
                    if (win_lbl.Visible)
                    {
                        win_lbl.Visible = false;
                    }
                   
                    if (author_lbl.Visible)
                    {
                        author_lbl.Visible = false;
                    }
                    if (!score_lbl.Visible)
                    {
                        score_lbl.Visible = true;
                    }
                    if (title_label.Visible)
                    {
                        title_label.Visible = false;
                    }
                    if (!ammunition_lbl.Visible)
                    {
                        ammunition_lbl.Visible = true;
                    }
                    if (!score_hold.Visible)
                    {
                        score_hold.Visible = true;
                    }
                    drawingObject = true;
                    gameLoop.Start();
                 
                    break;
                case Keys.P:
                    if (!author_lbl.Visible)
                        author_lbl.Visible = (author_lbl.Visible) ? true : false;
                    gameLoop.Stop();
                    break;
                case Keys.Space:
                  
                    if (ammunitionCondition)
                    {
                        if (ammunition <= 0)
                        {
                            ammunition = 0;
                            ammunitionHolder = 0;
                            ammunitionCondition = false;
                            
                        }
                        
                            if (ammunition > 0)
                            {
                                reload = true;
                                bulletFire = 2;
                            }else if(ammunition <= 0)
                            {
                                reload = false;
                            }
                            ammunition = ammunition - ammunition;

                            if (ammunitionHolder > 0)
                            {
                                if (reload)
                                {
                                 
                                    ammunition = ammunition + 1;
                                    ammunitionHolder = ammunitionHolder - 1;
                                    
                                }
                               
                            
                        

                        }
                      
                        if (ammunition <= 0)
                        {
                            ammunition = 0;
                            ammunitionCondition = false;
                           
                        }
                       
                    }
                   
               
                    break;
                case Keys.Up:
                    if (!ammunitionCondition)
                    {
                        bulletFire = 2;
                    }
                    bulletFire = 2;
                    direction = 2;
                    break;
                case Keys.Left:

                    if (bulletFire != 2)
                    {
                        bulletFire = 1;
                    }
                    if (direction != 2)
                    {
                        direction = 1;
                    }
                    break;
                case Keys.Right:


                    if (bulletFire != 2)
                    {
                        bulletFire = 0;
                    }


                    if (direction != 2)
                    {
                        direction = 0;
                    }
                    break;
               

            }
           

        }

        private void Linear_Paint(Object sender, PaintEventArgs e)
        {
            //for bonus bullet
          
            g = this.CreateGraphics();

            if (drawingObject)
            {
                
                Target.draw(g);
                Obstacle.draw(g);
                b.Draw(g);
                p.draw(g, direction);
                extrabullet.Draw(g);
              
                if (score > 20)
                {
                    movingObject.draw(g);
                }
                
            }
          

        }
      

        private void Update(Object sender, EventArgs e)
        {

            
            ammunitionCondition = true;
            ammunition_lbl.Text = String.Format("{0}/{1}", ammunition, ammunitionHolder);
            score_hold.Text = String.Format("{0}", score);
            b.bulletMove(bulletFire);
            p.movement(direction);
            movingObject.Moving(Speed, obstacleDirection);

            // moving obstacle 1

            if (movingObject.movingObstacle.X < 10 || movingObject.movingObstacle2.X < 10 || movingObject.movingObstacle3.X < 10)
            {
                obstacleDirection = 1;
            }
            if (movingObject.movingObstacle.X > 818 || movingObject.movingObstacle.Y > 514)
            {
                obstacleDirection = 0;
            }
           

            if (p.player.IntersectsWith(Obstacle.obstacle1)
                || p.player.IntersectsWith(Obstacle.obstacle2)
                    || p.player.IntersectsWith(Obstacle.obstacle3)
                        || p.player.IntersectsWith(Obstacle.obstacle4)
                         || p.player.IntersectsWith(Obstacle.obstacle5)
                          || p.player.IntersectsWith(Obstacle.obstacle6)
                           || p.player.IntersectsWith(Obstacle.obstacle7)
                            || p.player.IntersectsWith(Obstacle.obstacle8)
                            )
            {
                Restart();
            }
            if(score > 20)
            {
                  if(p.player.IntersectsWith(movingObject.movingObstacle)
                                || p.player.IntersectsWith(movingObject.movingObstacle2)
                                  || p.player.IntersectsWith(movingObject.movingObstacle3))
                {
                    Restart();
                }
            }
            if(b.bullet.Y < 350)
            {
                ammunitionCondition = false;
            }

            if (p.player.Y < 0 || p.player.X > 818 || p.player.X < 0)
            {
                Restart();
            }
            //1
            if(Obstacle.obstacle1.IntersectsWith(Obstacle.obstacle2)
                ||
                Obstacle.obstacle1.IntersectsWith(Obstacle.obstacle3)
                ||
                Obstacle.obstacle1.IntersectsWith(Obstacle.obstacle4)
                ||
                Obstacle.obstacle1.IntersectsWith(Obstacle.obstacle5)
                ||
                Obstacle.obstacle1.IntersectsWith(Obstacle.obstacle6)
                ||
                 Obstacle.obstacle1.IntersectsWith(Obstacle.obstacle7)
                ||
                 Obstacle.obstacle1.IntersectsWith(Obstacle.obstacle8)
                ||
                Obstacle.obstacle1.IntersectsWith(Target.Target)
                )
            {

                Obstacle = new obstacle(rand);
            }
            //2
            if (Obstacle.obstacle2.IntersectsWith(Obstacle.obstacle1)
           ||
           Obstacle.obstacle2.IntersectsWith(Obstacle.obstacle3)
           ||
           Obstacle.obstacle2.IntersectsWith(Obstacle.obstacle4)
           ||
           Obstacle.obstacle2.IntersectsWith(Obstacle.obstacle5)
           ||
           Obstacle.obstacle2.IntersectsWith(Obstacle.obstacle6)
           ||
            Obstacle.obstacle2.IntersectsWith(Obstacle.obstacle7)
           ||
            Obstacle.obstacle2.IntersectsWith(Obstacle.obstacle8)
              ||
                Obstacle.obstacle2.IntersectsWith(Target.Target)
           )
            {

                Obstacle = new obstacle(rand);
            }
            //3
            if (Obstacle.obstacle3.IntersectsWith(Obstacle.obstacle1)
           ||
           Obstacle.obstacle3.IntersectsWith(Obstacle.obstacle2)
           ||
           Obstacle.obstacle3.IntersectsWith(Obstacle.obstacle4)
           ||
           Obstacle.obstacle3.IntersectsWith(Obstacle.obstacle5)
           ||
           Obstacle.obstacle3.IntersectsWith(Obstacle.obstacle6)
           ||
            Obstacle.obstacle3.IntersectsWith(Obstacle.obstacle7)
           ||
            Obstacle.obstacle3.IntersectsWith(Obstacle.obstacle8)
              ||
                Obstacle.obstacle3.IntersectsWith(Target.Target)
           )
            {

                Obstacle = new obstacle(rand);
            }
            //4
            if (Obstacle.obstacle4.IntersectsWith(Obstacle.obstacle1)
           ||
           Obstacle.obstacle4.IntersectsWith(Obstacle.obstacle2)
           ||
           Obstacle.obstacle4.IntersectsWith(Obstacle.obstacle3)
           ||
           Obstacle.obstacle4.IntersectsWith(Obstacle.obstacle5)
           ||
           Obstacle.obstacle4.IntersectsWith(Obstacle.obstacle6)
           ||
            Obstacle.obstacle4.IntersectsWith(Obstacle.obstacle7)
           ||
            Obstacle.obstacle4.IntersectsWith(Obstacle.obstacle8)
              ||
                Obstacle.obstacle4.IntersectsWith(Target.Target)
           )
            {

                Obstacle = new obstacle(rand);
            }

            //5
            if (Obstacle.obstacle5.IntersectsWith(Obstacle.obstacle2)
           ||
           Obstacle.obstacle5.IntersectsWith(Obstacle.obstacle3)
           ||
           Obstacle.obstacle5.IntersectsWith(Obstacle.obstacle4)
           ||
           Obstacle.obstacle5.IntersectsWith(Obstacle.obstacle1)
           ||
           Obstacle.obstacle5.IntersectsWith(Obstacle.obstacle6)
           ||
            Obstacle.obstacle5.IntersectsWith(Obstacle.obstacle7)
           ||
            Obstacle.obstacle5.IntersectsWith(Obstacle.obstacle8)
              ||
                Obstacle.obstacle5.IntersectsWith(Target.Target)
           )
            {

                Obstacle = new obstacle(rand);
            }


            //6
            if (Obstacle.obstacle6.IntersectsWith(Obstacle.obstacle2)
           ||
           Obstacle.obstacle6.IntersectsWith(Obstacle.obstacle3)
           ||
           Obstacle.obstacle6.IntersectsWith(Obstacle.obstacle4)
           ||
           Obstacle.obstacle6.IntersectsWith(Obstacle.obstacle5)
           ||
           Obstacle.obstacle6.IntersectsWith(Obstacle.obstacle1)
           ||
            Obstacle.obstacle6.IntersectsWith(Obstacle.obstacle7)
           ||
            Obstacle.obstacle6.IntersectsWith(Obstacle.obstacle8)
              ||
                Obstacle.obstacle6.IntersectsWith(Target.Target)
           )
            {

                Obstacle = new obstacle(rand);
            }

            //7
            if (Obstacle.obstacle7.IntersectsWith(Obstacle.obstacle2)
           ||
           Obstacle.obstacle7.IntersectsWith(Obstacle.obstacle3)
           ||
           Obstacle.obstacle7.IntersectsWith(Obstacle.obstacle4)
           ||
           Obstacle.obstacle7.IntersectsWith(Obstacle.obstacle5)
           ||
           Obstacle.obstacle7.IntersectsWith(Obstacle.obstacle6)
           ||
            Obstacle.obstacle7.IntersectsWith(Obstacle.obstacle1)
           ||
            Obstacle.obstacle7.IntersectsWith(Obstacle.obstacle8)
              ||
                Obstacle.obstacle7.IntersectsWith(Target.Target)
           )
            {

                Obstacle = new obstacle(rand);
            }

            //8
            if (Obstacle.obstacle8.IntersectsWith(Obstacle.obstacle2)
           ||
           Obstacle.obstacle8.IntersectsWith(Obstacle.obstacle3)
           ||
           Obstacle.obstacle8.IntersectsWith(Obstacle.obstacle4)
           ||
           Obstacle.obstacle8.IntersectsWith(Obstacle.obstacle5)
           ||
           Obstacle.obstacle8.IntersectsWith(Obstacle.obstacle6)
           ||
            Obstacle.obstacle8.IntersectsWith(Obstacle.obstacle7)
           ||
            Obstacle.obstacle8.IntersectsWith(Obstacle.obstacle1)
              ||
                Obstacle.obstacle8.IntersectsWith(Target.Target)
           )
            {

                Obstacle = new obstacle(rand);
            }

            if (p.player.IntersectsWith(extrabullet.theRock))
            {
                if (extrabullet.randomSpawn <= 10)
                {
                    extrabullet.randomSpawn = 15;
                    ammunitionHolder += 1;
                    p = new Player();
                    b = new Bullet();
                    direction = 0;
                    bulletFire = 0;
                }
               
            }
            if (b.bullet.IntersectsWith(extrabullet.theRock))
            {
                if (extrabullet.randomSpawn <= 10)
                {
                    extrabullet.randomSpawn = 15;
                    ammunitionHolder += 1;
                    ammunition = 1;
                    p = new Player();
                    b = new Bullet();
                    ammunitionCondition = true;
                    direction = 0;
                    bulletFire = 0;
                }
            }






            if (p.player.IntersectsWith(Target.Target) || b.bullet.IntersectsWith(Target.Target))
            {
                score++;
                p = new Player();
                Obstacle = new obstacle(rand);
                Target = new target(rand);
                direction = 0;
                bulletFire = 0;
                b = new Bullet();
                ammunitionCondition = true;
                movingObject = new MovingObject(rand);
                extrabullet = new extraBullet(rand);
            }

            if (score == 50)
            {
                
                if (!win_lbl.Visible)
                {
                    win_lbl.Visible = true;
                    Restart();
                }
            }
            this.DoubleBuffered = true;
            this.Invalidate();    
        }
   
        private void Restart()
        {
            gameLoop.Stop();
            g.Clear(SystemColors.Control);
            Obstacle = new obstacle(rand);
            p = new Player();
            Target = new target(rand);
            score = 0;
            direction = 0;
            b = new Bullet();
            bulletFire = 0;
            ammunition = 1;
            ammunitionHolder = 3;
            drawingObject = false;
            movingObject = new MovingObject(rand);
            extrabullet = new extraBullet(rand);
           
           
         

            if (!win_lbl.Visible)
            {
                ammunition_lbl.Visible = false;
                score_lbl.Visible = false;
                title_label.Visible = true;
                author_lbl.Visible = true;
                score_hold.Visible = false;
            }



        }

        private void Linear_Load(object sender, EventArgs e)
        {

        }
    }
}
