using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            using (var driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)))
            {
                driver.Url = "http://www.google.com";
                driver.FindElement(By.Name("q")).SendKeys("Mitrais");
                driver.FindElement(By.Name("q")).Submit();
                Thread.Sleep(5000);
                driver.Close();
            }
        }
    }
}
