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
namespace INSS.EIIR.QA.Automation.Features
{
    using TechTalk.SpecFlow;
    using System;
    using System.Linq;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("TechTalk.SpecFlow", "3.9.0.0")]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    [NUnit.Framework.TestFixtureAttribute()]
    [NUnit.Framework.DescriptionAttribute("ATU_15 Citizen - Start Page")]
    public partial class ATU_15Citizen_StartPageFeature
    {
        
        private TechTalk.SpecFlow.ITestRunner testRunner;
        
        private string[] _featureTags = ((string[])(null));
        
#line 1 "ATU_15_StartPage.feature"
#line hidden
        
        [NUnit.Framework.OneTimeSetUpAttribute()]
        public virtual void FeatureSetup()
        {
            testRunner = TechTalk.SpecFlow.TestRunnerManager.GetTestRunner();
            TechTalk.SpecFlow.FeatureInfo featureInfo = new TechTalk.SpecFlow.FeatureInfo(new System.Globalization.CultureInfo("en-US"), "Features", "ATU_15 Citizen - Start Page", "\tAs a user\r\n\tI need the EIIR sinitial start page updated in line with the new pro" +
                    "totype screen [URL]\r\n\tSo that I can search EIIR using this new screen design", ProgrammingLanguage.CSharp, ((string[])(null)));
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
        
        public virtual void FeatureBackground()
        {
#line 7
#line hidden
#line 8
testRunner.Given("I navigate to the EIIR Start Page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Given ");
#line hidden
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the EIIR start page URL, title and page heading")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheEIIRStartPageURLTitleAndPageHeading()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the EIIR start page URL, title and page heading", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 11
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
this.FeatureBackground();
#line hidden
#line 12
testRunner.Then("the EIIR Start page will be displayed and the URL, page title and H1 will be as p" +
                        "er requirements", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the \'Start now\' button takes the user to the Search screen")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheStartNowButtonTakesTheUserToTheSearchScreen()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the \'Start now\' button takes the user to the Search screen", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 15
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
this.FeatureBackground();
#line hidden
#line 16
testRunner.When("I click the \'Start now\' button", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 17
testRunner.Then("I am taken to the Search page", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the navigation of the Terms and conditions footer link on the EIIR " +
            "start page")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheNavigationOfTheTermsAndConditionsFooterLinkOnTheEIIRStartPage()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the navigation of the Terms and conditions footer link on the EIIR " +
                    "start page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 20
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
this.FeatureBackground();
#line hidden
#line 21
testRunner.When("I click the \"Terms and conditions - footer\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 22
testRunner.Then("the following URL is displayed \"https://app-uksouth-sit-eiir-web.azurewebsites.ne" +
                        "t/home/terms-and-conditions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the navigation of the Privacy footer link on the EIIR start page")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheNavigationOfThePrivacyFooterLinkOnTheEIIRStartPage()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the navigation of the Privacy footer link on the EIIR start page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 25
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
this.FeatureBackground();
#line hidden
#line 26
testRunner.When("I click the \"Privacy - footer\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 27
testRunner.Then("the following URL is displayed \"https://app-uksouth-sit-eiir-web.azurewebsites.ne" +
                        "t/home/privacy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the navigation of the Accessibility Statement footer link on the EI" +
            "IR start page")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheNavigationOfTheAccessibilityStatementFooterLinkOnTheEIIRStartPage()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the navigation of the Accessibility Statement footer link on the EI" +
                    "IR start page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 30
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
this.FeatureBackground();
#line hidden
#line 31
testRunner.When("I click the \"Accessibility statement - footer\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 32
testRunner.Then("the following URL is displayed \"https://app-uksouth-sit-eiir-web.azurewebsites.ne" +
                        "t/home/accessibility-statement\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the navigation of the Terms and conditions hyperlink on the EIIR st" +
            "art page")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheNavigationOfTheTermsAndConditionsHyperlinkOnTheEIIRStartPage()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the navigation of the Terms and conditions hyperlink on the EIIR st" +
                    "art page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 35
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
this.FeatureBackground();
#line hidden
#line 36
testRunner.When("I click the \"main content Terms and conditions\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 37
testRunner.Then("the following URL is displayed \"https://app-uksouth-sit-eiir-web.azurewebsites.ne" +
                        "t/home/terms-and-conditions\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the navigation of the Insolvency Service hyperlink on the EIIR star" +
            "t page")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheNavigationOfTheInsolvencyServiceHyperlinkOnTheEIIRStartPage()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the navigation of the Insolvency Service hyperlink on the EIIR star" +
                    "t page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 40
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
this.FeatureBackground();
#line hidden
#line 41
testRunner.When("I click the \"main content Insolvency Service\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 42
testRunner.Then("the following URL is displayed \"https://www.gov.uk/government/organisations/insol" +
                        "vency-service\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the (Get help from the Insolvency Service) link in the Related cont" +
            "ent section on the EIIR start page")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheGetHelpFromTheInsolvencyServiceLinkInTheRelatedContentSectionOnTheEIIRStartPage()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the (Get help from the Insolvency Service) link in the Related cont" +
                    "ent section on the EIIR start page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 45
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
this.FeatureBackground();
#line hidden
#line 46
testRunner.When("I click the \"Related content - Get help from the Insolvency Service\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 47
testRunner.Then("the following URL is displayed \"https://www.gov.uk/get-help-insolvency-service\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the (Find out more about bankruptcy and insolvency) link in the Rel" +
            "ated content section on the EIIR start page")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheFindOutMoreAboutBankruptcyAndInsolvencyLinkInTheRelatedContentSectionOnTheEIIRStartPage()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the (Find out more about bankruptcy and insolvency) link in the Rel" +
                    "ated content section on the EIIR start page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 50
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
this.FeatureBackground();
#line hidden
#line 51
testRunner.When("I click the \"Related content - Find out more about bankruptcy and insolvency\" lin" +
                        "k", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 52
testRunner.Then("the following URL is displayed \"https://www.gov.uk/browse/tax/court-claims-debt-b" +
                        "ankruptcy\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
        
        [NUnit.Framework.TestAttribute()]
        [NUnit.Framework.DescriptionAttribute("ATU_15 Verify the (Give feedback about the Individual Insolvency Register) link i" +
            "n the Related content section on the EIIR start page")]
        [NUnit.Framework.CategoryAttribute("StartPage")]
        [NUnit.Framework.CategoryAttribute("Regression")]
        public virtual void ATU_15VerifyTheGiveFeedbackAboutTheIndividualInsolvencyRegisterLinkInTheRelatedContentSectionOnTheEIIRStartPage()
        {
            string[] tagsOfScenario = new string[] {
                    "StartPage",
                    "Regression"};
            System.Collections.Specialized.OrderedDictionary argumentsOfScenario = new System.Collections.Specialized.OrderedDictionary();
            TechTalk.SpecFlow.ScenarioInfo scenarioInfo = new TechTalk.SpecFlow.ScenarioInfo("ATU_15 Verify the (Give feedback about the Individual Insolvency Register) link i" +
                    "n the Related content section on the EIIR start page", null, tagsOfScenario, argumentsOfScenario, this._featureTags);
#line 55
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
this.FeatureBackground();
#line hidden
#line 56
testRunner.When("I click the \"Related content - Give feedback about the Individual Insolvency Regi" +
                        "ster\" link", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "When ");
#line hidden
#line 57
testRunner.Then("the following URL is displayed \"https://www.insolvencydirect.bis.gov.uk/eiir/IIRF" +
                        "eedbackPage.asp\"", ((string)(null)), ((TechTalk.SpecFlow.Table)(null)), "Then ");
#line hidden
            }
            this.ScenarioCleanup();
        }
    }
}
#pragma warning restore
#endregion
