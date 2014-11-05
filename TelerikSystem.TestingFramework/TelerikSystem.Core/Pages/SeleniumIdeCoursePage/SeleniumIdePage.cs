namespace TelerikSystem.Core.Pages.SeleniumIdeCoursePage
{
    using TestingFramework.Core.Base;

    public class SeleniumIdePage : BasePage<SeleniumIdePageMap, SeleniumIdePageValidator>
    {
        public override string Url
        {
            get 
            {
                return @"http://test.telerikacademy.com/Courses/Courses/Details/23"; 
            }
        }
    }
}