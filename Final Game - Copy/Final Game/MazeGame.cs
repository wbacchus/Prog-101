using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Final_Game
{
    class MazeGame
    {
        private MazeWorld MyWorld;
        private MazePlayer CurrentPlayer;
        public void Start()
        {
            WriteLine("Maze is starting");
            CursorVisible = false;

            // SetCursorPosition(4, 2);
            //  Write("X");
            string[,] grid = LevelParser.ParseFiletoArray("Ending.txt");
            
            int rows = grid.GetLength(0);
            int cols = grid.GetLength(1);
            MyWorld = new MazeWorld(grid);
            
            CurrentPlayer = new MazePlayer(0, 19);
            RunGameLoop();
            

           // WriteLine("\n\npress any key to exit...");
           // ReadKey(true);
            
        }
        private void DisplayIntro()
        {
            WriteLine("Welcome to the maze");
            WriteLine("\nInstructions");
            WriteLine("> Use the arrow keys to move");
            WriteLine("> try to reach the *");
            WriteLine("press any key to start");
            ReadKey(true);
        }

        private void DisplayOutro()
        {
            Clear();
            WriteLine("You have reached the end");
            WriteLine("Press any key to exit");
            ReadKey(true);
        }
        private void DrawFrame()
        {
            Clear();
            MyWorld.Draw();
            CurrentPlayer.Draw();
        }
        private void HandlePlayerInput()
        {
            ConsoleKey key;

            do
            {
                ConsoleKeyInfo KeyInfo = ReadKey(true);
                 key = KeyInfo.Key;
            } while (KeyAvailable);




            
            switch (key)
            {
                case ConsoleKey.UpArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.x,CurrentPlayer.y - 1))
                    CurrentPlayer.y -= 1;
                    break;
                case ConsoleKey.DownArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.x, CurrentPlayer.y + 1))
                        CurrentPlayer.y += 1;
                    break; 
                case ConsoleKey.LeftArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.x - 1, CurrentPlayer.y))
                        CurrentPlayer.x -= 1;
                    break;
                case ConsoleKey.RightArrow:
                    if (MyWorld.IsPositionWalkable(CurrentPlayer.x + 1, CurrentPlayer.y))
                        CurrentPlayer.x += 1;
                    break;
            }
        }
        private void RunGameLoop()
        {
            
            while (true)
            {
                // draw everything
                DrawFrame();

                // check player input from keyboard and move player
                HandlePlayerInput();

                // check if player has reached the exit and end the game
                string elementAtPlayerPos = MyWorld.GetElementAt(CurrentPlayer.x, CurrentPlayer.y);
                if (elementAtPlayerPos == "*")
                {
                    break;
                }
                // give the console a  chance to render
                System.Threading.Thread.Sleep(500);
            }
            DisplayOutro();
        }
    }
}
