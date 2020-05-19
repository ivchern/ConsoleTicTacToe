using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTicTacToe
{
    class FieldPaint
    {
        void verticalLine(int x, int y) 
        {
            for (int i = x; i < x + 6; i += 2)
            {
                Console.SetCursorPosition(y, i);
                Console.Write('|');
            }
        }
        void horizontalLine(int x, int y)
        {
            for (int i = y; i < y + 7; i += 1)
            {
                Console.SetCursorPosition(i, x);
                Console.Write('-');
            }
        }
        public void NewField() //Показывает сетку
        {
            CheckLuckyCombination checkWin = new CheckLuckyCombination();
            NumberVision numberVision = new NumberVision(); 
            horizontalLine(2, 0);
            horizontalLine(4, 0);
            verticalLine(1, 2);
            verticalLine(1, 4);
            numberVision.SymInField(1, 1);
            numberVision.SymInField(1, 3);
            numberVision.SymInField(1, 5);
        }


    }

}

