
using NUnit.Framework;
using TelerikSystem.Core.Admin.Certificates.Pages;
using TelerikSystem.Core.Pages.LoginPage;
using TestingFramework.Core.Base;


namespace TelerikSystem.Tests.Admin.Certificates
{
    public class CertificatesTests : BaseTest
    {
        private TestingFramework.Core.Models.User testUser;

        [TestFixtureSetUp]
        public override void TestInit()
        {
            this.testUser = new TestingFramework.Core.Models.User
            {
                Username = "kalimar",
                Password = "space password"
            };
        }

        [Pairwise]
        [Test]
        public void Certificates_CanCreateNewCertificate(
            [Range(0, 3)] int typeIndex, 
            [Values("pesho", "tosho", "gosho", "rado")] string name,
            [Values("userStub", "userMock", "userFake", "userDummy")] string userName,
            [Values(true, false)] bool isDeleted, 
            [Values(true, false)] bool isPublic)
        {
            var sut = Pages<CertificatesPage>.Instance;

            Pages<LoginPage>.Instance.LoginUser(testUser);
            sut.Navigate();
            sut.AddCertificate(typeIndex, name, userName, isPublic, isDeleted);
        }

    }
}
