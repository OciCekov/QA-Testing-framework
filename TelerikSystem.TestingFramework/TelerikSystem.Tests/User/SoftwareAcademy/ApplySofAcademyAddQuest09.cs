namespace TelerikSystem.Tests.User.SoftwareAcademy
{
    using System;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    using TelerikSystem.Core.Pages.LoginPage;
    using TelerikSystem.Core.Pages.MainPage;
    using TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage;
    using TestingFramework.Core.Base;
    using TestingFramework.Core.Models;

    [TestClass]
    public class ApplySofAcademyAddQuest09 : BaseTest
    {
        private readonly string[] invalidData = { string.Empty, "    " };
        private readonly string[] validData = 
        { 
            @"\ / : * ? "" < > | ", 
            "<script>", "</script>", 
            "<script>hI</script>", 
            "some text", 
            "някакъв текст", 
            "いくつかのテキスト", 
            "بعض النص",
            "some < text",
            "some > text",
            "some | text",
            "some ' text", 
            "123456",
            "asdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklzasdfghjklz"
        };

        private TestingFramework.Core.Models.User currentUser;

        public override void TestInit()
        {
            this.currentUser = GetUser.NotFillApplicationForm();
            this.currentUser.Username = "ccccc";
            this.currentUser.Password = "123456";
        }

        #region[NoSelection]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_NoSelection()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_NoSelection();
            Pages<MainPage>.Instance.LogOut();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_NoSelection()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyQ09_NoSelection();
            Pages<MainPage>.Instance.LogOut();
        }

        #endregion

        #region[Selected]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_Selected()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyAsQ09_Selected();
            Pages<MainPage>.Instance.LogOut();
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_Selected()
        {
            Pages<LoginPage>.Instance.LoginUser(currentUser);
            Pages<ApplySofAcademyPage>.Instance.Navigate();
            Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyAsQ09_Selected();
            Pages<MainPage>.Instance.LogOut();
        }

        #endregion

        #region[CarierCenter]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_CarierCenter_InvalidInputData()
        {
             for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_InvalidInputData(invalidData[i], 31);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_CarierCenter_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_ValidInputData(validData[i], 31);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_CarierCenter_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyQ09_InvalidInputData(invalidData[i], 31);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_CarierCenter_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLokalMessageCantApplyQ09_ValidInputData(validData[i], 31);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        #endregion

        #region[FromPoster]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_FromPoster_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_InvalidInputData(invalidData[i], 32);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_FromPoster_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_ValidInputData(validData[i], 32);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_FromPoster_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyQ09_InvalidInputData(invalidData[i], 32);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_FromPoster_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLokalMessageCantApplyQ09_ValidInputData(validData[i], 32);
                Pages<MainPage>.Instance.LogOut();
            }
        }
        #endregion

        #region[FromFlyer]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_FromFlyer_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_InvalidInputData(invalidData[i], 33);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_FromFlyer_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_ValidInputData(validData[i], 33);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_FromFlyer_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyQ09_InvalidInputData(invalidData[i], 33);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_FromFlyer_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLokalMessageCantApplyQ09_ValidInputData(validData[i], 33);
                Pages<MainPage>.Instance.LogOut();
            }
        }
        #endregion

        #region[FromAdvertisement]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_FromAdvertisement_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_InvalidInputData(invalidData[i], 34);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_FromAdvertisement_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_ValidInputData(validData[i], 34);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_FromAdvertisement_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyQ09_InvalidInputData(invalidData[i], 34);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_FromAdvertisement_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLokalMessageCantApplyQ09_ValidInputData(validData[i], 34);
                Pages<MainPage>.Instance.LogOut();
            }
        }
        #endregion

        #region[FromNews]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_FromNews_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_InvalidInputData(invalidData[i], 35);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_FromNews_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_ValidInputData(validData[i], 35);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_FromNews_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyQ09_InvalidInputData(invalidData[i], 35);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_FromNews_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLokalMessageCantApplyQ09_ValidInputData(validData[i], 35);
                Pages<MainPage>.Instance.LogOut();
            }
        }
        #endregion

        #region[Friend]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_Friend_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_InvalidInputData(invalidData[i], 36);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_Friend_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_ValidInputData(validData[i], 36);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_Friend_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyQ09_InvalidInputData(invalidData[i], 36);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_Friend_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLokalMessageCantApplyQ09_ValidInputData(validData[i], 36);
                Pages<MainPage>.Instance.LogOut();
            }
        }
        #endregion

        #region[OtherSite]

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_OtherSite_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_InvalidInputData(invalidData[i], 37);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(3)]
        public void ApplySofAcademy_AssertMainErrorMessageQ9_OtherSite_ValidInputData()
        {
           for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertMainMessageCantApplyQ09_ValidInputData(validData[i], 37);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_OtherSite_InvalidInputData()
        {
            for (int i = 0; i < invalidData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLocalMessageCantApplyQ09_InvalidInputData(invalidData[i], 37);
                Pages<MainPage>.Instance.LogOut();
            }
        }

        [TestMethod]
        [Owner("Violeta Roumenova")]
        [Priority(2)]
        public void ApplySofAcademy_AssertLocalErrorMessageQ9_OtherSite_ValidInputData()
        {
            for (int i = 0; i < validData.Length; i++)
            {
                Pages<LoginPage>.Instance.LoginUser(currentUser);
                Pages<ApplySofAcademyPage>.Instance.Navigate();
                Pages<ApplySofAcademyPage>.Instance.Validator.AssertLokalMessageCantApplyQ09_ValidInputData(validData[i], 37);
                Pages<MainPage>.Instance.LogOut();
            }
        }
        #endregion
    }
}
