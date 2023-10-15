using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using CorrectCodeLibrary;

namespace CorrectCodeTests
{
    [TestClass]
    public class CorrectCodeTests
    {
        /// <summary>
        /// проверка пустой строки
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringIsEmpty_FalseRetuned()
        {
            //act
            string candidate = "";
            //arrange
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// проверка корткой строки
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringIsShort_FalseRetuned()
        {
            //act
            string candidate = "123";
            //arrange
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// проверка длинной строки
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringIsLong_FalseRetuned()
        {
            //act
            string candidate = "123123123123123";
            //arrange
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// ввод строки без чисел
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringIsNoNumbers_FalseRetuned()
        {
            //act
            string candidate = "strokasymb";
            //arrange
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// ввод корректой строки(1)
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringIsCorrectCode_TrueReturned()
        {
            //act
            string candidate = "1234123400";
            //arrange
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //assert
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// ввод некорректой строки(1)
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringIsUnCorrectCode_FalseRetuned()
        {
            //act
            string candidate = "1234123401";
            //arrange
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// ввод некорректой строки(2)
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringIsUnCorrectCode1_FalseRetuned()
        {
            //act
            string candidate = "1234123404";
            //arrange
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //assert
            Assert.IsFalse(actual);
        }
        /// <summary>
        /// ввод корректой строки(2)
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringIsCorrectCode1_TrueReturned()
        {
            //act
            string candidate = "3000030001";
            //arrange
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //assert
            Assert.IsTrue(actual);
        }
        /// <summary>
        /// ввод корректой строки(3)
        /// </summary>
        [TestMethod]
        public void IsCorrectCode_StringIsCorrectCode2_TrueReturned()
        {
            //act
            string candidate = "3000130009";
            //arrange
            bool actual = CorrectCodeClass.IsCorrectCode(candidate);
            //assert
            Assert.IsTrue(actual);
        }

    }
}
