using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;
using WinAppDriverTest.Pages;

namespace WinAppDriverTest.Steps
{
    [Binding]
    public class CalcStepDef
    {
        CalculatorPage calculatorPage = new CalculatorPage();
        [Given(@"I open the calculator application")]
        public void GivenIOpenTheCalculatorApplication()
        {
            //ScenarioContext.Current.Pending();
        }

        [Given(@"I click following numbers")]
        public void GivenIClickFollowingNumbers(Table table)
        {
            dynamic data = table.CreateDynamicSet();
            foreach (var number in data)
            {
                if ((string)number.Numbers == "Nine")
                    calculatorPage.btn9.Click();
                else if ((string)number.Numbers == "Five")
                    calculatorPage.btn5.Click();
                else if ((string)number.Numbers == "Seven")
                    calculatorPage.btn7.Click();
            }
        }

        [Given(@"I perform Addition operation")]
        public void GivenIPerformAdditionOperation()
        {
            calculatorPage.btnPlus.Click();
        }

        [Given(@"I click equals")]
        public void GivenIClickEquals()
        {
            calculatorPage.btnEqual.Click();
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            var actual = calculatorPage.getResult();
            string formattedResult = $"Display is {result}";
            Assert.That(actual, Is.EqualTo(formattedResult), "Result is not matching"); 
        }

    }
}
