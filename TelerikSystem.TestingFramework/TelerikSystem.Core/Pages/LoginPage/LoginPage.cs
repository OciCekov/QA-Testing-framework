namespace TelerikSystem.Core.Pages.LoginPage
{
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    public class LoginPage : BasePage<LoginPageMap, LoginPageValidator>
    {
        public override string Url
        {
            get
            {
                return @"http://test.telerikacademy.com/Users/Auth/Login";
            }
        }

        public void LoginUser(User user)
        {
            this.Navigate();
            //// нищо не става ???????
            //// System.Threading.Thread.Sleep(2000);
            //// this.Map.Username.Wait.ForExists();
            this.Map.Username.Text = user.Username;
            this.Map.Password.Text = user.Password;
            this.Map.Submit.Click();
        }
    }
}