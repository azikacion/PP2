using System;
namespace Zmiya
{
    public class Snake:GameObject
    {
        enum Direction
        {
            UP, DOWN, LEFT, RIGHT, NONE
        }
        Direction direction = Direction.NONE;
        public Snake(int x, int y, char sign, ConsoleColor color):base(x, y, sign, color)
        {

        }
        public void Move()
        {
            if (direction == Direction.NONE)
                return;
            for(int i = Body.Count-1; i>0; i--)
            {
                Body[i].x = Body[i - 1].x;
                Body[i].y = Body[i - 1].y;
            }
            if(direction == Direction.DOWN)
            {
                Body[0].y++;
            }
            if(direction == Direction.UP)
            {
                Body[0].y--;
            }
            if(direction == Direction.LEFT)
            {
                Body[0].x--;
            }
            if(direction == Direction.RIGHT)
            {
                Body[0].x++;
            }
        }
        public void ChangeDirection(ConsoleKeyInfo keyInfo)
        {
            if (keyInfo.Key == ConsoleKey.UpArrow)
            {
                direction = Direction.UP;
            }
            if (keyInfo.Key == ConsoleKey.DownArrow)
            {
                direction = Direction.DOWN;
            }
            if (keyInfo.Key == ConsoleKey.LeftArrow)
            {
                direction = Direction.LEFT;
            }
            if (keyInfo.Key == ConsoleKey.RightArrow)
            {
                direction = Direction.RIGHT;
            }
        }
    }
}
