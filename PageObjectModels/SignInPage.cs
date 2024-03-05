using OpenQA.Selenium;

namespace LifePayTests.PageObjectModels
{
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
        public IWebElement greetingMessageElement => _driver.FindElement(By.XPath("//h2[contains(text(),'Добр')]"));
        
        /// <summary>
        /// Элемент логотипа
        /// </summary>
        public IWebElement logoElement => _driver.FindElement(By.XPath("//div [@class='logo-bar']"));

        /// <summary>
        /// Элемент заголовка бокового текста
        /// </summary>
        public IWebElement sideTitleElement => _driver.FindElement(By.XPath("//h2[contains(text(),'Зайдите в личный кабинет')]"));

        /// <summary>
        /// Элемент переключателя отображения пароля
        /// </summary>
        public IWebElement switchPasswordHide => _driver.FindElement(By.XPath("//div [@class='svg-wrapper password-input ng-star-inserted']"));

        /// <summary>
        /// Элемент ссылки для восстановления пароля
        /// </summary>
        public IWebElement linkRecoveryPasswordElement => _driver.FindElement(By.XPath("//a [@routerlink='/auth/recovery']"));

        /// <summary>
        /// Элемент кнопки входа в личный кабинет
        /// </summary>
        public IWebElement loginButtonElement => _driver.FindElement(By.XPath("//div [@class='login-button-wrapper']"));

        /// <summary>
        /// Элемент ссылки для создания аккаунта
        /// </summary>
        public IWebElement newUserRegElement => _driver.FindElement(By.XPath("//a [@id='signin-lk']"));

        /// <summary>
        /// Элемент текста Номер не зарегистрирован
        /// </summary>
        public IWebElement noRegNumberElement => _driver.FindElement(By.XPath("//small [contains(text(), 'Номер не зарегистрирован')]"));

        /// <summary>
        /// Элемент текста Введите телефон в формате +7(911)111-11-11
        /// </summary>
        public IWebElement inputCorrectNumberElement => _driver.FindElement(By.XPath("//small [contains(text(), 'Введите телефон в формате +7(911)111-11-11')]"));

        /// <summary>
        /// Элемент текста Введите телефон в формате +7(911)111-11-11
        /// </summary>
        public IWebElement inputCorrectPasswordElement => _driver.FindElement(By.XPath("//small [contains(text(), 'Значение должно быть не менее 6 знаков')]"));

        /// <summary>
        /// Элемент заголовка приветственного сообщения (Геркин)
        /// </summary>
        public IWebElement MessageElement(string message)
        {
            return _driver.FindElement(By.XPath("//h2[contains(text(),'" + message + "')]"));
        }

    }
}
