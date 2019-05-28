using System;
using TechTalk.SpecFlow;
using Training0.Page_Objects;
using Training0.Utilities;

namespace Training0.Step_Definitions
{
    [Binding]
    public class RegistrationsSteps
    {
        RegistrationPage registration;

        public RegistrationsSteps()
        {
            registration = new RegistrationPage();
        }

        [Given(@"I navigate to the site")]
        public void GivenINavigateToTheSite()
        {
            Hooks.Driver.Navigate().GoToUrl("http://www.giftrete.com");
            Hooks.Driver.Manage().Window.Maximize();

        }
        
        [When(@"Click on the register link")]
        public void WhenClickOnTheRegisterLink()
        {
            registration.ClickOnRegister();

           
        }
        
        [When(@"I enter firstname")]
        public void WhenIEnterFirstname()
        {
            registration.EnterFirstName();

        }
        
        [When(@"I enter last name")]
        public void WhenIEnterLastName()
        {
            registration.EnterLastName();
        }

        [When(@"I enter email ""(.*)""")]
        public void WhenIEnterEmail(string email)
        {
            registration.EnterEmailAddress(email);

     
        }
        [When(@"I enter email\#")]
        public void WhenIEnterEmail()
        {

            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter mobile number")]
        public void WhenIEnterMobileNumber()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I enter password")]
        public void WhenIEnterPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I confirm password")]
        public void WhenIConfirmPassword()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on signup")]
        public void WhenIClickOnSignup()
        {
            registration.ClickSignUp();

        }
        
        [Then(@"I should be registered")]
        public void ThenIShouldBeRegistered()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
