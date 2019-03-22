using System;
namespace Zmiya
{
    public class Food:GameObject
    {
        public Food(int x, int y, char sign, ConsoleColor color):base(x, y, sign, color)
        {

        }
        public void Generate()
        {
            Random random = new Random();
            int x = random.Next(1, Console.WindowWidth);
            int y = random.Next(1, Console.WindowHeight);
            Body[0].x = x;
            Body[0].y = y;
        }
    }
}
