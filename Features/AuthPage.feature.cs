﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by SpecFlow (https://www.specflow.org/).
//      SpecFlow Version:3.9.0.0
//      SpecFlow Generator Version:3.9.0.0
// 
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------
#region Designer generated code
#pragma warning disable
namespace LifePayTests.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("Набор проверок для страницы авторизации")]
    public partial class НаборПроверокДляСтраницыАвторизацииFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "AuthPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("ru"), "Features", "Набор проверок для страницы авторизации", null, ProgrammingLanguage.CSharp, ((string[])(null)));
            testRunner.OnFeatureStart(featureInfo);
        }
        
        [NUnit.Framework.OneTimeTearDownAttribute()]
        public virtual void FeatureTearDown()
        {
            testRunner.OnFeatureEnd();
            testRunner = null;
        }
        
        [NUnit.Framework.SetUpAttribute()]
        public virtual void TestInitialize()
        {
        }
        
        [NUnit.Framework.TearDownAttribute()]
        public virtual void TestTearDown()
        {
            testRunner.OnScenarioEnd();
        }
        
        public virtual void ScenarioInitialize(TechTalk.SpecFlow.ScenarioInfo scenarioInfo)
        {
            testRunner.OnScenarioInitialize(scenarioInfo);
            testRunner.ScenarioContext.ScenarioContainer.RegisterInstanceAs<NUnit.Framework.TestContext>(NUnit.Framework.TestContext.CurrentContext);
        }
        
        public virtual void ScenarioStart()
        {
            testRunner.OnScenarioStart();
        }
        
        public virtual void ScenarioCleanup()
        {
            testRunner.CollectScenarioErrors();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Корректное отображения приветствия в соответствии со временем суток")]
        [NUnit.Framework.CategoryAttribute("greeting_time")]
        [NUnit.Framework.TestCaseAttribute("6:45:0 AM", "Доброе утро!", new string[] {
                "morning",
                "id_gr001"}, Category="morning,id_gr001")]
        [NUnit.Framework.TestCaseAttribute("12:15:0 PM", "Добрый день!", new string[] {
                "afternoon",
                "id_gr002"}, Category="afternoon,id_gr002")]
        [NUnit.Framework.TestCaseAttribute("6:20:5 PM", "Добрый вечер!", new string[] {
                "evening",
                "id_gr003"}, Category="evening,id_gr003")]
        [NUnit.Framework.TestCaseAttribute("01:00:7 AM", "Доброй ночи!", new string[] {
                "night",
                "id_gr004"}, Category="night,id_gr004")]
        public virtual void КорректноеОтображенияПриветствияВСоответствииСоВременемСуток(string время, string приветствие, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "greeting_time"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Время", время);
            argumentsOfScenario.Add("Приветствие", приветствие);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Корректное отображения приветствия в соответствии со временем суток", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 6
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 7
 testRunner.Given(string.Format("системное время равно {0} часам", время), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line hidden
#line 8
 testRunner.When("Открыта страница авторизации LifePay", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 9
 testRunner.Then(string.Format("отображается \'{0}\'", приветствие), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Успешное заполнение полей ввода при авторизации")]
        [NUnit.Framework.CategoryAttribute("field_fill")]
        [NUnit.Framework.TestCaseAttribute("Номер телефона", "+7 (911) 111-11-11", new string[] {
                "number_field",
                "id_fi001"}, Category="number_field,id_fi001")]
        [NUnit.Framework.TestCaseAttribute("Пароль", "@12345#6789!", new string[] {
                "password_field",
                "id_fi002"}, Category="password_field,id_fi002")]
        public virtual void УспешноеЗаполнениеПолейВводаПриАвторизации(string имяПоля, string значение, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "field_fill"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Имя поля", имяПоля);
            argumentsOfScenario.Add("Значение", значение);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Успешное заполнение полей ввода при авторизации", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 32
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 33
 testRunner.Given("Открыта страница авторизации LifePay", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line hidden
#line 34
 testRunner.When(string.Format("поле ввода \'{0}\' заполнено значением \'{1}\'", имяПоля, значение), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 35
 testRunner.Then(string.Format("отображается значение \'{0}\' в поле ввода \'{1}\'", значение, имяПоля), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Переход по ссылкам экрана Авторизации")]
        [NUnit.Framework.CategoryAttribute("link_click")]
        [NUnit.Framework.TestCaseAttribute("Восстановить пароль", "https://my.life-pos.ru/auth/recovery", new string[] {
                "recovery",
                "id_cl001"}, Category="recovery,id_cl001")]
        [NUnit.Framework.TestCaseAttribute("Заведите аккаунт", "https://my.life-pos.ru/auth/sign-up", new string[] {
                "sign_up",
                "id_cl002"}, Category="sign_up,id_cl002")]
        public virtual void ПереходПоСсылкамЭкранаАвторизации(string текстСсылки, string ссылка, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "link_click"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Текст ссылки", текстСсылки);
            argumentsOfScenario.Add("Ссылка", ссылка);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Переход по ссылкам экрана Авторизации", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 48
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 49
 testRunner.Given("Открыта страница авторизации LifePay", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line hidden
#line 50
 testRunner.When(string.Format("происходит нажатие на ссылку \'{0}\'", текстСсылки), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 51
 testRunner.Then(string.Format("происходит переход по ссылке \'{0}\'", ссылка), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Отображение предупреждения полей ввода при введении триггерных значений")]
        [NUnit.Framework.CategoryAttribute("warning_displayed")]
        [NUnit.Framework.TestCaseAttribute("Номер телефона", "+7(911)111-11-12", "Номер не зарегистрирован", new string[] {
                "unreg_phone",
                "id_di001"}, Category="unreg_phone,id_di001")]
        [NUnit.Framework.TestCaseAttribute("Номер телефона", "+7(911)111-11-1", "Введите телефон в формате +7(911)111-11-11", new string[] {
                "incor_phone",
                "id_di002"}, Category="incor_phone,id_di002")]
        [NUnit.Framework.TestCaseAttribute("Пароль", "@1234", "Значение должно быть не менее 6 знаков", new string[] {
                "incor_length_pass",
                "id_di003"}, Category="incor_length_pass,id_di003")]
        public virtual void ОтображениеПредупрежденияПолейВводаПриВведенииТриггерныхЗначений(string имяПоля, string значение, string предупреждение, string[] exampleTags)
        {
            string[] @__tags = new string[] {
                    "warning_displayed"};
            if ((exampleTags != null))
            {
                @__tags = System.Linq.Enumerable.ToArray(System.Linq.Enumerable.Concat(@__tags, exampleTags));
            }
            string[] tagsOfScenario = @__tags;
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            argumentsOfScenario.Add("Имя поля", имяПоля);
            argumentsOfScenario.Add("Значение", значение);
            argumentsOfScenario.Add("Предупреждение", предупреждение);
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Отображение предупреждения полей ввода при введении триггерных значений", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 64
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 65
 testRunner.Given("Открыта страница авторизации LifePay", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line hidden
#line 66
 testRunner.When(string.Format("поле ввода \'<имя Поля>\' заполнено значением \'{0}\'", значение), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 67
 testRunner.Then(string.Format("отображается предупреждение \'{0}\' в поле \'<имя Поля>\'", предупреждение), ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Успешная авторизация")]
        [NUnit.Framework.CategoryAttribute("auth_no_inplim")]
        [NUnit.Framework.CategoryAttribute("id_au001")]
        public virtual void УспешнаяАвторизация()
        {
            string[] tagsOfScenario = new string[] {
                    "auth_no_inplim",
                    "id_au001"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Успешная авторизация", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 87
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 88
 testRunner.Given("Открыта страница авторизации LifePay", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line hidden
#line 89
 testRunner.When("поле ввода Номер телефона заполнено значением", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 90
 testRunner.And("поле ввода Пароль заполнено значением", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 91
 testRunner.And("нажата кнопка Войти в личный кабинет", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 92
 testRunner.Then("происходит редирект в личный кабинет", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("Успешная регистрация")]
        [NUnit.Framework.CategoryAttribute("reg_no_inplim")]
        [NUnit.Framework.CategoryAttribute("id_re001")]
        public virtual void УспешнаяРегистрация()
        {
            string[] tagsOfScenario = new string[] {
                    "reg_no_inplim",
                    "id_re001"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("Успешная регистрация", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 95
this.ScenarioInitialize(scenarioInfo);
#line hidden
            bool isScenarioIgnored = default(bool);
            bool isFeatureIgnored = default(bool);
            if ((tagsOfScenario != null))
            {
                isScenarioIgnored = tagsOfScenario.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((this._featureTags != null))
            {
                isFeatureIgnored = this._featureTags.Where(__entry => __entry != null).Where(__entry => String.Equals(__entry, "ignore", StringComparison.CurrentCultureIgnoreCase)).Any();
            }
            if ((isScenarioIgnored || isFeatureIgnored))
            {
                testRunner.SkipScenario();
            }
            else
            {
                this.ScenarioStart();
#line 96
 testRunner.Given("Открыта страница авторизации LifePay", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Допустим ");
#line hidden
#line 97
 testRunner.When("поле ввода Номер телефона заполнено значением", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Когда ");
#line hidden
#line 98
 testRunner.And("поле ввода Код из SMS заполнено", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 99
 testRunner.And("поле ввода Ваше имя и фамилия заполнено", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 100
 testRunner.And("поле ввода Пароль заполнено значением", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 101
 testRunner.And("нажата кнопка Создать личный кабинет", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "И ");
#line hidden
#line 102
 testRunner.Then("происходит редирект в личный кабинет", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Тогда ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
