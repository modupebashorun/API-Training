using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Training0.TraditionalSeleniumWithoutSpecflow
{
    [TestClass]
    public class ValidationOfForms
    {
        [TestMethod]
        public void ValidateTest()
        {
            
            IWebDriver Driver;

            Driver = new ChromeDriver();

            


            
            Driver.Navigate().GoToUrl("http://qa1.giftrt.com/community/create");
            
            Driver.Manage().Window.Maximize();

            
            Driver.FindElement(By.Id("nav-signin-tab")).Click();
            
            Driver.FindElement(By.Id("user_email")).SendKeys("b_bimpe@yahoo.co.uk");

            
            Driver.FindElement(By.Id("user_password")).SendKeys("Jawdan21");


            
            Driver.FindElement(By.Id("btn_signin")).Click();

            //Driver.FindElement(By.ClassName("nav-link")).Click();

            //1Thread.Sleep(5000);

            //Implicit waits
            //Tells you webdriver to pull down for certain amount of time in order to find the element
            //By default it is set to zero

            //When do I need to wait/ When is it required

            //a)For a page to load
            //b)For a java script or ajax to finish
            //c)When new form or message is displayed/upload on a form

            //2 Implicit waits
            //Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            //3 Explicit wait
            //WebDriverWait wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(10));

            //Func<IWebDriver, bool> waitForElent = new Func<IWebDriver, bool>(IWebDriver web) =>
                {
                //web.FindElement(By.ClassName("font-size-15")).Displayed));
                //return true;
            }
                
   

         

           

            Assert.IsTrue(Driver.FindElement(By.ClassName("font-size-15")).Displayed);

            Assert.IsTrue(Driver.FindElement(By.ClassName("font-size-15")).Displayed, "The name is not displayed");

            //Waiting

            //Thread.Sleep(5000)

            //Explicit and Implicit wait

            //Fluents wait

           // Driver.Close();

        }
    }
}
