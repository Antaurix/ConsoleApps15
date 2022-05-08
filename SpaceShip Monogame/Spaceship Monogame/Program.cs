namespace Spaceship_Monogame
{
    public class program
    {
        public static void Main(string[] args)
        {
            using(Game1 game = new Game1())
            {
                game.Run();
            }
        }
    }
}