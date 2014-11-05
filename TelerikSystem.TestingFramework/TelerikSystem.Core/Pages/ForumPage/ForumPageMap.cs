namespace TelerikSystem.Core.Pages.ForumPage
{
    using System.Collections.Generic;
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    using TestingFramework.Core.Base;

    public class ForumPageMap : BaseElementMap
    {
        public HtmlDiv FirstForumPost
        {
            get
            {
                return this.Find.AllByAttributes<HtmlDiv>("class=qa-q-item-title")[0];
            }
        }

        public HtmlDiv SecondForumPost
        {
            get
            {
                return this.Find.AllByAttributes<HtmlDiv>("class=qa-q-item-title")[1];
            }
        }

        public HtmlDiv ThirdForumPost
        {
            get
            {
                return this.Find.AllByAttributes<HtmlDiv>("class=qa-q-item-title")[2];
            }
        }
      
    }
}