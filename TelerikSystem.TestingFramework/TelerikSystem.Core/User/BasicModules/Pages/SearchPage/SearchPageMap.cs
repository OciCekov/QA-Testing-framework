namespace TelerikSystem.Core.User.BasicModules.Pages.SearchPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class SearchPageMap : BaseElementMap
    {
        public HtmlInputText SearchField
        {
            get
            {
                return this.Find.ById<HtmlInputText>("SearchTerm");
            }
        }

        public HtmlInputSubmit SearchButton
        {
            get
            {
                return this.Find.ById<HtmlInputSubmit>("SearchButton");
            }
        }

        public HtmlContainerControl SearchResultTitle
        {
            get
            {
                return this.Find.ByAttributes<HtmlContainerControl>("class=SearchResultsListTitle");
            }
        }

        public HtmlUnorderedList UsersList
        {
            get
            {
                return this.Find.AllByAttributes<HtmlDiv>("class=SearchResultsCategory")
                           .Where(ur => ur.InnerText.Contains("Потребители"))
                           .FirstOrDefault()
                           .Find.ByAttributes<HtmlUnorderedList>("class=SearchMetroList");
            }
        }

        public HtmlUnorderedList CoursesList
        {
            get
            {
                return this.Find.AllByAttributes<HtmlDiv>("class=SearchResultsCategory")
                           .Where(cr => cr.InnerText.Contains("Курсове"))
                           .FirstOrDefault()
                           .Find.ByAttributes<HtmlUnorderedList>("class=SearchMetroList");
            }
        }

        public HtmlUnorderedList TracksList
        {
            get
            {
                return this.Find.AllByAttributes<HtmlDiv>("class=SearchResultsCategory")
                           .Where(tr => tr.InnerText.Contains("Тракове"))
                           .FirstOrDefault()
                           .Find.ByAttributes<HtmlUnorderedList>("class=SearchMetroList");
            }
        }
    }
}