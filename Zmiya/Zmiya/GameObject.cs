using System;
using System.Collections.Generic;
namespace Zmiya
{
    public class GameObject
    {
        public List<Point> Body;
        public char sign;
        public ConsoleColor color;
        public GameObject(int x, int y, char sign, ConsoleColor color)
        {
            Body = new List<Point> 
            {
            new Point(x, y)
            };
            this.sign = sign;
            this.color = color;
        }
        public void Draw()
        {
            Console.ForegroundColor = color;
            foreach(Point p in Body)
            {
                Console.SetCursorPosition(p.x, p.y);
                Console.Write(sign);
            }
        }
        public bool IsCollisionWith(GameObject obj)
        {
           foreach(Point p in obj.Body)
            {
                if (Body[0].x == p.x && Body[0].y == p.y)
                    return true;
            }
            return false;
        }
    }
}
