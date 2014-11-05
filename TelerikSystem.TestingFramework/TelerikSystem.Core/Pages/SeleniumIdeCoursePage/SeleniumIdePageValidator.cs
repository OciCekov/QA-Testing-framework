namespace TelerikSystem.Core.Pages.SeleniumIdeCoursePage
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class SeleniumIdePageValidator
    {
        public void AssertUnenrollmentActive()
        {
            Pages<SeleniumIdePage>.Instance.Navigate();
            Assert.IsTrue(Pages<SeleniumIdePage>.Instance.Map.UnenrollButton.InnerText.Contains("Отпишете курса")); 
        }

        public void AssertUnenrollmentNotActive()
        {
            Pages<SeleniumIdePage>.Instance.Navigate();
            Assert.IsTrue(Pages<SeleniumIdePage>.Instance.Map.UnenrollmentNotActiveMessage.InnerText.Contains("Отписването от курса не е активно"));
        }
    }
}