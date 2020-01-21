using System;
using System.Collections.Generic;
using System.Text;

namespace HW_10.Task1
{
    class Remove
    {
        int[] integerList = new int[] { 1, 1, 2, 3, 1, 2, 3, 4, 4, 3, 5, 6, 7, 2, 8 };
        int[] valuesList = new int[] { 1, 3, 4, 2 };

        public static int[] Clear(int[] integerList, int[] valuesList)
        {
            int counter = integerList.Length;
            for (int a = 0; a < integerList.Length; a++)
            {
                for (int b = 0; b < valuesList.Length; b++)
                {
                    if (integerList[a].Equals(valuesList[b]))
                    {
                        integerList[a] = 0;
                        counter--;
                    }
                }
            }
            int[] answer = new int[counter];
            counter = 0;
            for (int i = 0; i < integerList.Length; i++)
            {
                if (integerList[i] != 0)
                {
                    answer[counter] = integerList[i];
                    counter++;
                }
            }
            return answer;
        }
    }
}
