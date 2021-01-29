using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testimi_det2.TS
{
   public class EmailSending
    {
        [Test]
        public static void SendWithoutRecipient()
        {
            Action.InitializeDriver("Chrome");

            //Driver.driver.FindElement(By.Id(Config.Hotmail.emailInputElement)).SendKeys(Config.Hotmail.Credentials.email);
            //Driver.driver.FindElement(By.Id(Config.Hotmail.nextButton)).Click();
            //Thread.Sleep(2000);
            //Driver.driver.FindElement(By.Id(Config.Hotmail.passwordInputElement)).SendKeys(Config.Hotmail.Credentials.password);
            //Driver.driver.FindElement(By.Id(Config.Hotmail.nextButton)).Click();
            //Thread.Sleep(2000);

            Action.LoginToEmail();

            Driver.driver.FindElement(By.Id(Config.Hotmail.newEmailButton)).Click();
            Thread.Sleep(2000);
            //Driver.driver.FindElement(By.ClassName(Config.Hotmail.ricipientInputElementClass)).SendKeys(Config.Hotmail.validRicipient);
            Driver.driver.FindElement(By.ClassName(Config.Hotmail.sendButtonClass)).Click();
            Thread.Sleep(2000);
            Assert.IsTrue(Driver.driver.PageSource.Contains(Config.Hotmail.ricipientIsRequired));

        }
        [Test]
        public static void SendEmailToSelf()
        {
            Action.InitializeDriver("Chrome");
            Action.LoginToEmail();

            //Driver.driver.FindElement(By.Id(Config.Hotmail.emailInputElement)).SendKeys(Config.Hotmail.Credentials.email);
            //Driver.driver.FindElement(By.Id(Config.Hotmail.nextButton)).Click();
            //Thread.Sleep(2000);
            //Driver.driver.FindElement(By.Id(Config.Hotmail.passwordInputElement)).SendKeys(Config.Hotmail.Credentials.password);
            //Driver.driver.FindElement(By.Id(Config.Hotmail.nextButton)).Click();
            //Thread.Sleep(2000);
            Driver.driver.FindElement(By.Id(Config.Hotmail.newEmailButton)).Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.ClassName(Config.Hotmail.ricipientInputElementClass)).SendKeys(Config.Hotmail.Credentials.email);
            Driver.driver.FindElement(By.XPath(Config.Hotmail.subjectInputElement)).SendKeys(Config.Hotmail.subjectString);

            string randstring = Config.Hotmail.GenerateRString();

            Driver.driver.FindElement(By.ClassName(Config.Hotmail.bodyInputElementClass)).SendKeys(randstring);

            Driver.driver.FindElement(By.ClassName(Config.Hotmail.sendButtonClass)).Click();

            Thread.Sleep(10000);

            Assert.IsTrue(Driver.driver.PageSource.Contains(randstring));

        }
    }
}
