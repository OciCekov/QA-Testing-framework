namespace TelerikSystem.Core.Admin.BasicModules.Pages.Auditoriums
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class AuditoriumPageMap : BaseElementMap
    {
        public HtmlDiv DataGrid
        {
            get
            {
                return this.Find.ById<HtmlDiv>("DataGrid");
            }
        }

        public HtmlAnchor AddAuditoriumButton
        {
            get
            {
                return this.DataGrid.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-add");
            }
        }

        public HtmlTable ContentTable
        {
            get
            {
                return this.DataGrid.Find.ByTagIndex<HtmlTable>("table", 0);
            }
        }

        public HtmlInputText NameInput
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Name");
            }
        }

        public HtmlInputText CapacityInput
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Capacity");
            }
        }

        public HtmlInputText AddressInput
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Address");
            }
        }

        public HtmlInputText EquipmentInput
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Equipment");
            }
        }

        public HtmlAnchor UpdateButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=k-button k-button-icontext k-grid-update");
            }
        }

        public HtmlAnchor GetDeleteButtonOf(int id)
        {
            HtmlTableRow targetRow = this.ContentTable.Rows.Single(x => x.Cells[0].TextContent == id.ToString());
            return targetRow.Cells[6].Find.ByTagIndex<HtmlAnchor>("a", 0);
        }
    }
}