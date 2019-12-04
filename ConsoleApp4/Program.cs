using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.n11.com/");
            driver.FindElement(By.Id("searchData")).SendKeys("iphone");
            driver.FindElement(By.ClassName("icon")).Click();
        }
    }
}
