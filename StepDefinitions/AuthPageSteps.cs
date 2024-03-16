using NUnit.Framework;
using OpenQA.Selenium;
using PageObjectModels;
using Support;
using TechTalk.SpecFlow;


namespace StepDefinitions
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
            var signInPage = new SignInPage(driver);
            switch (linkName)
            {
                case "Восстановить пароль":
                    {
                        signInPage.LinkRecoveryPasswordElement.Click();
                        break;
                    }
                case "Заведите аккаунт":
                    {
                        signInPage.NewUserRegElement.Click();
                        break;
                    }
                default: new KeyNotFoundException(linkName);
                    break;
            }
        }
        
        [When(@"поле ввода '([^']*)' заполнено значением '([^']*)'")]
        public void WhenПолеВводаЗаполненоЗначением(string fieldName, string value)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var signInPage = new SignInPage(driver);
            switch (fieldName) 
            {
                case "Номер телефона":
                    signInPage.InputTelephoneElement.Clear();
                    signInPage.InputTelephoneElement.SendKeys(value);
                    break;

                case "Пароль":
                    signInPage.InputPasswordElement.Clear();
                    signInPage.InputPasswordElement.SendKeys(value);
                    break;
                default:
                    new KeyNotFoundException(fieldName);
                    break;
            }
        }


        [Then(@"отображается '([^']*)'")]
        public void ThenОтображается(string message)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var signInPage = new SignInPage(driver);    
            Assert.IsTrue(signInPage.MessageElement(message).Displayed, "Greeting message is wrong");
            
            ToolsForTests.setTime(ToolsForTests.GetAPITimeMoscow().Result);
        }

        [Then(@"происходит переход по ссылке '([^']*)'")]
        public void ThenПроисходитПереходПоСсылке(string link)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            string currentURL = driver.Url;
            Assert.AreEqual(link, currentURL, "URL is wrong");

        }
       
        [Then(@"отображается значение '([^']*)' в поле ввода '([^']*)'")]
        public void ThenОтображаетсяЗначениеВПолеВвода(string expectedValue, string fieldName)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var signInPage = new SignInPage(driver);
            switch (fieldName)
            {
                case "Номер телефона":
                    string actualPhoneNumber = signInPage.InputTelephoneElement.GetAttribute("value");
                    Assert.AreEqual(expectedValue, actualPhoneNumber, "Fillment of phone number field is wrong");
                    break;
                case "Пароль":
                    string actualPassword = signInPage.InputPasswordElement.GetAttribute("value");
                    Assert.AreEqual(expectedValue, actualPassword, "Fillment of password field is wrong");
                    break;
                default:
                    new KeyNotFoundException(fieldName);
                    break;
            }
        }

        [Then(@"отображается предупреждение '([^']*)' в поле '([^']*)'")]
        public void ThenОтображаетсяПредупреждениеВПоле(string expectedMessage, string fieldName)
        {
            var driver = (IWebDriver)_scenarioContext["driver"];
            var signInPage = new SignInPage(driver);
                switch (fieldName)
                {
                    case "Номер телефона":
                        Assert.AreEqual(expectedMessage, signInPage.WarningMessageNumberElement.Text, "Message is missing");
                        break;
                    case "Пароль":
                        Assert.AreEqual(expectedMessage, signInPage.WarningMessagePasswordElement.Text, "Message is missing");
                        break;
                    default:
                        new KeyNotFoundException(fieldName);
                        break;
                }
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
