using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

namespace teste.PageObject
{
    [TestClass]
    public class ServicePage : TestInitialize
    {
        public ServicePage(AppiumDriver<AppiumWebElement> driver)
        {
            this.driver = driver;
        }

        public void Adicao()
        {
            driver.FindElementById("android:id/button1").Click();
            driver.FindElementById("com.miui.calculator:id/btn_2_s").Click();
            driver.FindElementById("com.miui.calculator:id/btn_plus_s").Click();
            driver.FindElementById("com.miui.calculator:id/btn_5_s").Click();
            driver.FindElementById("com.miui.calculator:id/btn_equal_s").Click();
        }

		public void Deslizar()
        {
			Thread.Sleep(5000);

			int startPx = 325;
			int startPy = 1156;
			int endPx = 284;
			int endPy = 485;

			TouchAction action = new TouchAction(driver);
			action.Press(startPx, startPy).MoveTo(endPx, endPy).Release().Perform();
			action.Press(startPx, startPy).MoveTo(endPx, endPy).Release().Perform();
			action.Press(startPx, startPy).MoveTo(endPx, endPy).Release().Perform();
		}

        public void testeBetaVirtualLoomMobile()
        {
			Thread.Sleep(1000);
			//var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, 20);
			//wait.until(ExpectedConditions.ElementIsVisible(By.XPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ListView/android.widget.LinearLayout[1]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[1]")));
			driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget" +
				".FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.view.ViewGroup/android.view" +
				".ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget" +
				".ListView/android.widget.LinearLayout[9]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup").Click();

			Thread.Sleep(1000);
			driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget" +
				".FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/android.view.ViewGroup/android.view" +
				".ViewGroup[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget" +
				".ListView/android.widget.LinearLayout[7]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.widget.TextView[1]").Click();
			Thread.Sleep(1000);
			driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android.widget" +
				".FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/androidx.drawerlayout.widget" +
				".DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view" +
				".ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.widget.ImageButton[2]").Click();
			Thread.Sleep(1000);
			driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android" +
				".widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/androidx.drawerlayout" +
				".widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android" +
				".view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ListView/android" +
				".widget.LinearLayout[2]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android" +
				".view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[2]/android.widget.TextView[2]").Click();

			driver.FindElementByXPath("/hierarchy/android.widget.FrameLayout/android.widget.LinearLayout/android.widget.FrameLayout/android" +
				".widget.FrameLayout/android.widget.FrameLayout/android.widget.RelativeLayout/android.view.ViewGroup/androidx.drawerlayout" +
				".widget.DrawerLayout/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android" +
				".view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup/android.widget.ListView/android.widget" +
				".LinearLayout[10]/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup/android.view.ViewGroup[2]/android.view" +
				".ViewGroup/android.view.ViewGroup[1]/android.view.ViewGroup[1]/android.widget.TextView[1]").Click();
			
		}

    }
}


