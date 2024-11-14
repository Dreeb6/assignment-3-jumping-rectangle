// Include code libraries you need below (use the namespace).
using System;
using System.Data;
using System.Drawing;
using System.Numerics;

// The namespace your code is in.
namespace Game10003
{
    
    public class Player
    {
        // Variables in our code for our player

        
        Vector2 velocity;
        Vector2 point;
        

        public float playerLeftEdge;
        public float playerRightEdge;
        public float playerTopEdge;
        public float playerBottomEdge;
        
        float x = 25;
        float y = 300;
        int Countdown = 0;
        
        //size and position of our retangular player
        public Vector2 size = new Vector2(25, 125);
        public Vector2 position = new Vector2(100,300);
        

        

        public void DrawPlayer()
        {
            
            //Establishing the edges of each side of the player
            playerLeftEdge = position.X;
            playerRightEdge = position.X + size.X;
            playerTopEdge = position.Y;
            playerBottomEdge = position.Y + size.Y;




            Draw.FillColor = Color.Blue;
            //Drawing the player
            Draw.Rectangle(position,size);
           
            //Jumping script
            //The countdown makes it so that the player can't jump again until they touch the ground
            if (Input.IsKeyboardKeyDown(KeyboardInput.Space)&& Countdown <= 0)
            {
                position.Y -= 250;
                Countdown = 140;
            }
            if (position.Y <300) //this is all it took to simulate gravity since the player is the only object affected by it
            {
                position.Y += 100 * Time.DeltaTime;
            }
            if (Countdown > 0) 
            {
                Countdown--;
            }
            
        }
     

    }
}
