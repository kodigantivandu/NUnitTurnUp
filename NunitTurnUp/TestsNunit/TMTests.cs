using NUnit.Framework;
using NunitTurnUp.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NunitTurnUp.Utilities;

namespace NunitTurnUp.TestsNunit
{
    [TestFixture]
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void SetUpTM()
        {
            //Open the Chrome browser
             driver = new ChromeDriver();
            //Maximize the browser
            driver.Manage().Window.Maximize();

            //Inization object for Login page
            Login Loginobj = new Login();
            Loginobj.Loginaction(driver);


            //Inization object for Home page
            HomePage homePageObj = new HomePage();
            homePageObj.GotoTMpage(driver);

        }
        //Test 1
        [Test, Order(1)]
        public void TestCreateTMRecord()
        {
            //Inization object for TMPages page
            TMactions TMPageObj = new TMactions();
            TMPageObj.CreateTMRecord(driver);

        }
        //Test 2

        [Test, Order(2)]
        public void TestEditTMRecord()
        {
            TMactions TMPageObj = new TMactions();
            TMPageObj.EditTMRecord(driver);

        }
        //Test 3

        [Test,Order(3)]
        public void TestDeleteTMRecord()
        {
            TMactions TMPageObj = new TMactions();
            TMPageObj.DeleteTMRecord(driver);
        }
        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();

        }

    }
}
