using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Processing
{
    internal class ArrayOperations
    {
        /// <summary>
        /// Minimum number for third operation to check.
        /// </summary>
        private int _op3_min = 99;

        /// <summary>
        /// Maximum number for third operation to check.
        /// </summary>
        private int _op3_max = 10000;

        /// <summary>
        /// Minimum number for fourth operation to check.
        /// </summary>
        private int _op4_min = 9;

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
            _array = new int[0];
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
        /// Find min, max element of array and median.
        /// </summary>
        /// <returns>min, max, median.</returns>
        public int[] OperationOne()
        {
            int max, min, med;
            max = min = _array[0];
            foreach (int i in _array)
            {
                if (i > max) max = i;
                if (i < min) min = i;
            }

            int[] tmp = Sort();

            if (tmp.Length % 2 == 0)
                med = tmp[tmp.Length - 1] / 2;
            else
                med = (tmp[(tmp.Length - 1) / 2] + tmp[tmp.Length / 2]) / 2;

            int[] res = {min, max,  med};

            return res;
        }

        /// <summary>
        /// Sort elements in descending order.
        /// </summary>
        public void OperationTwo()
        {
            _array = Sort();
            Array.Reverse(_array);
        }

        /// <summary>
        /// Calculate sum and number of elements of the array, 
        /// in which number created from last and third from end number, element also must be even.
        /// </summary>
        /// <returns>number, sum.</returns>
        public int[] OperationThree()
        {
            int count, sum;
            count = sum = 0;

            foreach (int i in _array)
            {
                if (i > _op3_min && i < _op3_max)
                    if ((i % 10 + i / 100 % 10) % 2 == 0) 
                    {
                        sum += i;
                        count++;
                    }
            }

            int[] res = { count, sum };
            return res;
        }

        /// <summary>
        /// Calculates sum of two first number of a number
        /// </summary>
        /// <param name="number">number</param>
        /// <returns></returns>
        private int TwoFirst(int number)
        {
            while (number >= 100)
            {
                number /= 10;
            }

            return number / 10 % 10 + number % 10;
        }

        public int[] OperationFour()
        {
            int count, sum;
            count = sum = 0;

            foreach (int i in _array)
            {
                if (i > _op4_min)
                    if (TwoFirst(i) % 5 == 0)
                    {
                        sum += i;
                        count++;
                    }
            }

            int[] res = { count, sum };
            return res;
        }
    }
}
