using LifePayTests.PageObjectModels;
using LifePayTests.Support;
using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities;
using NUnit.Framework;
using OpenQA.Selenium;
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

        [Given(@"данные авторизации известны")]
        public void GivenДанныеАвторизацииИзвестны()
        {
            _scenarioContext.Add("login", "+7 (911) 111-11-11");
            _scenarioContext.Add("pass", "@12345678#pass!");
        }

        [Given(@"незарегистрированный номер известен")]
        public void GivenНезарегистрированныйНомерИзвестен()
        {
            _scenarioContext.Add("unregLogin", "+7 (911) 111-11-12");
        }

        [Given(@"некорректный номер известен")]
        public void GivenНекорректныйНомерИзвестен()
        {
            _scenarioContext.Add("incorrectLogin", "+7 (911) 111-11-1");
        }

        [Given(@"некорректный пароль известен")]
        public void GivenНекорректныйПарольИзвестен()
        {
            _scenarioContext.Add("incorrectPass", "@1234");
        }

        [When(@"происходит нажатие на ссылку '([^']*)'")]
        public void WhenПроисходитНажатиеНаСсылку(string linkName)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            switch (linkName)
            {
                case "Восстановить пароль":
                    _pageObjectModel.linkRecoveryPasswordElement.Click();
                    break;
                case "Заведите аккаунт":
                    _pageObjectModel.newUserRegElement.Click();
                    break;
            }
        }

        [When(@"поле ввода Номер телефона заполнено")]
        public void WhenПолеВводаНомерТелефонаЗаполнено()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            _pageObjectModel.inputTelephoneElement.Clear();
            _pageObjectModel.inputTelephoneElement.SendKeys((string)_scenarioContext["login"]);
        }

        [When(@"поле ввода Пароль заполнено")]
        public void WhenПолеВводаПарольЗаполнено()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            _pageObjectModel.inputPasswordElement.Clear();
            _pageObjectModel.inputPasswordElement.SendKeys((string)_scenarioContext["pass"]);
        }

        [Then(@"отображается '([^']*)'")]
        public void ThenОтображается(string message)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);    
            Assert.IsTrue(_pageObjectModel.MessageElement(message).Displayed, "Greeting message is wrong");
            driver.Close();
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
                driver.Close();
            }
            catch
            {
                Console.WriteLine("URL is wrong");
            }
        }

        [Then(@"поля ввода принимают соответствующие значения")]
        public void ThenПоляВводаПринимаютСоответствующиеЗначения()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            string currentLogin = _pageObjectModel.inputTelephoneElement.GetAttribute("value");
            string currentPass = _pageObjectModel.inputPasswordElement.GetAttribute("value");
            
            try
            {
                Assert.AreEqual((string)_scenarioContext["login"], currentLogin);
                Assert.AreEqual((string)_scenarioContext["pass"], currentPass);
                driver.Close();
            }
            catch 
            {
                Console.WriteLine("Fillment of fields is wrong");
            } 
        }

        [Then(@"отображается сообщение Номер не зарегистрирован")]
        public void ThenОтображаетсяСообщениеНомерНеЗарегистрирован()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            Thread.Sleep(250);
            Assert.IsTrue(_pageObjectModel.noRegNumberElement.Displayed, "Message is missing");
            driver.Close();
        }

        [Then(@"отображается сообщение Введите номер в формате '([^']*)'")]
        public void ThenОтображаетсяСообщениеВведитеНомерВФормате(string p0)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            Assert.IsTrue(_pageObjectModel.inputCorrectNumberElement.Displayed, "Message is missing");
            driver.Close();
        }

        [Then(@"отображается сообщение Значение должно быть не менее (.*) знаков")]
        public void ThenОтображаетсяСообщениеЗначениеДолжноБытьНеМенееЗнаков(int p0)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new SignInPage(driver);
            Assert.IsTrue(_pageObjectModel.inputCorrectPasswordElement.Displayed, "Message is missing");
            driver.Close();
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
