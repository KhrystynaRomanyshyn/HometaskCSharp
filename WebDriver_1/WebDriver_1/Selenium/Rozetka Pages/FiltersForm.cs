namespace WebDriver_1.Selenium
{
    using System.Linq;
    using OpenQA.Selenium;


    public class FiltersForm
    {
        private IWebElement Root;
        public FiltersForm(IWebElement element)
        {
            Root = element;
        }

        public IWebElement[] FiltersSections => Root.FindElements(By.ClassName("filter-parametrs-i")).ToArray();

        public IWebElement[] ItemsForSection(string sectionName)
            => new FilterSection(FiltersSections.First(i => i.FindElement(By.Name("filter_parameters_title")).Text.Contains(sectionName))).Items;
    }

    public class FilterSection
    {
        private IWebElement Root;
        public FilterSection(IWebElement element)
        {
            Root = element;
        } 
        public IWebElement[] Items => Root.FindElements(By.CssSelector("li.pos-fix")).ToArray();
    }


}
