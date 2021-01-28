using System;
using System.Collections.Generic;
using System.Text;

namespace Lib_TwoSum
{
    public class TwoSum : ITwoSum
    {
        public int[] GetPair(int[] arrayInt, int sum)
        {         
            bool rslt = false;
            int[] intIndex = { 0, 0 };

            for (int i = 0; i < arrayInt.Length; i++)
            {
                for (int j = 0; j < arrayInt.Length; j++)
                {
                    if ((arrayInt[i] + arrayInt[j]) == sum)
                    {
                        intIndex[0] = i;
                        intIndex[1] = j;
                        rslt = true;
                        break;
                    }
                }
                if (rslt == true) break;
            }

            return intIndex;
        }
    }
}
