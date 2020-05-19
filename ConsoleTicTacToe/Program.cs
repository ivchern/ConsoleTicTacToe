/*А вот и новое домашнее задание. Непростое. Но вполне реализуемое.

Вы попробуете реализовать игру в крестики-нолики размером 3х3 - самые что ни наесть обыкновенные.

Сделайте метод, который выводит на каждом ходу текущее положение с линейками, крестиками и ноликами (используйте буквы X и O в качестве крестиков и ноликов) - так игрокам будет удобнее ориентироваться.

Также вам понадобится реализовать способ проверки наличия выигрышной комбинации. Подсказа: договоримся, что клетки поля будут пронумерованы от 1 до 9 и пользователи будут вводить индекс поля, чтобы поставить там крестик или нолик.

Для упрощения - тот кто ходит первым - ставит крестик.*/

using System;

namespace ConsoleTicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckLuckyCombination checkWin = new CheckLuckyCombination();
            FieldPaint paint = new FieldPaint();
            NumberVision numVision = new NumberVision();
            numVision.StreamInArray();


            //Ввод данных игроков
            Console.WriteLine("Введите имя 1 игрока и нажмите Enter:");
            string firstPlayerName = Console.ReadLine();
            Console.WriteLine("Введите имя 2 игрока и нажмите Enter:");
            string secondPlayerName = Console.ReadLine();
            Console.Clear();
            int count = 0;
            bool x = false;
            bool y = false;
            int id = 0;
            while (true)
            {
                paint.NewField();
                Console.WriteLine($"Ходит {firstPlayerName}, введите число ячейке");
                x = numVision.SwapNumAndChar('X');
                count++;
                Console.Clear();
                if (x == true ) //Выход при выигрыше
                {
                    id += 1;
                    break;
                }
                if (count == 9) break; //выход если все клеточки заняты

                paint.NewField();
                Console.WriteLine($"Ходит {secondPlayerName}, введите число ячейке");
                y = numVision.SwapNumAndChar('O');
                count++;
                Console.Clear();
                
                if (y == true) //Выход при выигрыше
                {
                    id += 2;
                    break;
                }
             
            }
            if (id == 1)
            {
                Console.WriteLine($"Поздравляем,  {firstPlayerName} выиграл!");
            }
            if (id == 2)
            {
                Console.WriteLine($"Поздравляем,  {secondPlayerName} выиграл!");
            }
            if(id == 0)
            {
                Console.WriteLine("Все проиграли");
            }
        }
    }
}

       
   
