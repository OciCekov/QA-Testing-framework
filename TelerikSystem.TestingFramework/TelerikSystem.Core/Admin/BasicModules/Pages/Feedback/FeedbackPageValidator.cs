namespace TelerikSystem.Core.Admin.BasicModules.Pages.Feedback
{
    using ArtOfTest.Common.UnitTesting;
    using TestingFramework.Core.Base;

    public class FeedbackPageValidator
    {
        public void AssertErrorLengthOfMessage(string actual)
        {
            string expected = Pages<FeedbackPage>.Instance.Map.ErrorLengthOfMessage.InnerText;
            Assert.AreEqual(expected, actual);
        }

        public void AssertMessagePresent(string message)
        {
            Assert.IsTrue(Pages<FeedbackPage>.Instance.IsMessagePresent(message));
        }

        public void AssertStatus(string status)
        {
            Assert.IsTrue(Pages<FeedbackPage>.Instance.IsStatusTrue(status));
        }
    }
}