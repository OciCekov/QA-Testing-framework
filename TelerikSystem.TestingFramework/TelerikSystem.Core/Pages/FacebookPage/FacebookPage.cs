namespace TelerikSystem.Core.Pages.FacebookPage
{
    using TestingFramework.Core.Base;

    public class FacebookPage : BasePage<FacebookPageMap, FacebookPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"https://www.facebook.com/TelerikAcademy";
            }
        }
    }
}