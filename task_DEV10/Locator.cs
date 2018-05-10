namespace task_DEV10
{
    /// <summary>
    ///  This class contains all locators
    /// </summary>
    public static class Locator
    {
        public const string brandLocator = "//select[@name = 'brand_id[]']";
        public const string showAllLocator = "//p[@class = 'brands-all']/a[@class = 'js-brands-show-all']";
        public const string submitLocator = "//button[@type = 'submit']";
        public const string brandListLocator = "//div[@class = 'brands']//ul[@class = 'brandslist']//a/span";
        public const string nextPageLocator = "//div[@class = 'pages']/ul//li/a[@class = 'pages-arrows-link']";
        public const string elementsLocator = "//div[@class = 'listing-item-body']//div[@class = 'listing-item-title']/h4/a";
        public const string numberPageLocator = "//div[@class='pages-numbers']/ul/li";
    }
}
