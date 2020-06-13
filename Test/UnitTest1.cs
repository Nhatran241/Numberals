using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Numberals;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        private TestContext testContextIntance;

        Program program = new Program();

        public TestContext TestContext
        {
            get { return testContextIntance; }
            set { testContextIntance = value; }
    }
        public void TestIsPrime(int n, int truevalue)
        {
            int result = program.isPrime(n);
            try
            {
                Assert.AreEqual(truevalue, result);
                TestContext.WriteLine("correct");
            }catch(Exception e)
            {
                TestContext.WriteLine("expected value is {0} but actual value is {1}",truevalue,result);
            }

        }
        public void TestGiaiThua(int n, long truevalue)
        {
            long result = program.TinhGiaiThua(n);
            try
            {
                Assert.AreEqual(truevalue, result);
                TestContext.WriteLine("correct");
            }
            catch (Exception e)
            {
                TestContext.WriteLine("expected value is {0} but actual value is {1}", truevalue, result);
            }

        }
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
            @"|DataDirectory|\Data\data_nguyento.csv", "data_nguyento#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethod1()
        {
            int firstNumber = Convert.ToInt32(testContextIntance.DataRow["inputNgto"]); 
            int expectedValue = Convert.ToInt32(testContextIntance.DataRow["ketquaNgto"]); 
            TestContext.WriteLine("{0} = {1}", firstNumber, expectedValue);
            TestIsPrime(firstNumber, expectedValue);
        }

        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.CSV",
           @"|DataDirectory|\Data\data_giaithua.csv", "data_giaithua#csv", DataAccessMethod.Sequential)]
        [TestMethod]
        public void TestMethod2()
        {
            int firstNumber = Convert.ToInt32(testContextIntance.DataRow["inputGiaiThua"]);
            int expectedValue = Convert.ToInt32(testContextIntance.DataRow["ketquaGiaiThua"]);
            TestContext.WriteLine("{0} = {1}", firstNumber, expectedValue);
            TestIsPrime(firstNumber, expectedValue);
        }
        static void Main() {
            UnitTest1 unitTest = new UnitTest1();
            unitTest.TestMethod1();
            unitTest.TestMethod2();
            Console.ReadLine();
        }
    }
}
