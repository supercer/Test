using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    public class _7
    {
        public static int TheSumOfTheElementsOfRowOfTriangle(int numberRow)
        {
            if (numberRow == 1)
            {
                return 1;
            }
            //Здесь прослеживается арифметическая прогрессия между элементами
            //Для вычисления суммы арифметической прогрессии нужно найти общее количество элементов
            // Используем формулу для вычисления суммы арифметической прогрессии
            // Для вычисления суммы заданной строки высчитываем разность сумм всех элементов до этой строки и в ней с
            // суммой всех элементов до этой строки
            int TheNumberOfAllElementsBeforeAndInThisLine = (numberRow * (numberRow + 1)) / 2;
            int TheNumberOfAllElementsBeforeAndInBeforeThisLine = ((numberRow - 1) * (numberRow)) / 2;
            int sumNumberRow = ((2 + 2 * (TheNumberOfAllElementsBeforeAndInThisLine - 1)) * TheNumberOfAllElementsBeforeAndInThisLine) / 2;
            int sumBeforeThisRow = ((2 + 2 * (TheNumberOfAllElementsBeforeAndInBeforeThisLine - 1)) * TheNumberOfAllElementsBeforeAndInBeforeThisLine) / 2;
            return sumNumberRow - sumBeforeThisRow;
        }
    }
}
