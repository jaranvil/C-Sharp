using System;
using System.Collections.Generic;
using System.Text;

namespace PuzzleBiz.Model
{
    public class GameEngine
    {
        public static int[] GetRandomArray(int num)
        {
            int index = 0;
            int j = 0;
            List<int> array1 = new List<int>();
            int[] result = new int[num];
            for (int i = 0; i < num; i++)
            {
                array1.Add(i);
            }
            Random random = new Random();
            while (array1.Count > 0)
            {
                index = random.Next(array1.Count);
                result[j++] = array1[index];
                array1.RemoveAt(index);
            }    
            return result;
        }
   
        public void Move()
        {

        }
    }
}
