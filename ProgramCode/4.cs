using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
   public class _4
    {
        //строку преобразуем в безнаковый целочисленый массив 
        public static uint[] ConvertStringToArrayOfNumbers(string stroka)
        {
            uint[] mass = new uint[stroka.Length];
            for (int i = 0; i < stroka.Length; i++)
            {
                mass[i] = uint.Parse(stroka[i].ToString());
            }
            return mass;
        }
        //вспомагательная функция подсчета суммы всех элементов безнакового целочисленного массива
        public static uint SumNumbersOfArray(uint[] mass)
        {
            uint sum = 0;
            foreach (var item in mass)
            {
                sum += item;
            }

            return sum;
        }
        //Функция подсчета суммы цифр входящего числа и самой образовавшейся суммы
        //до того момента, как эта сумма станет состоять из одного числа 
        public static uint CountingTheSumOfTheDigitsOfNumber(uint number)
        {
            var theStringContainingNumber = new StringBuilder();
            // значение числа добавляем в динамическую строку, для того чтобы проще всего извлечь отдельные цифры этого числа 
            theStringContainingNumber.Append(number);
            uint sumDigits = 0;

            while (theStringContainingNumber.Length > 1)
            {
                sumDigits = 0;
                //разбираем из строки цифры и помещаем его в массив с помощью вспомогательного метода
                //(применяем один из принципа SOLID принцип единственной ответствонности)
                //тоесть разбиваем задачу на подзадачи
                var mass = ConvertStringToArrayOfNumbers(theStringContainingNumber.ToString());
                //считаем сумму цифр числа
                sumDigits += SumNumbersOfArray(mass);
                theStringContainingNumber.Clear();//очищаем строку
                theStringContainingNumber.Append(sumDigits);//кладем в строку рассчитанную сумму
            }

            return sumDigits;//Выводим конечную получившеюся сумму
        }
    }
}
