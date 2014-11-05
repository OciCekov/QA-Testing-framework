namespace TestingFramework.Core.Base
{
    using ArtOfTest.WebAii.Core;

    public abstract class BasePage<TMap, TValidator>
        where TMap : BaseElementMap, new()
        where TValidator : new()
    {
        private TMap map;
        private TValidator validator;

        public TMap Map
        {
            get
            {
               // if (this.map == null)
                {
                    this.map = new TMap();
                }

                return this.map;
            }
        }

        public TValidator Validator
        {
            get
            {
               // if (this.validator == null)
                {
                    this.validator = new TValidator();
                }

                return this.validator;
            }
        }

        public Browser Browser
        {
            get
            {
                return Manager.Current.ActiveBrowser;
            }
        }

        public abstract string Url { get; }

        public virtual void Navigate()
        {
            if (this.Browser.Url != this.Url)
            {
                this.Browser.NavigateTo(this.Url);
            }
        }
    }
}
