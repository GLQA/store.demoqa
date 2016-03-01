﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Store.Demoqa.Pages
{
    /// <summary>
    /// controls and methods on Cart page 
    /// </summary>
    public class Cart
    {
        /// <summary>
        /// The first product in cart
        /// </summary>
        [FindsBy(How = How.XPath, Using = ".//table/tbody/tr[2]/td[2]")]
        public IWebElement FirstProductInCart;

        [FindsBy(How = How.XPath, Using = ".//table/tbody//td[2]")]
        public IWebElement ProductInCart;

        /// <summary>
        /// The cart page header
        /// </summary>
        [FindsBy(How = How.XPath, Using = ".//*[@id='post-29']/header/h1")]
        public IWebElement CartPageHeader;

        /// <summary>
        /// The driver
        /// </summary>
        private IWebDriver driver;

        /// <summary>
        /// Initializes a new instance of the <see cref="Cart"/> class.
        /// </summary>
        /// <param name="driver">The driver.</param>
        public Cart(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        /// <summary>
        /// Gets product in Cart
        /// </summary>
        /// <param name="prodTitle"></param>
        /// <returns></returns>
        public string GetProductInCart(string prodTitle)
        {
            var listOfProductsInCart = ProductInCart.FindElements(By.XPath(".//table/tbody//td[2]/a"));
            foreach (IWebElement element in listOfProductsInCart)
            {
                if (element.Text == prodTitle)
                {
                    return element.Text;
                }
            }
            return prodTitle;

        }
    }
}
