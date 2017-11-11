using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polinom
{
    public class OneVariablePolinom
    {
        private readonly int[] _array;

        public OneVariablePolinom(params int[] coefficients)
        {
            if (coefficients == null || coefficients.Length == 0)
            {
                throw new ArgumentException("Coeficients were not specified");
            }

            _array = coefficients.Reverse().ToArray();

            for (int i = 0; i < _array.Length; i++)
            {
                if (_array[i] != 0)
                {
                    if (_array[_array.Length - 1] == 0)
                    {
                        throw new ArgumentException("First coeficient must not be 0");
                    }

                    Degree = _array.Length - 1;
                    return;
                }
            }

            Degree = double.NegativeInfinity;
        }

        public double Degree { get; }

        public int this[int index]
        {
            get
            {
                return _array[index];
            }

            set
            {
                _array[index] = value;
            }
        }

        public int Length
        {
            get { return _array.Length; }
        }

        public static OneVariablePolinom SimpleOperation(OneVariablePolinom obj1, OneVariablePolinom obj2, bool isAdd)
        {

            bool firstLess = obj1.Length < obj2.Length;
            int maxLength = firstLess ? obj2.Length : obj1.Length;
            int minLength = firstLess ? obj1.Length : obj2.Length;

            var result = new int[maxLength];

            for (int i = maxLength - 1; i >= 0; i--)
            {
                if (i < minLength)
                {
                    if (isAdd)
                    {
                        result[i] = obj1[i] + obj2[i];
                    }
                    else
                    {
                        result[i] = obj1[i] - obj2[i];
                    }
                }
                else
                {
                    result[i] = firstLess ? obj2[i] : obj1[i];
                }
            }

            return new OneVariablePolinom(result.Reverse().ToArray());
        }

        public static OneVariablePolinom operator +(OneVariablePolinom obj1, OneVariablePolinom obj2)
        {
            return SimpleOperation(obj1, obj2, true);
        }

        public static OneVariablePolinom operator -(OneVariablePolinom obj1, OneVariablePolinom obj2)
        {
            return SimpleOperation(obj1, obj2, false);
        }
                
        public override string ToString()
        {
            string result = "";
            for (int i = _array.Length - 1; i >= 0; i--)
            {
                if (i == _array.Length - 1 && _array[i] == 1)       //перший елемент = 1
                {
                    result += string.Format("x^{0}", i);
                }
                else if (_array[i] == -1 && i != 1 && i != 0)      // елемент -1
                {
                    result += string.Format("-x^{0}", i);
                }
                else if (_array[i] == -1)
                {
                    if (i == 1)
                    {
                        result += string.Format("-x");
                        continue;
                    }
                    if (i == 0)
                    {
                        result += string.Format("-1");
                    }
                }
                else if (_array[i] < 0)      // відємні коеф
                {
                    if (i == 0)              //відємні коеф + степінь х:0
                    {
                        result += string.Format("{0}", _array[i]);
                    }
                    else if (i == 1)              // відємні коеф + степінь х:1
                    {
                        result += string.Format("{0}x", _array[i]);
                    }
                    else
                    {
                        result += string.Format("{0}x^{1}", _array[i], i);
                    }
                }
                else if (_array[i] > 0)            // додатні коеф
                {
                    if (i == 0)                  // додатні коеф + степінь х:0
                    {
                        result += string.Format("+{0}", _array[i]);
                    }
                    else if (i == 1)                      //додатні коеф + степінь х:1
                    {
                        result += string.Format("+{0}x", _array[i]);
                    }
                    else if (i == _array.Length - 1)    //перший
                    {
                        result += string.Format("{0}x^{1}", _array[i], i);
                    }
                    else if (_array[i] == 1)
                    {
                        result += string.Format("+x^{0}", i);
                    }
                    else
                    {
                        result += string.Format("+{0}x^{1}", _array[i], i);
                    }
                }
            }
            return result;
        }
        //public static OneVariablePolinom Multiplication (OneVariablePolinom obj1, OneVariablePolinom obj2)
        //{
        //    int lengthResult = obj1.Length + obj2.Length - 1;
        //    var result = new int[lengthResult];
        //    for(int i=obj1.Length-1; i>=0; i--)
        //    {

        //    }

        //}
    }
}



