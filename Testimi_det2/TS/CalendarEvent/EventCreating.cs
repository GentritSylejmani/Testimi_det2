using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Testimi_det2.TS.CalendarEvent
{
    public class EventCreating
    {
        [Test]
        public static void CreateEventWithValidData()        
        {
            Action.InitializeDriver("Chrome");
            Action.LoginToEmail();

            Action.waitSomeTime(3);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.calendarButtonXPath)).Click();

            Action.waitSomeTime(5);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.newCalendarEventButtonXPath)).Click();

            string randEvent = Config.Hotmail.GenerateRString();

            Action.waitSomeTime(5);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.eventTitleInputXPath)).SendKeys(randEvent);

            Action.waitSomeTime(2);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.saveEventButtonXPath)).Click();

            Action.waitSomeTime(2);

            Assert.IsTrue(Driver.driver.PageSource.Contains(randEvent));

        }

        [Test]
        public static void ConfirmCreateEventWithoutTitle()
        {
            Action.InitializeDriver("Chrome");
            Action.LoginToEmail();

            Action.waitSomeTime(3);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.calendarButtonXPath)).Click();

            Action.waitSomeTime(5);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.newCalendarEventButtonXPath)).Click();

            string randEvent = Config.Hotmail.GenerateRString();

            Action.waitSomeTime(2);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.saveEventButtonXPath)).Click();

            Action.waitSomeTime(4);

            Driver.driver.FindElement(By.XPath(Config.Hotmail.confirmEventCreationButtonXPath)).Click();

            Action.waitSomeTime(3);

            Assert.IsTrue(Driver.driver.PageSource.Contains(Config.Hotmail.noSubjectEvent));
        }
    }
}
