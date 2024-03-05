using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LifePayTests.PageObjectModels
{
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
        public IWebElement logoElement => _driver.FindElement(By.XPath("//div [@class='logo-bar']"));

        /// <summary>
        /// Элемент окна ввода номера телефона
        /// </summary>
        public IWebElement inputTelephoneElement => _driver.FindElement(By.XPath("//input [@type='tel']"));

        /// <summary>
        /// Элемент окна ввода пароля
        /// </summary>
        public IWebElement inputPasswordElement => _driver.FindElement(By.XPath("//input [@type='password']"));

        /// <summary>
        /// Элемент тела колонки текста
        /// </summary>
        public IWebElement sideBodyTextElement => _driver.FindElement(By.XPath("//div [@class='column description-column ng-star-inserted']"));

        /// <summary>
        /// Элемент текстового заголовка 
        /// </summary>
        public IWebElement titleTextElement => _driver.FindElement(By.XPath("//h2[@class='title']"));

        /// <summary>
        /// Элемент текста описания заголовка
        /// </summary>
        public IWebElement greetingMessageBodyElement => _driver.FindElement(By.XPath("//div [@class='description']"));
    }
}
