using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Spaceship_Monogame
{
    internal class Asteroid
    {
        public Vector2 position;
        public int speed;
        public int radius = 59;
        public bool offscreen = false;

        static Random rand = new Random();

        public Asteroid(int newSpeed)
        {
            speed = newSpeed;
            position = new Vector2(1920+radius,rand.Next(0,721));
        }

        public void asteroidUpate(GameTime gameTime)
        {
            float dt = (float)gameTime.ElapsedGameTime.TotalSeconds;
            position.X -= speed * dt;
        }
    }
}
