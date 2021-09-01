using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    public class _8
    {
        //Так как напрямую нельзя вывести значение '5' сделаем это косвенном образом с помощью св-ва 
        // длины в массиве, состоящий из 5-ти элементов
        public static int ReturnNumberFive()
        {
            var mass = new char[] { 'k', 'k', 'k', 'k', 'k' };
            return mass.Length;
        }
    }
}
