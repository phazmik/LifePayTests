using LifePayTests.Object;
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
        public static ToolsForTests? toolsForTests;
        public AuthPageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
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

        [Then(@"отображается '([^']*)'")]
        public void ThenОтображается(string message)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new PageSignInObjectModel(driver);    
            Assert.IsTrue(_pageObjectModel.MessageElement(message).Displayed, "Greeting message is wrong");
            driver.Close();
            ToolsForTests.setTime(ToolsForTests.GetAPITimeMoscow().Result);
        }

        [When(@"происходит нажатие на ссылку '([^']*)'")]
        public void WhenПроисходитНажатиеНаСсылку(string linkName)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new PageSignInObjectModel(driver);
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

        [Given(@"данные авторизации известны")]
        public void GivenДанныеАвторизацииИзвестны()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            toolsForTests = new ToolsForTests(driver)
            {
                _login = "+7 (911) 111-11-11",
                _pass = "@12345678#pass!"
            };
        }
        [When(@"поле ввода Номер телефона заполнено")]
        public void WhenПолеВводаНомерТелефонаЗаполнено()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new PageSignInObjectModel(driver);
            _pageObjectModel.inputTelephoneElement.Clear();
            _pageObjectModel.inputTelephoneElement.SendKeys(toolsForTests._login);
        }

        [When(@"поле ввода Пароль заполнено")]
        public void WhenПолеВводаПарольЗаполнено()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new PageSignInObjectModel(driver);
            _pageObjectModel.inputPasswordElement.Clear();
            _pageObjectModel.inputPasswordElement.SendKeys(toolsForTests._pass);
        }

        [Then(@"поля ввода принимают соответствующие значения")]
        public void ThenПоляВводаПринимаютСоответствующиеЗначения()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new PageSignInObjectModel(driver);
            string currentLogin = _pageObjectModel.inputTelephoneElement.GetAttribute("value");
            string currentPass = _pageObjectModel.inputPasswordElement.GetAttribute("value");
            
            try
            {
                Assert.AreEqual(toolsForTests._login, currentLogin);
                Assert.AreEqual(toolsForTests._pass, currentPass);
                driver.Close();
            }
            catch 
            {
                Console.WriteLine("Fillment of fields is wrong");
            } 
        }

        [Given(@"незарегистрированный номер известен")]
        public void GivenНезарегистрированныйНомерИзвестен()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            toolsForTests = new ToolsForTests(driver) 
            {
                _login = "+7 (911) 111-11-12" 
            };

        }

        [Then(@"отображается сообщение Номер не зарегистрирован")]
        public void ThenОтображаетсяСообщениеНомерНеЗарегистрирован()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new PageSignInObjectModel(driver);
            Thread.Sleep(250);
            Assert.IsTrue(_pageObjectModel.noRegNumberElement.Displayed, "Message is missing");
            driver.Close();
        }

        [Given(@"некорректный номер известен")]
        public void GivenНекорректныйНомерИзвестен()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            toolsForTests = new ToolsForTests(driver)
            {
                _login = "+7 (911) 111-11-1"
            };
        }

        [Then(@"отображается сообщение Введите номер в формате '([^']*)'")]
        public void ThenОтображаетсяСообщениеВведитеНомерВФормате(string p0)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new PageSignInObjectModel(driver);
            Assert.IsTrue(_pageObjectModel.inputCorrectNumberElement.Displayed, "Message is missing");
            driver.Close();
        }

        [Given(@"некорректный пароль известен")]
        public void GivenНекорректныйПарольИзвестен()
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            toolsForTests = new ToolsForTests(driver)
            {
                _pass = "@1234"
            };
        }

        [Then(@"отображается сообщение Значение должно быть не менее (.*) знаков")]
        public void ThenОтображаетсяСообщениеЗначениеДолжноБытьНеМенееЗнаков(int p0)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var _pageObjectModel = new PageSignInObjectModel(driver);
            Assert.IsTrue(_pageObjectModel.inputCorrectPasswordElement.Displayed, "Message is missing");
            driver.Close();
        }

    }
}
