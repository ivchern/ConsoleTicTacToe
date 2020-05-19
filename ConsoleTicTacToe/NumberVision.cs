using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleTicTacToe
{
    class NumberVision
    {
        public static Dictionary<int, dynamic> numPosition { get; } = new Dictionary<int, dynamic>(9);
        public  void StreamInArray()//записываю в массив свободные числа
        {

            for (int j = 0; j <= 9; j++)
            {
                numPosition.Add(j, ' '); 
            }
        }
        int k = 0;
        public void SymInField(int x, int y) //ввод цифр в сетку
        {
            NumberVision numberVision = new NumberVision();
            for (int i = x; i < x + 6; i += 2)
            {
                k++;
                Console.SetCursorPosition(i, y);
                Console.WriteLine(numPosition[k]);
            }
            if (k == 9)
            {
                k = 0;
            }
        }
         int inputNumUser(char sym) 
        {
            int inputNumber = int.Parse(Console.ReadLine());
            if (inputNumber > 9 || inputNumber < 1 || numPosition[inputNumber] == 'X' || numPosition[inputNumber] == 'O')
            {
                Console.WriteLine("Вы ввели не верное число, повторите");
                 SwapNumAndChar(sym);
                return 0;
            }
            else
            {
                return inputNumber;
            }
        }
        public bool SwapNumAndChar(char sym) //Меняем позицию на число
        {
            int inputNumber = inputNumUser(sym);
            numPosition.Remove(inputNumber);
            numPosition.Add(inputNumber, sym);
            CheckLuckyCombination checkWin = new CheckLuckyCombination();
            if (checkWin.WinLine(sym) == true)
            {
                return true;
            }
            return false;
        }
        
       
    }
}
