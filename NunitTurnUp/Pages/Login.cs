using NunitTurnUp.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTurnUp.Pages
{
    public class Login : CommonDriver
    {
        public void Loginaction(IWebDriver driver)
        {
            //Launch TurnUp portal and navigate to website login page
            driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");

        Console.WriteLine("2. Launch Application Successful");

            //Login in the application

            IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
        Thread.Sleep(1000);
            usernameTextBox.SendKeys("hari");

            //Identify password textbox and enter valid password
            IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
        passwordTextBox.SendKeys("123123");

            //Identify the login button and click on the button
            IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
        loginButton.Click();
            Thread.Sleep(1000);
        }
    }
}
