
using System.Diagnostics;
using Algorithms;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace AlgorithmsTest
{
    /// <summary>
    ///  类名称：LRUCacheSolutionTest
    /// 
    /// </summary>
    /// * 创建人：xierenhong
    /// * 创建时间：2015/4/28 12:53:12
    /// * 修改人：
    /// * 修改时间：
    /// * 修改备注：
    /// * ==============================================================================*/
    [TestClass]
    public class LRUCacheSolutionTest
    {
        [TestMethod]
        public void LRUCacheTest()
        {
            var solution = new LRUCacheSolution(1);
            solution.Set(1, 2);
            int excepted = 2;
            int actual = solution.Get(1);
            Assert.AreEqual(excepted, actual);

            actual = solution.Get(0);
            Assert.AreEqual(-1, actual);
        }

        /// <summary>
        ///LRUCacheSolution 构造函数 的测试
        ///</summary>
        [TestMethod()]
        public void LRUCacheSolutionConstructorTest()
        {
            int capacity = 0; // TODO: 初始化为适当的值
            LRUCacheSolution target = new LRUCacheSolution(capacity);
        }

        /// <summary>
        ///Get 的测试
        ///</summary>
        [TestMethod()]
        public void GetTest()
        {
            int capacity = 1; // TODO: 初始化为适当的值
            LRUCacheSolution target = new LRUCacheSolution(capacity); // TODO: 初始化为适当的值
            int key = 0; // TODO: 初始化为适当的值
            int expected = -1; // TODO: 初始化为适当的值
            int actual;
            actual = target.Get(key);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///Set 的测试
        ///</summary>
        [TestMethod()]
        public void SetTest()
        {
            int capacity = 1; // TODO: 初始化为适当的值
            LRUCacheSolution target = new LRUCacheSolution(capacity); // TODO: 初始化为适当的值
            int key = 0; // TODO: 初始化为适当的值
            int value = 0; // TODO: 初始化为适当的值
            target.Set(key, value);
            Assert.AreEqual(value, target.Get(key));

            key = 0;
            value = 1;
            target.Set(key, value);
            Assert.AreEqual(value, target.Get(key));

            key = 1;
            value = 2;
            target.Set(key, value);
            Assert.AreEqual(value, target.Get(key));
            Assert.AreEqual(-1, target.Get(0));

            key = 2;
            value = 7;
            target.Set(key, value);
            Assert.AreEqual(-1, target.Get(1));
        }
    }
}
