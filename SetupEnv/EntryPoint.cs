using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.IO;
using System.Reflection;
using System.Threading;

class EntryPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location));
        driver.Navigate().GoToUrl("http://google.com");
        driver.FindElement(By.Name("q")).SendKeys("Mitrais");
        driver.FindElement(By.Name("q")).Submit();
        Thread.Sleep(3000);
        driver.Quit();
    }
}

