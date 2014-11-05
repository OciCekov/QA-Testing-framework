namespace TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages.DeletePage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using System.Collections.Generic;

    public class DeletePagePageMap : BaseElementMap
    {
        public HtmlInputSubmit DeleteButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlInputSubmit>("value=Delete");
            }
        }
    }
}