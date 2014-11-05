namespace TelerikSystem.Core.Pages.MainPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using System.Collections.Generic;
    using ArtOfTest.WebAii.Core;

    public class MainPageMap : BaseElementMap
    {
        public HtmlAnchor LogoutButton
        {
            get
            {
                return this.Find.ById<HtmlAnchor>("ExitMI");
            }
        }

        public HtmlDiv HomePageButtonsContainer
        {
            get
            {
                return this.Find.ByAttributes<HtmlDiv>("class=homePageButtons");
            }
        }

        public HtmlAnchor Admin
        {
            get
            {
                return this.Find.AllByTagName<HtmlAnchor>("a")
                           .Where(a => a.InnerText.Contains("Админ"))
                           .FirstOrDefault();
            }
        }

        public HtmlAnchor FirstForumPost
        {
            get
            {
                return this.Find.ById<HtmlListItem>("forum-posts-widget")
                               .Find.AllByAttributes<HtmlAnchor>("class=forumPostQuote")[0];
            }
        }

        public HtmlAnchor SecondForumPost
        {
            get
            {
                return this.Find.ById<HtmlListItem>("forum-posts-widget")
                           .Find.AllByAttributes<HtmlAnchor>("class=forumPostQuote")[1];
            }
        }

        public HtmlAnchor ThirdForumPost
        {
            get
            {
                return this.Find.ById<HtmlListItem>("forum-posts-widget")
                           .Find.AllByAttributes<HtmlAnchor>("class=forumPostQuote")[2];
            }
        }

        public HtmlDiv FirstFacebookPost
        {
            get
            {
                var a = this.Find.AllByTagName<HtmlControl>("iframe").FirstOrDefault().ChildNodes;
                  //     var b =      a.Find.AllByAttributes<HtmlDiv>("class=_5pbx userContent")[0];
              //  HtmlDiv b = a.Where<HtmlDiv>(d => d.CssClassAttributeValue == "_5pbx userContent");
                return new HtmlDiv();
            }
        }

        //public HtmlDiv SecondFacebookPost
        //{
        //    get
        //    {
        //        return this.Find.AllByAttributes<HtmlDiv>("class=userContent")[1];
        //    }
        //}

        //public HtmlDiv ThirdFacebookPost
        //{
        //    get
        //    {
        //        return this.Find.AllByAttributes<HtmlDiv>("class=userContent")[2];
        //    }
        //}
    }
}