namespace TelerikSystem.Tests.Admin.BasicModules.Auditoriums
{
    using NUnit.Framework;
    using System.Linq;
    using TelerikSystem.Core.Admin.BasicModules.Pages.Auditoriums;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;


    public class AuditoriumTests : BaseTest
    {
        private User testUser;

        public override void TestInit()
        {
            this.testUser = new User
            {
                Username = "kalimar",
                Password = "space password"
            };
        }

        [TestCase("test", "test", "30", "testing stuff")]
        [TestCase("aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa", "", "pesho", "testing stuff")]
        [TestCase("", "", "", "")]
        public void Auditorium_CanCreateNewAuditorium(string name, string address, string capacity, string equipment)
        {
            var sut = Pages<AuditoriumPage>.Instance;

            Pages<LoginPage>.Instance.LoginUser(testUser);
            sut.Navigate();
            sut.AddAuditorium(name, address, capacity, equipment);
            var allAuditoriums = sut.GetAllAuditoriums();

            Assert.IsTrue(allAuditoriums.Any(x => x.Name == "test"));
        }

        [Test]
        public void Auditorium_CanDeleteAuditorium()
        {
            var sut = Pages<AuditoriumPage>.Instance;

            Pages<LoginPage>.Instance.LoginUser(testUser);

            sut.Navigate();
            sut.DeleteAuditorium(9);
            var allAuditoriums = sut.GetAllAuditoriums();

            Assert.IsTrue(!allAuditoriums.Any(x => x.Name == "test"));
        }
    }
}
