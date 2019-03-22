using System;
using System.Collections.Generic;
using System.IO;
namespace Zmiya
{
    public class Wall:GameObject
    {
        enum GameLvl
        {
            UN, DEUX, TROIS
        }
        GameLvl gameLvl = GameLvl.UN;
        public Wall(char sign, ConsoleColor color):base(0, 0, sign, color)
        {
            Body = new List<Point>();
        }
        public void LoadLevel()
        {
            Body = new List<Point>();
            string FileName = "LevelUn.txt";
            if (gameLvl == GameLvl.DEUX)
                FileName = "LevelDeux.txt";
            if (gameLvl == GameLvl.TROIS)
                FileName = "LevelTrois.txt";

            StreamReader sr = new StreamReader(FileName);
            string[] rows = sr.ReadToEnd().Split('\n');
            for (int i = 0; i < rows.Length; i++)
                for (int j = 0; j < rows[i].Length; j++)
                    if (rows[i][j] == '#')
                        Body.Add(new Point(j, i));      
        }
        public void NextLvl()
        {
            if (gameLvl == GameLvl.UN)
                gameLvl = GameLvl.DEUX;
            if (gameLvl == GameLvl.DEUX)
                gameLvl = GameLvl.TROIS;
            LoadLevel();
        }
    }
}
