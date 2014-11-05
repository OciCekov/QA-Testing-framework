namespace TelerikSystem.Core.Pages.SeleniumIdeCoursePage
{
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;

    public class SeleniumIdePageMap : BaseElementMap
    {
        public HtmlSpan UnenrollmentNotActiveMessage
        {
            get
            {
                return this.Find.ByAttributes<HtmlSpan>("class=~unenrollFromCourseLink");
            }
        }

        public HtmlAnchor UnenrollButton
        {
            get
            {
                return this.Find.ByAttributes<HtmlAnchor>("class=~unenrollFromCourseLink");
            }
        }
    }
}