using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace SpecflowDemoBDD.Steps
{
    [Binding]
    public class googlesearchStep
    {
        [Given(@"I have navigated to Google page")]
        public void GivenIHaveNavigatedToGooglePage()
        {
            ScenarioContext.Current.Pending();
        }

        [Given(@"I see the google page fully loaded")]
        public void GivenISeeTheGooglePageFullyLoaded()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I type search keyword as")]
        public void WhenITypeSearchKeywordAs(Table table)
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"I should see the result for keyword")]
        public void ThenIShouldSeeTheResultForKeyword(Table table)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
