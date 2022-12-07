/*
 * Created by Ranorex
 * User: OscarMiguel
 * Date: 07/12/2022
 * Time: 05:01 a. m.
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
using NUnit.Framework.Internal;
using TechTalk.SpecFlow;
using BDD2.Recordings;

namespace BDD2.Feature
{
    [Binding]
    public class Addition
    {
		private readonly ScenarioContext _scenarioContext;
		private BDD2Repository _repo;

	    public Addition(ScenarioContext scenarioContext)
	    {
	        _scenarioContext = scenarioContext;
	        _repo = BDD2Repository.Instance;
	    }
		
        [Given("I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredSomethingIntoTheCalculator(int number)
        {
        	string text = number.ToString();

        	EnterNumber.Instance.
        		Mouse_Click_Screen(_repo.Calculadora.ScreenInfo);
        	EnterNumber.Instance.
        		Key_sequence_Calculadora(_repo.Calculadora.ScreenInfo, text);
        }

        [Given("I press add")]
        public void GivenIPressAdd()
        {
        	PressAdd.Start();
        }
        
        [When("I press equals")]
        public void GivenIPressEquals()
        {
        	PressEquals.Start();
        }

        [Then("the result should be (.*) on the screen")]
        public void ThenTheResultShouldBe(int result)
        {
        	ValidateScreen.Instance.
        		ValidateScreenValue(_repo.Calculadora.ScreenInfo, result.ToString());
        }
    }
}
