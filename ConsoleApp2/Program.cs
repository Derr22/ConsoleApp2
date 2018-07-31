using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Chrome;


namespace ConsoleApp2
{
    class Program
    {
        public static IWebElement WaitUntilElementExists(By elementLocator, int timeout = 100)
        {
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementExists(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                return driver.FindElement(elementLocator);
            }
        }
        public static IWebDriver driver = new ChromeDriver();

        static void Main(string[] args)
        {
            driver.Navigate().GoToUrl("https://www.mvideo.ru/");
            driver.Manage().Window.Maximize();
            //driver.Manage().Timeouts().ImplicitWait;
            System.Threading.Thread.Sleep(5000);
            // var waitRegion = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
            // waitRegion.Until(ExpectedConditions.ElementExists(By.XPath(Elements.RegistrationButtonLocator)));

            // WaitUntilElementExists(By.CssSelector(Elements.RegionApproveButtonLocator));
            try
            {
                var wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                     wait.Until(ExpectedConditions.ElementExists(By.CssSelector(Elements.RegionApproveButtonLocator)));
            }
            catch (Exception e)
            {
                Console.WriteLine("Element with locator: '" + Elements.RegionApproveButtonLocator + "' was not found in current context page.");
                    // driver.FindElement(elementLocator);
            }
            Elements.RegionApproveButton.Click();

               // var waitRegistration = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
                //waitRegistration.Until(ExpectedConditions.ElementExists(By.CssSelector(Elements.RegistrationButtonLocator)));


            Elements.RegstrationButton.Click();

        }
    }
}
