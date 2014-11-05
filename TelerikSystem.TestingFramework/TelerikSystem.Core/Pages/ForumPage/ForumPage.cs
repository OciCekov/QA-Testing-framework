namespace TelerikSystem.Core.Pages.ForumPage
{
    using TestingFramework.Core.Base;

    public class ForumPage : BasePage<ForumPageMap, ForumPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://forums.academy.telerik.com/";
            }
        }
    }
}