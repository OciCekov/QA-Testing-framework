namespace TelerikSystem.Core.Admin.BasicModules.Pages.Feedback
{
    using System.Collections.Generic;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Extensions;

    public class FeedbackPage : BasePage<FeedbackPageMap, FeedbackPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/";
            }
        }

        public void CreateFeedbackReport(string message)
        {
            if (this.Browser.Url != this.Url)
            {
                this.Navigate();
            }

            this.Map.HelpButton.FireClick();
            this.Map.FeedbackUserLink.Click();
            this.Map.Message.Click();
            this.Map.Message.Text = message;
            this.Map.SubmitButton.Click();
        }

        public void GoToAdminFeedbackReport()
        {
            if (this.Browser.Url != this.Url)
            {
                this.Navigate();
            }

            this.Map.AdminButton.Click();
            this.Map.FeedbackAdminLink.Click();
        }

        public void ResolveFeedbackReport()
        {
            this.Map.EditButton.Click();
            this.Map.PopUpWindowCheckBoxTrue.Click();
            this.Map.UpdateButton.Click();
        }

        public bool IsMessagePresent(string message)
        {
            int messagesCount = Pages<FeedbackPage>.Instance.Map.FeedbackGrid.DataItems.Count;
            var allMessages = new List<string>();
            for (int i = 0; i < messagesCount; i++)
            {
                allMessages.Add(Pages<FeedbackPage>.Instance.Map.FeedbackGrid.DataItems[i][4].TextContent);
            }

            return allMessages.Contains(message);
        }

        public bool IsStatusTrue(string status)
        {
            int statusesCount = Pages<FeedbackPage>.Instance.Map.FeedbackGrid.DataItems.Count;
            var allStatuses = new List<string>();
            for (int i = 0; i < statusesCount; i++)
            {
                allStatuses.Add(Pages<FeedbackPage>.Instance.Map.FeedbackGrid.DataItems[i][6].TextContent);
            }

            return allStatuses.Contains(status);
        }
    }
}