﻿using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Final_Game
{
    class MazeWorld
    {
        private string[,] Grid;
        private int Rows;
        private int Cols;
        public MazeWorld(string[,] grid)
        {
            Grid = grid;
            Rows = Grid.GetLength(0);
            Cols = Grid.GetLength(1);
        }

        public void Draw()
        {
            for (int y = 0; y < Rows; y++)
            {
                for (int x = 0; x < Cols; x++)
                {
                    string element = Grid[y, x];
                    SetCursorPosition(x, y);

                    if(element == "*")
                    {
                        ForegroundColor = ConsoleColor.Cyan;
                    }
                    else
                    {
                        ForegroundColor = ConsoleColor.White;
                    }
                    Write(element);
                }
            }
        }
        public bool IsPositionWalkable(int x, int y)
        {
            //check bounds
            if ( x < 0 || y < 0 || x >= Cols || y >= Rows)
            {
                return false;
            }
            // check if grid is walkable
            return Grid[y, x] == " " || Grid[y, x] == "*";
        }

        public string GetElementAt(int x, int y)
        {
            return Grid[y, x];
        }
    }
}
