namespace TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.DynamicPages
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using System.Linq;

    public class DynamicPagesPage : BasePage<DynamicPagesPageMap, DynamicPagesPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Administration/PagesOld"; 
            }
        }

        
       
    }
}
