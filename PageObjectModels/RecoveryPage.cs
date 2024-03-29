﻿using OpenQA.Selenium;

namespace PageObjectModels
{
    /// <summary>
    /// Элементы страницы Восстановление пароля
    /// </summary>
    public class RecoveryPage : CommonPageObjects
    {
        private readonly IWebDriver _driver;
        public RecoveryPage(IWebDriver driver) : base(driver)
        {
            _driver = driver;
        }

        /// <summary>
        /// Элемент кнопки Назад
        /// </summary>
        public IWebElement BackButtonElement => _driver.FindElement(By.XPath("//button [1]"));

        /// <summary>
        /// Элемент окна ввода кода из СМС
        /// </summary>
        public IWebElement InputPasswordSMSElement => _driver.FindElement(By.XPath("//input [@type='text']"));

        /// <summary>
        /// Элемент кнопки Отправить код
        /// </summary>
        public IWebElement SendCodeButtonElement => _driver.FindElement(By.XPath("//button [2]"));

        /// <summary>
        /// Элемент кнопки Продолжить
        /// </summary>
        public IWebElement ContinueButtonElement => _driver.FindElement(By.XPath("//button [@id='continue-restore-pass']"));

        /// <summary>
        /// Элемент заголовка колонки текста
        /// </summary>
        public IWebElement SideTitleElement => _driver.FindElement(By.XPath("//h2 [contains (text(), 'Восстановите')]"));
    }
}
