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
        private int _op3_min = 99;
        private int _op3_max = 10000;
        private int _op4_min = 9;

        private int[]? _array = null;

        public int[] Value { get => _array; set => _array = value; }

        public void GenerateArray(int size, int min, int max)
        {
            _array = new int[size];
            Random random = new Random();
            for (int i = 0; i < size; i++) _array[i] = random.Next(min, max + 1);
        }

        public void Clear()
        {
            _array = new int[0];
        }

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

        public void OperationTwo()
        {
            _array = Sort();
            Array.Reverse(_array);
        }

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

        private int TwoFirst(int digit)
        {
            while (digit >= 100)
            {
                digit /= 10;
            }

            return digit / 10 % 10 + digit % 10;
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
