using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace Final_Game
{
    class MazePlayer
    {
       public int x { get; set; }
       public int y { get; set; }
        private string PlayerMarker;
        private ConsoleColor PlayerColor;
            public MazePlayer(int initialX, int initialY)
        {
            x = initialX;
            y = initialY;
            PlayerMarker = "*";
            PlayerColor = ConsoleColor.Cyan;
           
        }
        public void Draw()
        {
            ForegroundColor = PlayerColor;
            SetCursorPosition(x, y);
            Write(PlayerMarker);
            ResetColor();

        }
    }
}
