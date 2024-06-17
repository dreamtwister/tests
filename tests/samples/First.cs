using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace tests.samples
{
    /*
Сортировка выбором O(N^2)

There is an array of integer. Size of the array can vary from 0 to N where N is definitely less than int.MaxValue.
Please write code that sorts a given array from max value to min. What is the complexity of the algorithm?

Имеется массив целых чисел. Размер массива может варьироваться от 0 до N, где N определенно меньше, чем int.MaxValue.
Пожалуйста, напишите код, который сортирует данный массив от максимального значения до минимального. Какова сложность алгоритма?
     */
    public class First
    {
        public int[] Sort(int[] input)
        {
            int currentIndex = 0;

            do
            {
                var index = IndexOfMax(input, currentIndex);
                if (index != currentIndex)
                {
                    Swap(ref input[index], ref input[currentIndex]);
                }
            } while (++currentIndex < input.Length);

            return input;
        }

        /// <summary>
        /// смена мест элементов
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        private void Swap(ref int a, ref int b)
        {
            var temp = a;
            a = b;
            b = temp;
        }

        /// <summary>
        /// поиск индекса максимального элемента последовательности
        /// </summary>
        /// <param name="array"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        private int IndexOfMax(int[] array, int n)
        {
            int result = n;
            for (var i = n; i < array.Length; ++i)
            {
                if (array[i] > array[result])
                {
                    result = i;
                }
            }

            return result;
        }
    }
}
