using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PuzzleBiz.Model;
using System.Collections.Generic;

namespace UnitTestPuzzle
{
    [TestClass]
    public class UnitTestGameEngine
    {
        [TestMethod]
        public void TestGetRandomArrayAllNumbersExist()
        {
            int expectedResult = 0;
            List<int> list = new List<int>();
            for (int i = 0; i < 16; i++)
            {
                list.Add(i);
            }
            int[] nums = GameEngine.GetRandomArray(16);
            for (int i = 0; i < 16; i++)
            {
                if(list.Contains(nums[i])){
                    list.Remove(nums[i]);
                }
            }
            Assert.AreEqual(expectedResult, list.Count);
        }

        [TestMethod]
        public void TestGetRandomArrayScrambled()
        {

            int counter = 0;
            int[] nums = GameEngine.GetRandomArray(16);
            for (int i = 0; i < 16; i++)
            {
                if (nums[i] ==i)
                {
                    counter++;
                }
            }
            Assert.AreNotEqual(16, counter);
        }
    }
}
