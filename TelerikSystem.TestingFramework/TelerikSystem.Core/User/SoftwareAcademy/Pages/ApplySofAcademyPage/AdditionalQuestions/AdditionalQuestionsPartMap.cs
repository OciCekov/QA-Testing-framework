namespace TelerikSystem.Core.User.SoftwareAcademy.Pages.ApplySofAcademyPage.AdditionalQuestions
{
    using System;
    using System.Linq;

    using ArtOfTest.WebAii.Controls.HtmlControls;

    using TestingFramework.Core.Base;

    public class AdditionalQuestionsPartMap : BaseElementMap
    {
        public HtmlTextArea Q1Text
        {
            get
            {
                return this.Find.ById<HtmlTextArea>("Question_1");
            }
        }

        public HtmlInputText Q2Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Question_2");
            }
        }

        public HtmlInputText Q3Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Question_3");
            }
        }

        public HtmlInputText Q4Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Question_4");
            }
        }

        public HtmlTextArea Q5Text
        {
            get
            {
                return this.Find.ById<HtmlTextArea>("Question_5");
            }
        }

        public HtmlInputCheckBox Q6Checkbox1
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_1");
            }
        }

        public HtmlInputCheckBox Q6Checkbox8
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_8");
            }
        }

        public HtmlInputText Q6Checkbox8Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_8");
            }
        }

        public HtmlInputCheckBox Q7Checkbox9
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_9");
            }
        }

        public HtmlInputCheckBox Q7Checkbox15
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_15");
            }
        }

        public HtmlInputText Q7Checkbox15Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_15");
            }
        }

        public HtmlInputCheckBox Q8Checkbox16
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_16");
            }
        }

        public HtmlInputCheckBox Q9Checkbox24
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_24");
            }
        }

        public HtmlInputCheckBox Q9Checkbox31
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_31");
            }
        }

        public HtmlInputText Q9Checkbox31Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_31");
            }
        }

        public HtmlInputCheckBox Q9Checkbox32
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_32");
            }
        }

        public HtmlInputText Q9Checkbox32Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_32");
            }
        }

        public HtmlInputCheckBox Q9Checkbox33
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_33");
            }
        }

        public HtmlInputText Q9Checkbox33Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_33");
            }
        }

        public HtmlInputCheckBox Q9Checkbox34
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_34");
            }
        }

        public HtmlInputText Q9Checkbox34Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_34");
            }
        }

        public HtmlInputCheckBox Q9Checkbox35
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_35");
            }
        }

        public HtmlInputText Q9Checkbox35Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_35");
            }
        }

        public HtmlInputCheckBox Q9Checkbox36
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_36");
            }
        }

        public HtmlInputText Q9Checkbox36Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_36");
            }
        }

        public HtmlInputCheckBox Q9Checkbox37
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_37");
            }
        }

        public HtmlInputText Q9Checkbox37Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_37");
            }
        }

        public HtmlInputCheckBox Q9Checkbox38
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_38");
            }
        }

        public HtmlInputText Q9Checkbox38Text
        {
            get
            {
                return this.Find.ById<HtmlInputText>("Text_Field_For_Answer_38");
            }
        }

        public HtmlSpan Q9LocalMessage
        {
            get
            {
                return this.Find.ByAttributes<HtmlSpan>("data-valmsg-for=Question_9");
            }
        }

        public HtmlInputRadioButton Q10RadioButton39
        {
            get
            {
                return this.Find.ById<HtmlInputRadioButton>("Answer_39");
            }
        }

        public HtmlSpan Q10LocalMessage
        {
            get
            {
                return this.Find.ByAttributes<HtmlSpan>("data-valmsg-for=Question_10");
            }
        }

        public HtmlSpan Q11LocalMessage
        {
            get
            {
                return this.Find.ByAttributes<HtmlSpan>("data-valmsg-for=Question_13");
            }
        }

        public HtmlInputCheckBox Q11RadioButton42
        {
            get
            {
                return this.Find.ById<HtmlInputCheckBox>("Answer_42");
            }
        }

        public HtmlInputCheckBox FindAnswerCheckbox(int numberAnswer)
        {
            switch (numberAnswer)
            {
                case 8:
                    return this.Q6Checkbox8;
                case 15:
                    return this.Q7Checkbox15;
                case 31:
                    return this.Q9Checkbox31;
                case 32:
                    return this.Q9Checkbox32;
                case 33:
                    return this.Q9Checkbox33;
                case 34:
                    return this.Q9Checkbox34;
                case 35:
                    return this.Q9Checkbox35;
                case 36:
                    return this.Q9Checkbox36;
                case 37:
                    return this.Q9Checkbox37;
                case 38:
                    return this.Q9Checkbox38;
                default:
                    return this.Q9Checkbox38;
            }
        }

        public HtmlInputText FindInputBox(int numberAnswer)
        {
            switch (numberAnswer)
            {
                case 8:
                    return this.Q6Checkbox8Text;
                case 15:
                    return this.Q7Checkbox15Text;
                case 31:
                    return this.Q9Checkbox31Text;
                case 32:
                    return this.Q9Checkbox32Text;
                case 33:
                    return this.Q9Checkbox33Text;
                case 34:
                    return this.Q9Checkbox34Text;
                case 35:
                    return this.Q9Checkbox35Text;
                case 36:
                    return this.Q9Checkbox36Text;
                case 37:
                    return this.Q9Checkbox37Text;
                case 38:
                    return this.Q9Checkbox38Text;
                default:
                    return this.Q9Checkbox38Text;
            }
        }
    }
}
