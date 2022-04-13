using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using System.Diagnostics;

namespace teste
{
    [TestClass]
    public class TestInitialize
    {
        public AppiumDriver<AppiumWebElement> driver;
        public TimeSpan DefaultTimeout = TimeSpan.FromSeconds(200);
        [TestInitialize]
        public void Initialization()
        {
			DesiredCapabilities cap = new DesiredCapabilities();
			cap.SetCapability("platformName", "Android");
			cap.SetCapability("deviceName", "MI 8");
			cap.SetCapability("appPackage", "com.muiu.calculator");
			cap.SetCapability("appActivity", "com.muiu.calculator.cal.CaclulatorActivity");
            //cap.SetCapability("appWaitActivity", "com.muiu.calculator.cal.CaclulatorActivity");

            driver = new AndroidDriver<AppiumWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"), cap);
		}
    }
}
