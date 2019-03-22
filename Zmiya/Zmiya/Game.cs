using System;
using System.Collections.Generic;
using System.Threading;
namespace Zmiya
{
    public class Game
    {
        List<GameObject> g_Objects;
        public bool IsAlive;
        public Snake snake;
        public Food food;
        public Wall wall;
        public Game()
        {
            g_Objects = new List<GameObject>();
            snake = new Snake(20, 10, '*', ConsoleColor.Cyan);
            food = new Food(0, 0, 'o', ConsoleColor.Green);
            wall = new Wall('#', ConsoleColor.Red);
            wall.LoadLevel();
            while (food.IsCollisionWith(snake) || food.IsCollisionWith(wall))
                food.Generate();

            g_Objects.Add(snake);
            g_Objects.Add(food);
            g_Objects.Add(wall);

            IsAlive = true;
        }
        public void Start()
        {
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            Thread thread = new Thread(MoveSnake);
            thread.Start();

            while(IsAlive && keyInfo.Key != ConsoleKey.Escape)
            {
                keyInfo = Console.ReadKey();
                snake.ChangeDirection(keyInfo);
            }
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(20, 10);
            Console.Write("fini la jeu.");
        }
        public void MoveSnake()
        {
            while (IsAlive)
            {
                snake.Move();
                if (snake.IsCollisionWith(food))
                {
                    snake.Body.Add(new Point(0, 0));
                    while (food.IsCollisionWith(snake) || food.IsCollisionWith(wall))
                    {
                        food.Generate();
                    }
                    if (snake.Body.Count % 5 == 0)
                        wall.NextLvl();
                }
                if (snake.IsCollisionWith(wall))
                {
                    IsAlive = false;
                }
                Draw();
                Thread.Sleep(250);
            }
        }
        public void Draw()
        {
            Console.Clear();
            foreach(GameObject g in g_Objects)
            {
                g.Draw();
            }
        }
    }
}
