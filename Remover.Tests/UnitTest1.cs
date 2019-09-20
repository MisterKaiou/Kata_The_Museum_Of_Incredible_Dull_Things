using NUnit.Framework;
using Remv.main;
using System.Collections.Generic;
using System;

namespace Tests.SmallestRemover
{
    public class Tests
    {
        protected Remover removeSmall = new Remover();

        protected void Tester(List<int> argument, List<int> expectedResult)
        {
            CollectionAssert.AreEqual(expectedResult, removeSmall.RemoveSmallest(argument));
        }

        [Test, Description("Given an array of integers, remove the smallest value")]
        public void InitialTest()
        {
            Tester(new List<int> { 1, 2, 3, 4, 5 }, new List<int> { 2, 3, 4, 5 });
            Tester(new List<int> { 5, 3, 2, 1, 4 }, new List<int> { 5, 3, 2, 4 });
            Tester(new List<int> { 10, 20, 30, 40, 50 }, new List<int> { 20, 30, 40, 50 });
            Tester(new List<int> { 45, 27, 12, 89, 15 }, new List<int> { 45, 27, 89, 15 });
            Tester(new List<int> { 17, 19, 16, 13, 12 }, new List<int> { 17, 19, 16, 13 });
        }

        [Test, Description("If there are multiple elements with the same value, remove the one with lower index")]
        public void RepeatedEntry()
        {
            Tester(new List<int> { 1, 2, 3, 1, 1 }, new List<int> { 2, 3, 1, 1 });
            Tester(new List<int> { 1, 5, 2, 1, 4 }, new List<int> { 5, 2, 1, 4 });
            Tester(new List<int> { 45, 12, 27, 12, 15 }, new List<int> { 45, 27, 12, 15 });
            Tester(new List<int> { 12, 19, 16, 13, 12 }, new List<int> { 19, 16, 13, 12 });
            Tester(new List<int> { 30, 20, 10, 40, 10 }, new List<int> { 30, 20, 40, 10 });
        }

        [Test, Description("If given an empty array/list, return an empty array/list.")]
        public void EmptyList()
        {
            Tester(new List<int>(), new List<int>());
        }
    }
}