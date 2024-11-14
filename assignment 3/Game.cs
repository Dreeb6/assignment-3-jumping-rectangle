// Include code libraries you need below (use the namespace).
using System;
using System.Drawing;
using System.Numerics;
using System.Transactions;
using static System.Net.Mime.MediaTypeNames;


// The namespace your code is in.
namespace Game10003
{


    /// <summary>    
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // variables are here
        Player player;
        Orb orb;
        float x;
        float radius = 50;
        float speed = 200;

        bool hasCollided = false;
        bool hasCollidedright;
        bool hasCollidedbottom;
        public int score;


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            //setting the window size and declaring the player and orb
            Window.SetSize(800, 600);
            Window.SetTitle("Autoscroller");
            player = new Player();
            orb = new Orb();
            //Window.ClearBackground(Color.OffWhite);
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            //Getting collision to work was the greatest challenge

            //Collision script
            //check horizontally
            bool hasCollidedright = player.playerRightEdge >= orb.orbLeftEdge && orb.orbRightEdge >= player.playerLeftEdge;
            //check vertically
            bool hasCollidedbottom = player.playerBottomEdge >= orb.orbTopEdge;
            
            //checks if both bools are active
            hasCollided = hasCollidedright && hasCollidedbottom;
            
            

            Window.ClearBackground(Color.OffWhite);
            player.DrawPlayer();

            orb.DrawOrb();
            

            if (hasCollided== false)
            {
                //cirle is leftover from testing, I used it to tell if collision was working
                Draw.Circle(700, 500, 10);
                //draw the current score
                Text.Draw($"Current score: {orb.score}", 300, 500);



            }
            //closes the program on a game over
            if (hasCollided == true && Time.SecondsElapsed > 1)
            {
                System.Environment.Exit(0);
            }
        }
    }
}
