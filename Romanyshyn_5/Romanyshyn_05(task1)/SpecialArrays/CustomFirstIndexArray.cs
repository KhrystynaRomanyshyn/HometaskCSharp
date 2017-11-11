using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialArrays
{
    public class CustomFirstIndexArray
    {
        private readonly int[] _array;

        public int Length
        {
            get
            {
                return _array.Length;
            }
        }

        public int FirstIndex { get; }

        public int LastIndex
        {
            get
            {
                return FirstIndex + Length - 1;
            }
        }

        public CustomFirstIndexArray(int firstIndex, params int[] items)
        {
            if (items == null || items.Length == 0)
            {
                throw new ArgumentException("Array must contain elements");
            }

            FirstIndex = firstIndex;
            _array = items;
        }

        public int this[int index]
        {
            get
            {
                return _array[index - FirstIndex];
            }
            set
            {
                _array[index - FirstIndex] = value;
            }
        }
    }
}