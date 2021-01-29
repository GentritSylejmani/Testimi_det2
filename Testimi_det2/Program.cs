using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace Testimi_det2
{
    class Program
    {
        public static IWebDriver driver { get; set; }
        private static void RedMessage (string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            
        }

        private static void GreeMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;

        }

        static void Main(string[] args)
        {

            //TS.EmailSending.SendWithoutRecipient();



            //if(owa.Displayed)
            //{
            //    GreeMessage("I can see it!");
            //}
            //else
            //{
            //    RedMessage("Nope, it's not there!");
            //}
        }
    }
}
