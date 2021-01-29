using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Testimi_det2
{
    public static class Action
    {
        public static void InitializeDriver(string driver, string url="" )
        {
            //if(driver=="Chrome")
            //{
            //    Driver.driver = new ChromeDriver();
            //}
            //if(driver=="Firefox")
            //{
            //    Driver.driver = new FirefoxDriver();
            //}
            ////etj etj browsera sipas nevojes

            if (string.IsNullOrEmpty(url))
            {
                url = Config.Hotmail.login_page;
            }
            Driver.driver = new ChromeDriver();
            Driver.driver.Navigate().GoToUrl(url);

            
        }
        public static void LoginToEmail()
        {
            Driver.driver.FindElement(By.Id(Config.Hotmail.emailInputElement)).SendKeys(Config.Hotmail.Credentials.email);
            Driver.driver.FindElement(By.Id(Config.Hotmail.nextButton)).Click();
            Thread.Sleep(2000);
            Driver.driver.FindElement(By.Id(Config.Hotmail.passwordInputElement)).SendKeys(Config.Hotmail.Credentials.password);
            Driver.driver.FindElement(By.Id(Config.Hotmail.nextButton)).Click();
            Thread.Sleep(2000);
        }
    }
}
