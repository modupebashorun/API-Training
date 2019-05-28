using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Training0.TraditionalSeleniumWithoutSpecflow
{
    [TestClass]
    public class TraditionalSelenium
    {
        [TestMethod]
        public void BlueSkyFormValidation()
        {
            //1. Create Instance of the browser
            IWebDriver Driver;

            //2. Open the Browser
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10)

            Driver = new ChromeDriver();

            //3. Do your Test


            //3a) Navigate website
            Driver.Navigate().GoToUrl("http://qa1.giftrt.com/community/create");
            //3a i) Maximize the window
            Driver.Manage().Window.Maximize();

            //3b) Enter a test into textbox


            //3b i)Inspect your element
            //Done with f12 Developer Tool
            //3b ii)Decide on the attribute to use to find your element
            //Decide to ID
            //3b iii)Copy the attribute
            //nav-signin-tab
            Driver.FindElement(By.Id("nav-signin-tab")).Click();
            //user_email
            //3b iv)Wrie the code to find the element
            //Driver.FindElement(By.Id("user_email"));
            //3b v)Perform the action (ie Type into textbox)
            //enter Email Address 
            Driver.FindElement(By.Id("user_email")).SendKeys("b_bimpe@yahoo.co.uk");

            //enter the Password
            Driver.FindElement(By.Id("user_password")).SendKeys("Jawdan21");


            //3c) Select from a drop list


            //3d) Click a Sign In button
           

            IWebElement radio = Driver.FindElement(By.Id("btn_signin"));
            radio.Click();
            //*[@id='btn_signin']
            //Driver.FindElement(By.ClassName("font-size-15")).Displayed);

            //Assert.IsTrue(Driver.FindElement(By.ClassName("font-size-15")).Displayed);

           //Assert.IsTrue(Driver.FindElement(By.ClassName("font-size-15")).Displayed, "The name is not displayed");



            //4) Close Browser
            //Driver.Close();
        }
    }
}
