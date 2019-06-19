using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumNUnitParam
{
    public class BrowserTest : Hooks
    {


        [Test]
        public void GoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("Selenium");
            System.Threading.Thread.Sleep(5000);
            Driver.FindElement(By.Name("btnK")).Click();
            Assert.That(Driver.PageSource.Contains("Selenium"), Is.EqualTo(true),
                                            "The text selenium doest not exist");

        }

        [Test]
        public void AutomationTest()
        {
            Driver.Navigate().GoToUrl("http://autotest.in/service/Loan_Management_System_old/index.php");
            Driver.FindElement(By.Name("email")).SendKeys("admin@gmail.com");
            Driver.FindElement(By.Name("pass")).SendKeys("admin");
            Driver.FindElement(By.Name("login")).Click();
            System.Threading.Thread.Sleep(2000);
            Assert.That(Driver.PageSource.Contains("Dashboard"), Is.EqualTo(true),
                                            "The text welcome admin doest not exist");

        }


    }
}
