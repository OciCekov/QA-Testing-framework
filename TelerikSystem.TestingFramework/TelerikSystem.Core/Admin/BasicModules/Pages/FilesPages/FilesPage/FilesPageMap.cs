namespace TelerikSystem.Core.Admin.BasicModules.Pages.FilesPages.FilesPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using Telerik.TestingFramework.Controls.KendoUI;
    using TestingFramework.Core.Base;

    public class FilesPageMap : BaseElementMap
    {
        public HtmlContainerControl MainContent
        {
            get
            {
                return this.Find.ById<HtmlContainerControl>("MainContent");
            }
        }

        public HtmlAnchor UploadFile
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                           .Where(a => a.InnerText.Contains("Качи файл"))
                           .FirstOrDefault();
            }
        }

        public KendoGrid FilesGrid
        {
            get
            {
                return this.Find.ByAttributes<KendoGrid>("data-role=grid");
            }
        }

        public HtmlAnchor LastGridItemDelete
        {
            get
            {
                int filesCount = this.FilesGrid.DataItems.Count;
                int lastGridItemCellsCount = this.FilesGrid.DataItems[filesCount - 1].Cells.Count;

                return this.FilesGrid.DataItems[filesCount - 1][lastGridItemCellsCount - 1]
                .Find.AllByTagName<HtmlAnchor>("a")
                                                                                           .FirstOrDefault();
            }
        }
    }
}