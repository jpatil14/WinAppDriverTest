using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinAppDriverTest.Base;

namespace WinAppDriverTest.Pages
{
    class CalculatorPage:BasePage
    {
        public WindowsElement btn9 => WindowsDriver.FindElementByAccessibilityId("num9Button");
        public WindowsElement btn5 => WindowsDriver.FindElementByAccessibilityId("num5Button");
        public WindowsElement btn7 => WindowsDriver.FindElementByAccessibilityId("num7Button");
        public WindowsElement btnPlus => WindowsDriver.FindElementByAccessibilityId("plusButton");
        public WindowsElement btnEqual => WindowsDriver.FindElementByAccessibilityId("equalButton");
        public WindowsElement calcResult => WindowsDriver.FindElementByAccessibilityId("CalculatorResults");

        public void performAddition()
        {
            btn9.Click();
            btnPlus.Click();
            btn5.Click();
            btnEqual.Click();
        }

        public string getResult()
        {
            return calcResult.Text;
        }

    }
}
