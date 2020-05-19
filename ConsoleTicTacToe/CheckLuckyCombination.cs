using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTicTacToe
{
    class CheckLuckyCombination
    {

        bool horizontalCombination(int NumWinForms, char sym)
        {
            for (int i = NumWinForms; i < 3; i++)
            {
                if (NumberVision.numPosition[i] == sym && NumberVision.numPosition[i + 1] == sym && NumberVision.numPosition[i + 2] == sym)
                {
                    return true;
                    break;
                }
            }
            return false;
        }
        bool verticalCombination(int NumWinForms, char sym)
        {
            for (int i = NumWinForms; i < 3; i++)
            {
                if (NumberVision.numPosition[i] == sym && NumberVision.numPosition[i + 3] == sym && NumberVision.numPosition[i + 6] == sym)
                {
                    return true;
                    
                }
            }
            return false;
        }

        bool combinationRad(int NumWin1, int NumWin2, int NumWin3, char sym)
        {
            if (NumberVision.numPosition[NumWin1] == sym && NumberVision.numPosition[NumWin2] == sym && NumberVision.numPosition[NumWin3] == sym)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool WinLine(char sym)
        {
            if (horizontalCombination(1, sym) || verticalCombination(1, sym) || combinationRad(1, 5, 9, sym) || combinationRad(3, 5, 7, sym))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }
}

