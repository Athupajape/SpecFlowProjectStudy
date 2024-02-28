using OpenQA.Selenium.DevTools.V121.CacheStorage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow.Assist;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class RegistrationInfo
    {
        [Given(@"user lands on registration page\.")]
        public void GivenUserLandsOnRegistrationPage_()
        {
            //throw new PendingStepException();
        }

        [When(@"user enters registration details\.")]
        public void WhenUserEntersRegistrationDetails_(Table table)
        {
            foreach(TableRow row in table.Rows)
            {
                UserInformation userinfo =table.CreateInstance<UserInformation>();
                Console.WriteLine(userinfo.FirstName);
                //Console.WriteLine(row["Gender"]);
                //Console.WriteLine(row["FirstName"]);
                //foreach(string header in table.Header)
                //{
                //    Console.WriteLine(row[header]);
                //}
            }
        }

    }
}
