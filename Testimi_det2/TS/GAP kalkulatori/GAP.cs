using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;

namespace Testimi_det2.TS.GAP_kalkulatori
{
    public class GAP
    {
        [Test]
        public static void CalculateCarTaxWithValidValues()
        {
            Action.InitializeDriver("Chrome", Config.GAP.homepage);

            Driver.driver.FindElement(By.XPath(Config.GAP.ekonomiaVeturaveButtonXPath)).Click();

            Action.waitSomeTime(3);

            Driver.driver.FindElement(By.XPath(Config.GAP.taxCalculatorTabXPath)).Click();



        }

        public static void CalculateCarTaxWithInvalidValues()
        {

        }
    }
}
