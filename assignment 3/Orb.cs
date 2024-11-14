using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

// The namespace your code is in.
namespace Game10003
{

    public class Orb
    {
        
        //declaring variables
        public float orbLeftEdge;
        public float orbRightEdge;
        public float orbTopEdge;
        public float orbBottomEdge;
        public int score;

        
        float radius = 50;
        float speed = -200;
        public Vector2 position= new Vector2(700,380);
        public void DrawOrb()
        {
            orbLeftEdge = position.X-75;
            orbRightEdge = position.X + 75;
            orbTopEdge = position.Y - 75;
            orbBottomEdge = position.Y + 100;

            position.X += Time.DeltaTime * speed;
            Draw.LineSize = 3;
            Draw.LineColor = Color.Red;
            Draw.Circle(position, radius);

            //resets the orb's position and sets a random new speed
            if (position.X <= 0)
            {
                position.X = 800;
                speed = Random.Float(-300, -125);
                //increase score
                score++;
            }

        }



    }
}