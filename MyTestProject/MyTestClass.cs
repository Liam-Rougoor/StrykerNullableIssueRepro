using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySourceApp;

namespace MyTestProject
{
    [TestClass]
    public class MyTestClass
    {
        [TestMethod]
        public void MyTestMethod()
        {
            Assert.IsTrue(MyClass.MyMethod(0));
        }
    }
}