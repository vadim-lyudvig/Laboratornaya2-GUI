using Microsoft.VisualStudio.TestTools.UnitTesting;
using Labaratornaya.GUI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labaratornaya.GUI.Tests
{
    [TestClass()]
    public class LogicTests
    {
       [TestMethod()]
        public void CompareTest1()
        {
            Assert.AreEqual("Треугольник прямоугольный", Logic.Compare(3, 4, 5));
        }
        [TestMethod()]
        public void CompareTest2()
        {
            Assert.AreEqual("Треугольник не прямоугольный", Logic.Compare(3, 5, 5));
        }
        [TestMethod()]
        public void CompareTest3()
        {
            Assert.AreEqual("Треугольник не существует", Logic.Compare(16, 4, 4));
        }
        [TestMethod()]
        public void CountingArrayTest1()
        {

            Assert.AreEqual("Минимальное число 1 левее 3 на 2 позиций ", Form3.Logic.CountingArray(new int[] { 1, 2, 3 }));
        }
        [TestMethod()]
        public void CountingArrayTest2()
        {
            Assert.AreEqual("Максимальное число 3 левее 1 на 2 позиций ", Form3.Logic.CountingArray(new int[] { 3, 2, 1 }));
        }
    }
}