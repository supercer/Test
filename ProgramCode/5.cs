using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestWork
{
    public class _5
    {
        //функция, возвращающая в словаре наименьший список количества различных монет для составления переданной суммы
        public static Dictionary<string, int> SmallestNumberOfCoinsUsedToCreateThisAmount(int sum)
        {
            //Если сумма входящая отрицательная или равна 0, то в словарь записываем, что количество всех монет =0
            var coins = new Dictionary<string, int>();
            if (sum <= 0)
            {
                var num = (int)sum;
                coins.Add("Nickels", 0);
                coins.Add("Pennies", 0);
                coins.Add("Dimes", 0);
                coins.Add("Quarters", 0);

                return coins;
            }

            int Nickels = 5;
            int Dimes = 10;
            int Quarters = 25;
            int countQuarters;
            int countDimes;
            int countNickels;
            int tempSum;
            //Сначала проверяем варианты с монетами большего номинала,
            //постепенно переходя к проверкам монет меньшего номинала 
            if (sum % Quarters == 0)
            {
                coins.Add("Nickels", 0);
                coins.Add("Pennies", 0);
                coins.Add("Dimes", 0);
                coins.Add("Quarters", sum / Quarters);
                return coins;
            }

            if (sum % Quarters != 0)
            {
                countQuarters = sum / Quarters;
                tempSum = sum - countQuarters * Quarters;
                if (tempSum % Dimes == 0)
                {
                    coins.Add("Nickels", 0);
                    coins.Add("Pennies", 0);
                    coins.Add("Dimes", tempSum / Dimes);
                    coins.Add("Quarters", countQuarters);
                    return coins;
                }

                if (tempSum % Dimes != 0)
                {
                    countDimes = tempSum / Dimes;
                    tempSum = tempSum - countDimes * Dimes;
                    if (tempSum % Nickels == 0)
                    {
                        coins.Add("Nickels", tempSum / Nickels);
                        coins.Add("Pennies", 0);
                        coins.Add("Dimes", countDimes);
                        coins.Add("Quarters", countQuarters);
                        return coins;
                    }
                    if (tempSum % Nickels != 0)
                    {
                        countNickels = tempSum / Nickels;
                        tempSum = tempSum - countNickels * Nickels;
                        coins.Add("Nickels", countNickels);
                        coins.Add("Pennies", tempSum);
                        coins.Add("Dimes", countDimes);
                        coins.Add("Quarters", countQuarters);
                        return coins;
                    }
                }
            }
            return coins;
        }
        //перегрузка нашего ключевого метода, для работы с переданной суммой, сохраненной в типе float
        public static Dictionary<string, int> SmallestNumberOfCoinsUsedToCreateThisAmount(float sum)
        {
            return SmallestNumberOfCoinsUsedToCreateThisAmount((int)sum);//Вызывая ключевой метод путем
            //приведения типа float к int, используя стандартное приведение - отсечение дробной части
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите сумму");
            float summa = 0;

            while (float.TryParse(Console.ReadLine(), out summa))
            {
                foreach (var item in SmallestNumberOfCoinsUsedToCreateThisAmount(summa))
                {
                    Console.WriteLine(item.Key + " - " + item.Value);
                }
            }
            Console.ReadLine();

        }
    }
}