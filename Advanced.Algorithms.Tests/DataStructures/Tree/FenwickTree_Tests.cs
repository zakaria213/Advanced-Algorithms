﻿using Advanced.Algorithms.DataStructures;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Advanced.Algorithms.Tests.DataStructures.Tree
{
    [TestClass]
    public class AsFenwickTreeTests
    {
        /// <summary>
        /// Smoke test
        /// </summary>
        [TestMethod]
        public void AsFenwickTree_Sum_Smoke_Test()
        {
            var testArray = new int[] { 1, 3, 5, 7, 9, 11 };

            //tree with sum operation
            var tree = new FenwickTree<int>(testArray,
                new Func<int, int, int>((x, y) => x + y));

            var sum = tree.GetPrefixSum(3);

            Assert.AreEqual(16, sum);
        }
    }
}
