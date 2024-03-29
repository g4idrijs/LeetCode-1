﻿using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest
{


    /// <summary>
    ///这是 CountPrimesSolutionTest 的测试类，旨在
    ///包含所有 CountPrimesSolutionTest 单元测试
    ///</summary>
    [TestClass()]
    public class CountPrimesSolutionTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///获取或设置测试上下文，上下文提供
        ///有关当前测试运行及其功能的信息。
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region 附加测试特性
        // 
        //编写测试时，还可使用以下特性:
        //
        //使用 ClassInitialize 在运行类中的第一个测试前先运行代码
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //使用 ClassCleanup 在运行完类中的所有测试后再运行代码
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //使用 TestInitialize 在运行每个测试前先运行代码
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //使用 TestCleanup 在运行完每个测试后运行代码
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///CountPrimes 的测试
        ///</summary>
        [TestMethod()]
        public void CountPrimesTest()
        {
            CountPrimesSolution target = new CountPrimesSolution(); // TODO: 初始化为适当的值
            int n = 1; // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = target.CountPrimes(n);
            Assert.AreEqual(expected, actual);

            n = 2;
            expected = 0;
            actual = target.CountPrimes(n);
            Assert.AreEqual(expected, actual);

            n = 3;
            expected = 1;
            actual = target.CountPrimes(n);
            Assert.AreEqual(expected, actual);

            n = 4;
            expected = 2;
            actual = target.CountPrimes(n);
            Assert.AreEqual(expected, actual);

            n = 5;
            expected = 2;
            actual = target.CountPrimes(n);
            Assert.AreEqual(expected, actual);

            n = 6;
            expected = 3;
            actual = target.CountPrimes(n);
            Assert.AreEqual(expected, actual);

            n = 18;
            expected = 7;
            actual = target.CountPrimes(n);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///CountPrimes2 的测试
        ///</summary>
        [TestMethod()]
        public void CountPrimes2Test()
        {
            CountPrimesSolution target = new CountPrimesSolution(); // TODO: 初始化为适当的值
            int n = 1; // TODO: 初始化为适当的值
            int expected = 0; // TODO: 初始化为适当的值
            int actual;
            actual = target.CountPrimes2(n);
            Assert.AreEqual(expected, actual);

            n = 2;
            expected = 0;
            actual = target.CountPrimes2(n);
            Assert.AreEqual(expected, actual);

            n = 3;
            expected = 1;
            actual = target.CountPrimes2(n);
            Assert.AreEqual(expected, actual);

            n = 4;
            expected = 2;
            actual = target.CountPrimes2(n);
            Assert.AreEqual(expected, actual);

            n = 5;
            expected = 2;
            actual = target.CountPrimes2(n);
            Assert.AreEqual(expected, actual);

            n = 6;
            expected = 3;
            actual = target.CountPrimes2(n);
            Assert.AreEqual(expected, actual);

            n = 18;
            expected = 7;
            actual = target.CountPrimes2(n);
            Assert.AreEqual(expected, actual);
        }
    }
}
