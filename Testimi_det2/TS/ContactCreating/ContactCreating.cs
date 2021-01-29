using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testimi_det2.TS.ContactCreating
{
    public class ContactCreating
    {
        [Test]
        public static void CreateContactWithValidMailFormat()
        {
            Action.InitializeDriver("Chrome");
            Action.LoginToEmail();
            
            Thread.Sleep(5000);
            
            Driver.driver.FindElement(By.XPath(Config.Hotmail.contactsButtonXPath)).Click();
            Thread.Sleep(5000);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.newContactButtonXPath)).Click();

            Thread.Sleep(5000);

            Driver.driver.FindElement(By.Id(Config.Hotmail.newContactNameInput)).SendKeys(Config.Hotmail.newContactName);

            string randstring = Config.Hotmail.GenerateRString();

            Driver.driver.FindElement(By.Id(Config.Hotmail.newContactSurnameInput)).SendKeys(randstring);
            Driver.driver.FindElement(By.Id(Config.Hotmail.newContactEmailInput)).SendKeys(Config.Hotmail.validRicipient);

            Thread.Sleep(500);
            
            Driver.driver.FindElement(By.XPath(Config.Hotmail.createContactXPath)).Click();

            Thread.Sleep(1000);

            Assert.IsTrue(Driver.driver.PageSource.Contains(randstring));


        }
        [Test]
        public static void CreateContactWithInvalidMailFormat()
        {
            Action.InitializeDriver("Chrome");
            Action.LoginToEmail();

            Thread.Sleep(5000);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.contactsButtonXPath)).Click();
            Thread.Sleep(5000);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.newContactButtonXPath)).Click();

            Thread.Sleep(5000);

            Driver.driver.FindElement(By.Id(Config.Hotmail.newContactNameInput)).SendKeys(Config.Hotmail.newContactName);

            string randstring = Config.Hotmail.GenerateRString();
            string randEmail = Config.Hotmail.GenerateRString();

            Driver.driver.FindElement(By.Id(Config.Hotmail.newContactSurnameInput)).SendKeys(randstring);
            Driver.driver.FindElement(By.Id(Config.Hotmail.newContactEmailInput)).SendKeys(randEmail);

            Thread.Sleep(500);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.createContactXPath)).Click();

            Thread.Sleep(1000);

            Assert.IsTrue(Driver.driver.PageSource.Contains(Config.Hotmail.wrongEmailFormat));
        }
    }
}
