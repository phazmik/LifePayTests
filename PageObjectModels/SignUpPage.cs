using OpenQA.Selenium;

namespace PageObjectModels
{
    /// <summary>
    /// Элементы страницы Регистрации
    /// </summary>
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
        public IWebElement GreetingMessageElement => _driver.FindElement(By.XPath("//h2[contains(text(),'Добр')]"));

        /// <summary>
        /// Элемент окна ввода кода из СМС
        /// </summary>
        public IWebElement InputPasswordSMSElement => _driver.FindElement(By.XPath("//input [@wfd-id='id1']"));

        /// <summary>
        /// Элемент окна ввода имени и фамилии
        /// </summary>
        public IWebElement InputNameElement => _driver.FindElement(By.XPath("//input [@wfd-id='id2']"));

        /// <summary>
        /// Элемент заголовка колонки текста
        /// </summary>
        public IWebElement SideTitleElement => _driver.FindElement(By.XPath("//h2 [contains (text(), 'Созд')]"));

        /// <summary>
        /// Элемент тела кнопки Отправить код
        /// </summary>
        public IWebElement SendCodeButtonElement => _driver.FindElement(By.XPath("//lp-ui-button [@elementid='send-sms-verification']"));

        /// <summary>
        /// Элемент тела кнопки Создайте личный кабинет
        /// </summary>
        public IWebElement CreateLKButtonElement => _driver.FindElement(By.XPath("//lp-ui-button [@elementid='create-lk']"));

        /// <summary>
        /// Элемент текста Уже имеете аккаунт в LIFE POS?
        /// </summary>
        public IWebElement SignInTextElement => _driver.FindElement(By.XPath("//span [contains (text(), 'Уже')]"));

        /// <summary>
        /// Элемент ссылки Войдите
        /// </summary>
        public IWebElement SignInLinkElement => _driver.FindElement(By.XPath("//a [@id='skip-signin']"));

        /// <summary>
        /// Элемент текста Нужна помощь?
        /// </summary>
        public IWebElement HelpTextElement => _driver.FindElement(By.XPath("//span [contains (text(), 'Уже')]"));

        /// <summary>
        /// Элемент ссылки  Напишите нам
        /// </summary>
        public IWebElement HelpLinkElement => _driver.FindElement(By.XPath("//a [@id='skip-signin']"));

        /// <summary>
        /// Элемент текста Создавая личный кабинет, вы соглашаетесь с
        /// </summary>
        public IWebElement UserAgreementTextElement => _driver.FindElement(By.XPath("//span [contains (text(), 'Уже')]"));

        /// <summary>
        /// Элемент ссылки пользовательским соглашением
        /// </summary>
        public IWebElement TermLinkElement => _driver.FindElement(By.XPath("//a [@id='term']"));

        /// <summary>
        /// Элемент ссылки оферту
        /// </summary>
        public IWebElement OfferLinkElement => _driver.FindElement(By.XPath("//a [@id='offer']"));
    }
}
