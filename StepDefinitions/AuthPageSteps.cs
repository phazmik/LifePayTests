using LifePayTests.PageObjectModels;
using LifePayTests.Support;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Diagnostics;
using TechTalk.SpecFlow;

namespace LifePayTests.StepDefinitions
{
    [Binding]
    public class AuthPageSteps
    {
        private readonly ScenarioContext _scenarioContext;
        public AuthPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"происходит нажатие на ссылку '([^']*)'")]
        public void WhenПроисходитНажатиеНаСсылку(string linkName)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            switch (linkName)
            {
                case "Восстановить пароль":
                    {
                        _pageObjectModel.linkRecoveryPasswordElement.Click();
                        break;
                    }
                case "Заведите аккаунт":
                    {
                        _pageObjectModel.newUserRegElement.Click();
                        break;
                    }
                default:
                    {
                        //TODO прописать действия при несрабатывании кейсов
                        break;
                    }
            }
        }

        [When(@"поле ввода Номер телефона заполнено значением '([^']*)'")]
        public void WhenПолеВводаНомерТелефонаЗаполненоЗначением(string phoneNumber)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            _pageObjectModel.inputTelephoneElement.Clear();
            _pageObjectModel.inputTelephoneElement.SendKeys(phoneNumber); 
        }

        [When(@"поле ввода Пароль заполнено значением '([^']*)'")]
        public void WhenПолеВводаПарольЗаполненоЗначением(string password)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            _pageObjectModel.inputTelephoneElement.Clear();
            _pageObjectModel.inputTelephoneElement.SendKeys(password);
        }

        [Then(@"отображается '([^']*)'")]
        public void ThenОтображается(string message)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);    
            Assert.IsTrue(_pageObjectModel.MessageElement(message).Displayed, "Greeting message is wrong");
            
            ToolsForTests.setTime(ToolsForTests.GetAPITimeMoscow().Result);
        }

        [Then(@"происходит переход по ссылке '([^']*)'")]
        public void ThenПроисходитПереходПоСсылке(string link)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            string currentURL = driver.Url;

            try
            {
                Assert.AreEqual(link, currentURL);
            }
            catch
            {
                Debug.WriteLine("URL is wrong");
            }
        }

        [Then(@"отображается значение '([^']*)' в поле ввода Номер телефона")]
        public void ThenОтображаетсяЗначениеВПолеВводаНомерТелефона(string expectedPhoneNumber)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            string actualPhoneNumber = _pageObjectModel.inputTelephoneElement.GetAttribute("value");
            Assert.AreEqual(expectedPhoneNumber,actualPhoneNumber, "Fillment of phone number field is wrong");
        }

        [Then(@"отображается значение '([^']*)' в поле ввода Пароль")]
        public void ThenОтображаетсяЗначениеВПолеВводаПароль(string expectedPassword)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            string actualPassword = _pageObjectModel.inputPasswordElement.GetAttribute("value");
            Assert.AreEqual(expectedPassword, actualPassword, "Fillment of password field is wrong");
        }

        [Then(@"отображается предупреждение '([^']*)' в поле Номер телефона")]
        public void ThenОтображаетсяПредупреждениеВПолеНомерТелефона(string expectedMessage)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            Assert.AreEqual(expectedMessage,_pageObjectModel.warningMessageNumberElement.Text, "Message is missing");
        }

        [Then(@"отображается предупреждение '([^']*)' в поле Пароль")]
        public void ThenОтображаетсяПредупреждениеВПолеПароль(string expectedMessage)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            Assert.AreEqual(expectedMessage, _pageObjectModel.warningMessagePasswordElement.Text, "Message is missing");
        }

        [Given(@"Открыта страница авторизации LifePay")]
        [When(@"Открыта страница авторизации LifePay")]
        public void GivenОткрытаСтраницаАвторизацииLifePay()
        {
            var driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://my.life-pos.ru/auth/login");
            driver.Manage().Window.Maximize();
            _scenarioContext.Add("driver", driver);
        }

        [Given(@"системное время равно (.*)")]
        [When(@"системное время равно (.*)")]
        public void WhenСистемноеВремяРавно(string hours)
        {
            ToolsForTests.setTime(hours);
        }
    }
}
