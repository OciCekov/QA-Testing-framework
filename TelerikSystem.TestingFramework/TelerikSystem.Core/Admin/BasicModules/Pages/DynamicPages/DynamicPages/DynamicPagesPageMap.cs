namespace TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using System.Collections.Generic;

    public class DynamicPagesPageMap : BaseElementMap
    {
        public HtmlAnchor CreatePage
        {
            get
            {
                return this.Find.ById<HtmlControl>("MainContent").Find.ByContent<HtmlAnchor>("Създаване на страница");
            }
        }

        public HtmlContainerControl TablePagesBody
        {
            get
            {
                return this.Find.ById<HtmlContainerControl>("MainContent")
                           .Find.AllByTagName<HtmlTable>("table")
                           .FirstOrDefault()
                           .Find.AllByTagName<HtmlContainerControl>("tbody")[0]
                           ;
            }
        }

        public IEnumerable<HtmlTableRow> TablePagesRows
        {
            get
            {
                return this.Find.ById<HtmlContainerControl>("MainContent")
                           .Find.AllByTagName<HtmlTable>("table")
                           .FirstOrDefault()
                           .Find.AllByTagName<HtmlTableRow>("tr")
                           ;
            }
        }

        public IEnumerable<HtmlTableCell> TitlePagesColumn
        {
            get
            {
                return this.Find.ById<HtmlContainerControl>("MainContent")
                           .Find.AllByTagName<HtmlTable>("table")
                           .FirstOrDefault()
                           .Find.AllByTagName<HtmlTableCell>("td").Where(c=>c.CellIndex==0)
                           ;
            }
        }
    }
}