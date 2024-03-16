using OpenQA.Selenium;

namespace PageObjectModels
{
    /// <summary>
    /// Элементы страницы Авторизации
    /// </summary>
    public class SignInPage : CommonPageObjects
    {
        private readonly IWebDriver _driver;
        public SignInPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Элемент заголовка приветственного сообщения
        /// </summary>
        public IWebElement GreetingMessageElement => _driver.FindElement(By.XPath("//h2[contains(text(),'Добр')]"));
        
        /// <summary>
        /// Элемент заголовка бокового текста
        /// </summary>
        public IWebElement SideTitleElement => _driver.FindElement(By.XPath("//h2[contains(text(),'Зайдите в личный кабинет')]"));

        /// <summary>
        /// Элемент переключателя отображения пароля
        /// </summary>
        public IWebElement SwitchPasswordHide => _driver.FindElement(By.XPath("//div [@class='svg-wrapper password-input ng-star-inserted']"));

        /// <summary>
        /// Элемент ссылки для восстановления пароля
        /// </summary>
        public IWebElement LinkRecoveryPasswordElement => _driver.FindElement(By.XPath("//a [@routerlink='/auth/recovery']"));

        /// <summary>
        /// Элемент кнопки входа в личный кабинет
        /// </summary>
        public IWebElement LoginButtonElement => _driver.FindElement(By.XPath("//div [@class='login-button-wrapper']"));

        /// <summary>
        /// Элемент ссылки для создания аккаунта
        /// </summary>
        public IWebElement NewUserRegElement => _driver.FindElement(By.XPath("//a [@id='signin-lk']"));

        /// <summary>
        /// Элемент текста предупреждения поля Номер телефона
        /// </summary>
        public IWebElement WarningMessageNumberElement => _driver.FindElement(By.XPath("//lp-ui-input//label[text()='Номер телефона']//ancestor::lp-ui-input//small"));

        /// <summary>
        /// Элемент текста предупреждения поля Пароля
        /// </summary>
        public IWebElement WarningMessagePasswordElement => _driver.FindElement(By.XPath("//lp-ui-input//label[text()='Пароль']//ancestor::lp-ui-input//small"));

        /// <summary>
        /// Элемент заголовка приветственного сообщения (Геркин)
        /// </summary>
        public IWebElement MessageElement(string message)
        {
            return _driver.FindElement(By.XPath("//h2[contains(text(),'" + message + "')]"));
        }

    }
}
