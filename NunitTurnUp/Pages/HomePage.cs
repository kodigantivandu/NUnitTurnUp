using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTurnUp.Pages
{
    public class HomePage
    {
        public void GotoTMpage(IWebDriver driver)

        {
            //Navigate to Time & Material module (Click on Administration -> Time & Material link)
            IWebElement Admin = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            Thread.Sleep(1000);
            Admin.Click();

            IWebElement tANDm = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
        Thread.Sleep(1000);
            tANDm.Click();

        }
    }
}
