using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Appium.Windows;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using WinAppDriverTest.Base;

namespace WinAppDriverTest.Hooks
{
    [Binding]
    class TestInitialize
    {
        [BeforeScenario]
        public void TestSetup()
        {
            DesiredCapabilities dsrdCap = new DesiredCapabilities();
            dsrdCap.SetCapability("app", "Microsoft.WindowsCalculator_8wekyb3d8bbwe!App");
            BasePage.WindowsDriver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/"), dsrdCap);
        }

    }
}
