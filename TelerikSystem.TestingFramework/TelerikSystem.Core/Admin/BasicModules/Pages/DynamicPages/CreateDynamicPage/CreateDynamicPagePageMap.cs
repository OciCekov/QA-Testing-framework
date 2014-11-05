namespace TelerikSystem.Core.Admin.BasicModules.Pages.DynamicPages.CreateDynamicPage
{
    using System.Linq;
    using ArtOfTest.WebAii.Controls.HtmlControls;
    using TestingFramework.Core.Base;
    using ArtOfTest.WebAii.Core;

    public class CreateDynamicPagePageMap : BaseElementMap
    {
        public HtmlInputText Title
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Title");
            }
        }

        public HtmlControl Content
        {
            get
            {
               return  Manager.Current.ActiveBrowser.Frames[0].Find.ByAttributes<HtmlControl>("contenteditable=true");
            }
        }

        public HtmlInputText Description
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Description");
            }
        }

        public HtmlInputText Keywords
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Keywords");
            }
        }

        public HtmlInputText CreatedOn
        {
            get
            {
                return this.Find.ById<HtmlInputText>("CreatedOn");
            }
        }

        public HtmlInputText ModifiedOn
        {
            get
            {
                return this.Find.ById<HtmlInputText>("ModifiedOn");
            }
        }

        public HtmlSpan LocalErrorMessageTitleForRequested
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Моля въведете заглавие на страницата");
            }
        }

        public HtmlSpan LocalErrorMessageContentForRequested
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Моля въведете съдържание на страницата");
            }
        }

        public HtmlSpan LocalErrorMessageTitleForLenght
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Заглавието на страницата трябва да е между 3 и 200 символа");
            }
        }

        public HtmlSpan LocalErrorMessageDescription
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Описанието на страницата не може да е повече от 200 символа");
            }
        }

        public HtmlSpan LocalErrorMessageKeywords
        {
            get
            {
                return this.Find.ByContent<HtmlSpan>("Полето не може да съдържа повече от 100 символа");
            }
        }

        public HtmlSpan LocalErrorMessageCreateOn
        {
            get
            {
                return this.Find.ByAttributes<HtmlSpan>("data-valmsg-for=CreatedOn");
            }
        }

        public HtmlSpan LocalErrorMessageModifyOn
        {
            get
            {
                return this.Find.ByAttributes<HtmlSpan>("data-valmsg-for=ModifiedOn");
            }
        }

        //public HtmlInputSubmit CreateButton
        //{
        //    get
        //    {
        //        return this.Find.AllByTagName<HtmlControl>("fieldset").FirstOrDefault().Find.ByAttributes<HtmlInputSubmit>("vаlue=Create");
        //    }
        //}

        public HtmlInputSubmit CreateButton
        {
            get
            {
                return this.Find.AllByTagName<HtmlControl>("fieldset").FirstOrDefault().Find.ByAttributes<HtmlInputSubmit>("value=Create");
            }
        }
    }
}

