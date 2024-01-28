using NunitTurnUp.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTurnUp.TMStepDefinitions
{
    [Binding]
    public class TMStepDefinitions
    {
        IWebDriver driver = new ChromeDriver();
        Login LoginPageObj = new Login();
        HomePage homePageObj = new HomePage();
        TMactions tmPageObj = new TMactions();

        [Given(@": User login to Turnup portal using ""([^""]*)"" and ""([^""]*)""")]
        public void GivenUserLoginToTurnupPortalUsingAnd(string username, string password)
        {
            LoginPageObj.Loginaction(driver);
        }


        [Given(@": User login to Turnup portal")]
        public void GivenUserLoginToTurnupPortal()
        {
            var username = "hari";
            var pswd = "123123";
            LoginPageObj.Loginaction(driver);
                      
        }

        [When(@":  User navigates to TM page")]
        public void WhenUserNavigatesToTMPage()
        {
            homePageObj.GotoTMpage(driver);

        }

        [When(@":   User creates new TM record")]
        public void WhenUserCreatesNewTMRecord()
        {
            tmPageObj.CreateTMRecord(driver);

        }

        [Then(@":  User save TM record")]
        public void ThenUserSaveTMRecord()
        {
          

        }
    }
}
