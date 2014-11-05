namespace TelerikSystem.Core.User.BasicModules.Pages.SearchPage
{
    using System.Linq;
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class SearchPageValidator
    {
        public void AssertText(string actual)
        {
            string expected = Pages<SearchPage>.Instance.Map.SearchResultTitle.InnerText;
            Assert.AreEqual(expected, actual);
        }

        public void AssertUsersCount(int actual)
        {
            int expected = Pages<SearchPage>.Instance.Map.UsersList.Items.Count();
            Assert.AreEqual(expected, actual);
        }

        public void AssertCoursesCount(int actual)
        {
            int expected = Pages<SearchPage>.Instance.Map.CoursesList.Items.Count();
            Assert.AreEqual(expected, actual);
        }

        public void AssertTracksCount(int actual)
        {
            int expected = Pages<SearchPage>.Instance.Map.TracksList.Items.Count();
            Assert.AreEqual(expected, actual);
        }
    }
}