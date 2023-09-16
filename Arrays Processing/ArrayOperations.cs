using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Processing
{
    public class ArrayOperations
    {
        /// <summary>
        /// Array of integers.
        /// </summary>
        private int[]? _array = null;

        /// <summary>
        /// Array property.
        /// </summary>
        public int[] Value { get => _array; set => _array = value; }

        /// <summary>
        /// Generates array with specified values.
        /// </summary>
        /// <param name="size">Size of array.</param>
        /// <param name="min">Min element of array.</param>
        /// <param name="max">Max element of array.</param>
        public void GenerateArray(int size, int min, int max)
        {
            _array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++) _array[i] = random.Next(min, max + 1);
        }

        /// <summary>
        /// Clears array
        /// </summary>
        public void Clear()
        {
            _array = null;
        }

        /// <summary>
        /// Sorts array in ascending order.
        /// </summary>
        /// <returns>Sorted array.</returns>
        private int[] Sort()
        {
            int[] copy = _array;

            for (int i = 0; i < copy.Length; i++)
                for (int j = i + 1; j < copy.Length; j++)
                {
                    if (copy[j] < copy[i])
                    {
                        int tmp = copy[j];
                        copy[j] = copy[i];
                        copy[i] = tmp;
                    }
                }
            return copy;
        }

        /// <summary>
        /// Вычислить математическое ожидание и дисперсию массива
        /// </summary>
        /// <returns>Min, max, median.</returns>
        public int[] OperationOne()
        {
            int m, d;
            m = 0;
            foreach (int i in _array)
            {
                m += i;
            }

            m /= _array.Length;

            int s = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                d = _array[i] - m;
                s += d * d;
            }
            
            d = s / _array.Length - 1;
            int[] res = {m, d};

            return res;
        }

        /// <summary>
        /// Отсортировать элементы массива по возрастанию.
        /// </summary>
        public void OperationTwo()
        {
            _array = Sort();
        }

        /// <summary>
        /// Определить сумму и количество чисел больших С с нечетными номерами
        /// </summary>
        /// <returns>Number, sum.</returns>
        public int[] OperationThree(int C)
        {
            int count, sum;
            count = sum = 0;

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] > C && i % 2 != 0)
                {
                    count++;
                    sum += _array[i];
                }
            }

            int[] res = { count, sum };
            return res;
        }


        /// <summary>
        /// Определить количество простых чисел массива методом пробных делителей.
        /// </summary>
        /// <returns>Number, sum.</returns>
        public int OperationFour()
        {
            int count = 0;
            for (int i = 0; i < _array.Length; i++)
            {     
                    bool flag = true;
                    for (int el = 1; el <= Math.Sqrt(_array[i]); el++)
                    {
                        if (_array[i] % el == 0 && el != 1)
                        {
                            flag = false;
                            break;
                        }
                    }
                if (flag) count++;
            }
            return count;
        }
    }
}
