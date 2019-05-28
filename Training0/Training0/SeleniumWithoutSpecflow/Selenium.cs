using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Training0.SeleniumWithoutSpecflow
{
    [TestClass]
    public class Selenium
    {
        [TestMethod]
        public void GetMyGrade()
        {

            //1. Create Instance of the browser
            IWebDriver Driver;


            //2.Open the Browser
            Driver = new ChromeDriver();

            //3) Do your test
            //3a)Open the Website
            Driver.Navigate().GoToUrl("https://www.getmygrades.co.uk/");
            //3ai)Maximise the window
            Driver.Manage().Window.Maximize();
            //3b) Enter a text into textbox

            //3b i)Inspect your element
            //Done with developer tool
            //3b ii)Decide on the attribute to use to find your element
            //Decide to ID
            //3b iii) copy the attribute

            //3biv)Write the code to find the element
            //Driver.FindElement(By.XPath("//*[@id='menu - 1 - 37eb1ef4']/li[8]/a"));

            //3b v) perform the action(ie Type into the textbox)

            Driver.FindElement(By.CssSelector("#menu-1-37eb1ef4 > li.menu-item.menu-item-type-custom.menu-item-object-custom.menu-item-215646 > a")).Click();

            Driver.FindElement(By.ClassName("optanon - allow - all accept - cookies - button"));

            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            Driver.FindElement(By.Name("username")).SendKeys("Modupsy");

            Driver.FindElement(By.Name("password")).SendKeys("Jawdan21");

            Driver.FindElement(By.ClassName("gmg-form__button")).Click();

            

            

            //3b
            //3b)Enter a test into the form

            //3c) Select from a drop list

            //3d) Click a radio button

            //Clickon submit button

            //4)Close the Browser
            Driver.Close();
        }
    }
}
