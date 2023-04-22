using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays_Processing
{
    internal class ArrayOperations
    {
        private int[] _array = new int[0];

        public int[] Values { get => _array; set => _array = value; }

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
    }
}
