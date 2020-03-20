using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assignment.View;
using Assignment.View.Views;

namespace AssignmentUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            SplashScreen register = new SplashScreen();
            register.Show();
            register.Close();
        }
    }
}
