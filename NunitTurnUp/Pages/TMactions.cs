using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NunitTurnUp.Pages
{
    internal class TMactions
    {
        public void CreateTMRecord(IWebDriver driver)
        {
            //Click on Create button
            IWebElement createBuuton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createBuuton.Click();

            //Select Time from dropdown
            IWebElement typeCodeMainDropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
        typeCodeMainDropdown.Click();

            IWebElement typeCodeDropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
        Thread.Sleep(1000);
            typeCodeDropdown.Click();

            //Enter Code
            //  Wait.WaitToBeClickable(driver, "Id", "Code", 1);
            Thread.Sleep(1000);
            IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
        codeTextbox.SendKeys("Vandana Test");

            // Enter Description
            IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
        descriptionTextbox.SendKeys("Specflow Test ");

            //Enter price
            IWebElement priceTextbox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        priceTextbox.SendKeys("123");

            //Click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
        saveButton.Click();

            //Check if a new time record has been created successfully
            Thread.Sleep(1000);
            IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        goToLastPageButton.Click();


        }
        //Code for Edit Time Record
        public void EditTMRecord(IWebDriver driver)
        {
            //Click on Edit Button
            Thread.Sleep(1000);
            IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            Thread.Sleep(1000);

            //Edit Code in Code Textbox
            IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
        editCodeTextbox.Clear();
            editCodeTextbox.SendKeys("Vandu Edit");

            //Edit Description in Description Textbox
            IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
        editDescriptionTextBox.Clear();
            editDescriptionTextBox.SendKeys("Specflow edit");

            //Edit Price in Price Textbox
            IWebElement editPriceOverlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
        IWebElement editPriceTextBox = driver.FindElement(By.Id("Price"));
        editPriceOverlappingTag.Click();
            editPriceTextBox.Clear();
            editPriceOverlappingTag.Click();
            editPriceTextBox.SendKeys("500");

            //Click on save button
            IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
        editSaveButton.Click();
            Thread.Sleep(7000);

            // Clock on goToLastPage Button
            IWebElement editGoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
        editGoToLastPageButton.Click();

        }

        public void DeleteTMRecord(IWebDriver driver)
        {
            //Code for Delete Time Record
            IWebElement goToLastPageButton1 = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            goToLastPageButton1.Click();
            Thread.Sleep(3000);

            //Click on delete button
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
        deleteButton.Click();

            IAlert simpleAlert = driver.SwitchTo().Alert();
        simpleAlert.Accept();
        }

    }
}
