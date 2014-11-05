namespace TelerikSystem.Core.Pages.FacebookPage
{
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    using TestingFramework.Core.Base;

    public class FacebookPageMap : BaseElementMap
    {
        public HtmlSpan FirstFacebookPost
        {
            get
            {
                return this.Find.ById<HtmlListItem>("facebook-widget").Find.AllByAttributes<HtmlSpan>("class=userContent")[0];
            }
        }

        public HtmlSpan SecondFacebookPost
        {
            get
            {
                return this.Find.AllByAttributes<HtmlSpan>("class=userContent")[1];
            }
        }

        public HtmlSpan ThirdFacebookPost
        {
            get
            {
                return this.Find.AllByAttributes<HtmlSpan>("class=userContent")[2];
            }
        }
      
    }
}