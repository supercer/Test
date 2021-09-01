using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
   public class _6
    {
        //функция, конвертирующая строку в целочисленный безнаковый массив 
        public static uint[] ConvertStringToArrayOfNumbers(string stroka)
        {
            uint[] mass = new uint[stroka.Length];
            for (int i = 0; i < stroka.Length; i++)
            {
                mass[i] = uint.Parse(stroka[i].ToString());
            }
            return mass;
        }
        //функция сортирует безнаковый целочисленный массив по убыванию. (на основе алгоритма сортировки выбором)
        public static void SortingAnArrayOfNumbersDesc(uint[] massNumbers)
        {
            for (int j = 0; j < massNumbers.Length - 1; j++)
            {
                for (int k = j + 1; k < massNumbers.Length; k++)
                {
                    if (massNumbers[j] < massNumbers[k])
                    {
                        var temp = massNumbers[k];
                        massNumbers[k] = massNumbers[j];
                        massNumbers[j] = temp;
                    }
                }
            }

        }
        //   безнаковый целочисленый массив преобразуем в строку
        public static string ConvertArrayOfNumbersToString(uint[] massNumbers)
        {
            var theStringContainingNumber = new StringBuilder();
            foreach (var item in massNumbers)
            {
                theStringContainingNumber.Append(item.ToString());
            }

            return theStringContainingNumber.ToString();
        }
        //функция, меняющая цифры входящего безнакового числа, таким образом что число представляется
        //максимально возможным по значению из состовляющих его цифр
        public static uint ReturnTheLargestNumber(uint number)
        {
            var theStringContainingNumber = number.ToString(); // Число преобразуем в строку
            var massNumbers = ConvertStringToArrayOfNumbers(theStringContainingNumber);// строку преобразуем
            // в массив чисел

            SortingAnArrayOfNumbersDesc(massNumbers); //массив сортируется по убыванию

            return uint.Parse(ConvertArrayOfNumbersToString(massNumbers));//конвертируем целочисленный
             //массив в строку и у нее парсим целочисленное число, которое и возвращает наша функция
        }
    }
}
