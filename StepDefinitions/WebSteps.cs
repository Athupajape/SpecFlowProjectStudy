using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SpecFlowProject.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class WebSteps
    {
        IWebDriver iwebDriver;
        User _user;
        FeatureContext _fc;
        ScenarioContext _sc;

        public WebSteps(User user, FeatureContext fc, ScenarioContext sc)
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            iwebDriver = new ChromeDriver();
            _user = user;
            _fc = fc;
            _sc = sc;
        }

        [BeforeFeature]
        public static void BeforeFeature(FeatureContext fc)
        {
            Console.WriteLine(fc.FeatureInfo.Description);
        }

        [BeforeScenario]
        public void BeforeScenario()
        {
            //1. We can save information related to the scenario.
            //2.Create the object of webdriver;
            Console.WriteLine(_sc.ScenarioInfo.Title);
        }

        [AfterScenario]
        public void AfterScenario(ScenarioContext sc)
        {
            //We can close the browser.
            //2.Reports
            iwebDriver.Quit();
            Console.WriteLine(sc.ScenarioInfo.Description);
        }

        [BeforeStep]
        public void BeforeStep(ScenarioContext sc)
        {
            //WE can save information of steps.
        }

        [AfterStep]
        public void AfterStep(ScenarioContext sc)
        {
            //1. Take screenshot of failed step and then attach it to the html.
            if (sc.TestError != null)
            {
                string base64=((ITakesScreenshot)iwebDriver).GetScreenshot().AsBase64EncodedString;
            }
        }


        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            iwebDriver.Navigate().GoToUrl(Runner.configurationRoot["url"]);
        }

        [When(@"I provide username (.*)")]
        public void WhenIProvideUsername(string username)
        {
            iwebDriver.FindElement(By.Id("user-name")).SendKeys(username);
        }

        [When(@"I provide password (.*)")]
        public void WhenIProvidePassword(string password)
        {
            iwebDriver.FindElement(By.Id("password")).SendKeys(password);
        }

        [When(@"I select login")]
        public void WhenISelectLogin()
        {
            iwebDriver.FindElement(By.Id("login-button")).Click();
        }

        [Then(@"I am shown a dashboard of the application")]
        public void ThenIAmShownADashboardOfTheApplication()
        {
            int count=iwebDriver.FindElements(By.XPath("//div[text()='Swag Labs']")).Count;
            Assert.That(count, Is.EqualTo(1));
        }

        [Then(@"user adds firstname and lastname")]
        public void ThenUserAddsFirstnameAndLastname()
        {
            _fc["EmployeeFullName"] = "Jack";
            _user._firstname = "Dan";
            _user._lastname = "Brown";
        }


        [Then(@"I am shown the user details\.")]
        public void ThenIAmShownTheUserDetails_()
        {
            throw new PendingStepException();
        }

    }
}
