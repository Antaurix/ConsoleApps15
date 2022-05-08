using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;



namespace Spaceship_Monogame
{
    internal class Game1: Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

      
        Texture2D ship_Sprite;
        Texture2D asteroid_Sprite;
        Texture2D space_Sprite;
        SpriteFont gameFont;
        SpriteFont timerFont;

        Ship player = new Ship();
      

        Controller gameController = new Controller();

        public Game1()
        {
             graphics = new GraphicsDeviceManager(this);
             Content.RootDirectory = "Content";
             graphics.PreferredBackBufferWidth = 1280;
             graphics.PreferredBackBufferHeight = 720;
        }

        protected override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            
            spriteBatch = new SpriteBatch(GraphicsDevice);

            ship_Sprite = Content.Load<Texture2D>("Ship");
            asteroid_Sprite = Content.Load<Texture2D>("asteroid118x118");
            space_Sprite = Content.Load<Texture2D>("Space");
            gameFont = Content.Load<SpriteFont>("arial");
            timerFont = Content.Load<SpriteFont>("calibri");
          

        }

        protected override void UnloadContent()
        {
           
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            player.shipUpdate(gameTime,gameController);
            gameController.conUpdate(gameTime);
            for(int i = 0; i < gameController.asteroids.Count; i++)
            {

                gameController.asteroids[i].asteroidUpate(gameTime);

                if(gameController.asteroids[i].position.X < (0 - gameController.asteroids[i].radius))
                {
                    gameController.asteroids[i].offscreen = true;
                }

                int sum = gameController.asteroids[i].radius + 1;
                if(Vector2.Distance(gameController.asteroids[i].position,player.position) < sum)
                {
                    gameController.inGame = false;
                    player.position = Ship.defaultPosition;
                    i = gameController.asteroids.Count;
                    gameController.asteroids.Clear();
                }

            }
            gameController.asteroids.RemoveAll(a => a.offscreen);

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            spriteBatch.Begin();

            
            spriteBatch.Draw(space_Sprite, new Vector2(0, 0), Color.White);
            spriteBatch.Draw(ship_Sprite, new Vector2(player.position.X - 100, player.position.Y - 100), Color.White);

            if(gameController.inGame == false)
            {
                string menuMessage = "Press Enter to Start  !";
                Vector2 sizeOfText = gameFont.MeasureString(menuMessage);
                spriteBatch.DrawString(gameFont, menuMessage,new Vector2(450 - sizeOfText.X/2,300),Color.White);
            }

            for (int i = 0; i < gameController.asteroids.Count; i++)
            {
                Vector2 tempPos = gameController.asteroids[i].position;
                int tempRadius = gameController.asteroids[i].radius;
                spriteBatch.Draw(asteroid_Sprite, new Vector2(tempPos.X - tempRadius, tempPos.Y - tempRadius), Color.White);
            }

                spriteBatch.DrawString(timerFont,"Time: " + Math.Floor(gameController.totalTime).ToString(),
                    new Vector2(3,3),Color.White);

                spriteBatch.End(); 
            base.Draw(gameTime);
        }
    }
}
