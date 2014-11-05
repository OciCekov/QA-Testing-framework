namespace TelerikSystem.Core.Pages.MainPage
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;
    using TelerikSystem.Core.Pages.FacebookPage;
    using TelerikSystem.Core.Pages.ForumPage;

    public class MainPageValidator
    {
        public void AssertCourseButtonPresent(string courseName, int courseId)
        {
            Pages<MainPage>.Instance.Navigate();
            Assert.IsTrue(Pages<MainPage>.Instance.IsCourseButtonPresent(courseName, courseId));            
        }

        public void AssertCourseButtonNotPresent(string courseName, int courseId)
        {
            Pages<MainPage>.Instance.Navigate();
            Assert.IsFalse(Pages<MainPage>.Instance.IsCourseButtonPresent(courseName, courseId));
        }

        public void AssertAdminIsVisible()
        {
            Pages<MainPage>.Instance.Navigate();
            Assert.IsTrue(Pages<MainPage>.Instance.Map.Admin.IsVisible());
        }

        public void AssertFirstForumPost()
        {
            Pages<MainPage>.Instance.Navigate();
            var firstPostAcademyPage = Pages<MainPage>.Instance.Map.FirstForumPost.InnerText;

            Pages<ForumPage>.Instance.Navigate();
            var firstPostForumPage = Pages<ForumPage>.Instance.Map.FirstForumPost.InnerText;

            Assert.AreEqual<string>(firstPostForumPage, firstPostAcademyPage);
        }

        public void AssertSecondForumPost()
        {
            Pages<MainPage>.Instance.Navigate();
            var secondPostAcademyPage = Pages<MainPage>.Instance.Map.SecondForumPost.InnerText;

            Pages<ForumPage>.Instance.Navigate();
            var secondPostForumPage = Pages<ForumPage>.Instance.Map.SecondForumPost.InnerText;

            Assert.AreEqual<string>(secondPostForumPage, secondPostAcademyPage);
        }

        public void AssertThirdForumPost()
        {
            Pages<MainPage>.Instance.Navigate();
            var thirdPostAcademyPage = Pages<MainPage>.Instance.Map.ThirdForumPost.InnerText;

            Pages<ForumPage>.Instance.Navigate();
            var thirdPostForumPage = Pages<ForumPage>.Instance.Map.ThirdForumPost.InnerText;

            Assert.AreEqual<string>(thirdPostForumPage, thirdPostAcademyPage);
        }

        public void AssertFirstFacebookPost()
        {
            Pages<MainPage>.Instance.Navigate();
            var firstPostAcademyPage = Pages<MainPage>.Instance.Map.FirstFacebookPost;
            Pages<FacebookPage>.Instance.Navigate();
            var firstPostFacebookPage = Pages<FacebookPage>.Instance.Map.FirstFacebookPost.InnerText;
           // Assert.AreEqual<string>(firstPostFacebookPage, firstPostAcademyPage);
        }
    }
}