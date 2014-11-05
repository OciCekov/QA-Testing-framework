namespace TelerikSystem.Core.User.BasicModules.Pages.SearchPage
{
    using TestingFramework.Core.Base;

    public class SearchPage : BasePage<SearchPageMap, SearchPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/";
            }
        }

        public void SearchText(string searchedValue)
        {
            if (this.Browser.Url != this.Url)
            {
                this.Navigate();
            }

            this.Map.SearchField.Text = searchedValue;
            this.Map.SearchButton.Click();
        }
    }
}