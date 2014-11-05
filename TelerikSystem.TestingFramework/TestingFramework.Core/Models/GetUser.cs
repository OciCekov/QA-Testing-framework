namespace TestingFramework.Core.Models
{
    /// <summary>
    /// Just get users from here so if something goes to heell, we will need to to change something just here
    /// example usage var dummy = GetUser.Admin();   etc...
    /// </summary>
    public static class GetUser
    {
        private const string DefaultPassword = "123456";

        public static User Admin()
        {
            return new User
            {
                Username = "AdminDummy",
                Password = DefaultPassword
            };
        }

        public static User NotFillApplicationForm()
        {
            return new User
            {
                Username = "NotFilleApplicationForm",
                Password = DefaultPassword
            };
        }

        public static User AllreadyFilledApplicationForm()
        {
            return new User
            {
                Username = "AllreadyFilledApplicationForm",
                Password = DefaultPassword
            };
        }

        public static User NeverFillApplicationFormCorrectly()
        {
            return new User
            {
                Username = "CandidateFormWrong",
                Password = DefaultPassword
            };
        }

        // Idea behind this is just to keep consistency, if we need particular user we can just use this one
        // With this all the one time users can be created like this, so there will be no need to do "var temp = new Looser();"
        public static User Custom(string userName, string password, string email = "def@ult.som", string firstName = "def", string lastName = "ault")
        {
            return new User
            {
                Username = userName,
                Password = password,
                Email = email,
                FirstName = firstName,
                LastName = lastName
            };
        }
    }
}