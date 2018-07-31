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
    
    static class Elements
    {
        static IWebDriver driver = Program.driver;

            public static String RegistrationButtonLocator = "body > div.wrapper > div > div.header-main.closed > div > div.header-area-sticky.no-transition > div.header-main-area > div > div.header-area-left > div.header-login > ul > li:nth-child(2) > a";
        public static IWebElement RegstrationButton = driver.FindElement(By.CssSelector(RegistrationButtonLocator));

            public static String RegionApproveButtonLocator = "#tooltipster-15729 > div.tooltipster-box > div > div > div > a.btn.btn-approve-city";
        public static IWebElement RegionApproveButton = driver.FindElement(By.CssSelector(RegionApproveButtonLocator));







    }



}
