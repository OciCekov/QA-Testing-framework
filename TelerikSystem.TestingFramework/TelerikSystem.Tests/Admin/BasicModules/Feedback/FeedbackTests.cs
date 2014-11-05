namespace TelerikSystem.Tests.Admin.BasicModules.Feedback
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using TelerikSystem.Core.Admin.BasicModules.Pages.Feedback;
    using TelerikSystem.Core.Pages.LoginPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class FeedbackTests : BaseTest
    {
        private User currentUser;

        public override void TestInit()
        {
            currentUser = GetUser.Admin();
        }

        [TestMethod]
        public void Feedback_ConfirmErrorLengthOfMessageExist()
        {
            const string Message = "blabla";
            const string ErrorMessage = "Моля напишете поне 20 символа";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.CreateFeedbackReport(Message);
            Pages<FeedbackPage>.Instance.Validator.AssertErrorLengthOfMessage(ErrorMessage);
        }

        [TestMethod]
        public void Feedback_ConfirmFeedbackReportExist()
        {
            const string Message = "Message should be at least 20 symbols";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            //// Pages<FeedbackPage>.Instance.CreateFeedbackReport(Message); // TODO: In order not to have too many similar messages, no delete button
            Pages<FeedbackPage>.Instance.GoToAdminFeedbackReport();
            Pages<FeedbackPage>.Instance.Validator.AssertMessagePresent(Message);
        }

        [TestMethod]
        public void Feedback_ConfirmFeedbackReportIsResolved()
        {
            const string StatusTrue = "true";
            const string StatusFalse = "false";

            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<FeedbackPage>.Instance.GoToAdminFeedbackReport();
            Pages<FeedbackPage>.Instance.ResolveFeedbackReport();
            Pages<FeedbackPage>.Instance.Validator.AssertStatus(StatusTrue);
            Pages<FeedbackPage>.Instance.ResolveFeedbackReport();
            Pages<FeedbackPage>.Instance.Validator.AssertStatus(StatusFalse);
        }
    }
}
