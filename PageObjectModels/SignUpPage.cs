using OpenQA.Selenium;

namespace LifePayTests.PageObjectModels
{
    public class SignUpPage : CommonPageObjects
    {
        private readonly IWebDriver _driver;
        public SignUpPage(IWebDriver driver) : base(driver)
        { 
            _driver = driver; 
        }
        /// <summary>
        /// Элемент заголовка приветственного сообщения
        /// </summary>
        public IWebElement greetingMessageElement => _driver.FindElement(By.XPath("//h2[contains(text(),'Добр')]"));

        /// <summary>
        /// Элемент окна ввода кода из СМС
        /// </summary>
        public IWebElement inputPasswordSMSElement => _driver.FindElement(By.XPath("//input [@wfd-id='id1']"));

        /// <summary>
        /// Элемент окна ввода имени и фамилии
        /// </summary>
        public IWebElement inputNameElement => _driver.FindElement(By.XPath("//input [@wfd-id='id2']"));

        /// <summary>
        /// Элемент заголовка колонки текста
        /// </summary>
        public IWebElement sideTitleElement => _driver.FindElement(By.XPath("//h2 [contains (text(), 'Созд')]"));

        /// <summary>
        /// Элемент тела приветственного сообщения
        /// </summary>
        public IWebElement greetingMessageBodyElement => _driver.FindElement(By.XPath("//div [@class='description']"));

        /// <summary>
        /// Элемент тела кнопки Отправить код
        /// </summary>
        public IWebElement sendCodeButtonElement => _driver.FindElement(By.XPath("//lp-ui-button [@elementid='send-sms-verification']"));

        /// <summary>
        /// Элемент тела кнопки Создайте личный кабинет
        /// </summary>
        public IWebElement createLKButtonElement => _driver.FindElement(By.XPath("//lp-ui-button [@elementid='create-lk']"));

        /// <summary>
        /// Элемент текста Уже имеете аккаунт в LIFE POS?
        /// </summary>
        public IWebElement signInTextElement => _driver.FindElement(By.XPath("//span [contains (text(), 'Уже')]"));

        /// <summary>
        /// Элемент ссылки Войдите
        /// </summary>
        public IWebElement signInLinkElement => _driver.FindElement(By.XPath("//a [@id='skip-signin']"));

        /// <summary>
        /// Элемент текста Нужна помощь?
        /// </summary>
        public IWebElement helpTextElement => _driver.FindElement(By.XPath("//span [contains (text(), 'Уже')]"));

        /// <summary>
        /// Элемент ссылки  Напишите нам
        /// </summary>
        public IWebElement helpLinkElement => _driver.FindElement(By.XPath("//a [@id='skip-signin']"));

        /// <summary>
        /// Элемент текста Создавая личный кабинет, вы соглашаетесь с
        /// </summary>
        public IWebElement userAgreementTextElement => _driver.FindElement(By.XPath("//span [contains (text(), 'Уже')]"));

        /// <summary>
        /// Элемент ссылки пользовательским соглашением
        /// </summary>
        public IWebElement termLinkElement => _driver.FindElement(By.XPath("//a [@id='term']"));

        /// <summary>
        /// Элемент ссылки оферту
        /// </summary>
        public IWebElement offerLinkElement => _driver.FindElement(By.XPath("//a [@id='offer']"));
    }
}
