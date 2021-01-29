using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testimi_det2.TS.Kosovo_Police
{
    class RedirectingToRaportoKriminApp
    {
        [Test]
        public static void RedirectToRaportoKrimin()
        {
            Action.InitializeDriver("Chrome", Config.KosovoPolice.homepage);

            Action.waitSomeTime(2);

            Driver.driver.FindElement(By.XPath(Config.KosovoPolice.raportoKriminIMGXPath)).Click();

            Action.waitSomeTime(2);
            Assert.IsTrue((Driver.driver.PageSource.Contains(Config.KosovoPolice.raportoKriminString) && (Driver.driver.FindElement(By.XPath(Config.KosovoPolice.dergoButtonXPath)).Displayed)));

        }

        [Test]
        public static void RidirectOfficialFacebookProfile()
        {
            Action.InitializeDriver("Chrome", Config.KosovoPolice.homepage);

            //Action.waitSomeTime(2);

            //Driver.driver.FindElement(By.Id(Config.KosovoPolice.contactTab)).Click();

            Action.waitSomeTime(5);

            Driver.driver.FindElement(By.XPath(Config.KosovoPolice.FBProfileLinkXPath)).Click();

            Action.waitSomeTime(5);

            Assert.AreEqual(Driver.driver.PageSource.Contains(Config.KosovoPolice.notAvailableFBPage), false);




        }
    }
}
