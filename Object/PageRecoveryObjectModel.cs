using OpenQA.Selenium;

namespace LifePayTests.Object
{
    public class PageRecoveryObjectModel
    {
        private readonly IWebDriver _driver;
        public PageRecoveryObjectModel(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Элемент текстового заголовка 
        /// </summary>
        public IWebElement titleTextElement => _driver.FindElement(By.XPath("//h2[@class='title']"));

        /// <summary>
        /// Элемент логотипа
        /// </summary>
        public IWebElement logoElement => _driver.FindElement(By.XPath("//div [@class='logo-bar']"));

        /// <summary>
        /// Элемент кнопки Назад
        /// </summary>
        public IWebElement backButtonElement => _driver.FindElement(By.XPath("//button [1]"));

        /// <summary>
        /// Элемент окна ввода номера телефона
        /// </summary>
        public IWebElement inputTelephoneElement => _driver.FindElement(By.XPath("//input [@type='tel']"));

        /// <summary>
        /// Элемент окна ввода кода из СМС
        /// </summary>
        public IWebElement inputPasswordSMSElement => _driver.FindElement(By.XPath("//input [@type='text']"));

        /// <summary>
        /// Элемент кнопки Отправить код
        /// </summary>
        public IWebElement sendCodeButtonElement => _driver.FindElement(By.XPath("//button [2]"));

        /// <summary>
        /// Элемент кнопки Продолжить
        /// </summary>
        public IWebElement continueButtonElement => _driver.FindElement(By.XPath("//button [@id='continue-restore-pass']"));

        /// <summary>
        /// Элемент заголовка колонки текста
        /// </summary>
        public IWebElement sideTitleElement => _driver.FindElement(By.XPath("//h2 [contains (text(), 'Восстановите')]"));

        /// <summary>
        /// Элемент тела колонки текста
        /// </summary>
        public IWebElement sideBodyTextElement => _driver.FindElement(By.XPath("//ul [@_ngcontent-hfo-c280]"));
    }
}
