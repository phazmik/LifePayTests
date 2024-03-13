using OpenQA.Selenium;

namespace PageObjectModels
{
    /// <summary>
    /// Элементы общие для всех проверяемых страниц
    /// </summary>
    public class CommonPageObjects
    {
        private readonly IWebDriver _driver;
        public CommonPageObjects(IWebDriver driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Элемент логотипа
        /// </summary>
        public IWebElement LogoElement => _driver.FindElement(By.XPath("//div [@class='logo-bar']"));

        /// <summary>
        /// Элемент окна ввода номера телефона
        /// </summary>
        public IWebElement InputTelephoneElement => _driver.FindElement(By.XPath("//input [@type='tel']"));

        /// <summary>
        /// Элемент окна ввода пароля
        /// </summary>
        public IWebElement InputPasswordElement => _driver.FindElement(By.XPath("//input [@type='password']"));

        /// <summary>
        /// Элемент тела колонки текста
        /// </summary>
        public IWebElement SideBodyTextElement => _driver.FindElement(By.XPath("//div [@class='column description-column ng-star-inserted']"));

        /// <summary>
        /// Элемент текстового заголовка 
        /// </summary>
        public IWebElement TitleTextElement => _driver.FindElement(By.XPath("//h2[@class='title']"));

        /// <summary>
        /// Элемент текста описания заголовка
        /// </summary>
        public IWebElement GreetingMessageBodyElement => _driver.FindElement(By.XPath("//div [@class='description']"));
    }
}
