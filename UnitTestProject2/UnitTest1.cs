using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject2
{
    [TestClass]
    public class ProgramTests
    {
        [TestMethod]
        public void TestMethod1_RightResultUsingComma()
        {
            var program = new ConsoleApplication2.Program();

            Assert.AreEqual("One Hundred Twenty-Three Quadrillion Four Hundred Fifty-Six Trilion Seven Hundred Eighty-Nine Billion Twelve Million Three Hundred Forty-Five Thousand Six Hundred Seventy-Eight Dollars and Twenty Cents ", program.ConvertToWords("123456789012345678,20"));
        }
        [TestMethod]
        public void TestMethod2_RightResultUsingDot()
        {
            var program = new ConsoleApplication2.Program();

            Assert.AreEqual("One Hundred Twenty-Three Quadrillion Four Hundred Fifty-Six Trilion Seven Hundred Eighty-Nine Billion Twelve Million Three Hundred Forty-Five Thousand Six Hundred Seventy-Eight Dollars and Twenty Cents ", program.ConvertToWords("123456789012345678.20"));
        }
        [TestMethod]
        public void TestMethod3_RightResultNoDecimal()
        {
            var program = new ConsoleApplication2.Program();
            Assert.AreEqual("One Hundred Twenty-Three Thousand Four Hundred Fifty-Six Dollars ", program.ConvertToWords("123456"));
        }
        [TestMethod]
        public void TestMethod4_NotNumber_Null()
        {
            var program = new ConsoleApplication2.Program();
            Assert.AreEqual("Invalid Dollar Value", program.ConvertToWords(""));
        }
         [TestMethod]
        public void TestMethod5_NotNumber_Alphabet()
        {
            var program = new ConsoleApplication2.Program();
            Assert.AreEqual("Invalid Dollar Value", program.ConvertToWords("abcd"));
        }
         [TestMethod]
        public void TestMethod6_NotNumber_Symbol()
        {
            var program = new ConsoleApplication2.Program();
            Assert.AreEqual("Invalid Dollar Value", program.ConvertToWords("!@#"));
        }
         [TestMethod]
         public void TestMethod7_NotNumber_Minus()
         {
             var program = new ConsoleApplication2.Program();
             Assert.AreEqual("Invalid Dollar Value", program.ConvertToWords("-1"));
         }
         [TestMethod]
         public void TestMethod8_NotNumber_LimitNumber()
         {
             var program = new ConsoleApplication2.Program();
             Assert.AreEqual("Maximum Input 37 Characters", program.ConvertToWords("100000000000000000000000000000000000000"));
         }
         [TestMethod]
         public void TestMethod9_Decimal_NotNumber_Null()
         {
             var program = new ConsoleApplication2.Program();
             Assert.AreEqual("Invalid Cent Value", program.ConvertToWords("1234,"));
         }
         [TestMethod]
         public void TestMethod10_Decimal_NotNumber_Alphabet()
         {
             var program = new ConsoleApplication2.Program();
             Assert.AreEqual("Invalid Cent Value", program.ConvertToWords("1234,aa"));
         }
         [TestMethod]
         public void TestMethod11_Decimal_NotNumber_Symbol()
         {
             var program = new ConsoleApplication2.Program();
             Assert.AreEqual("Invalid Cent Value", program.ConvertToWords("1234,!@"));
         }

         [TestMethod]
         public void TestMethod12_Decimal_Zero_Comma()
         {
             var program = new ConsoleApplication2.Program();
             Assert.AreEqual("One Hundred Twenty-Three Dollars ", program.ConvertToWords("123.0"));
         }
         [TestMethod]
         public void TestMethod13_Decimal_Zero_Dot()
         {
             var program = new ConsoleApplication2.Program();
             Assert.AreEqual("One Hundred Twenty-Three Dollars ", program.ConvertToWords("123.0"));
         }
    }

}
