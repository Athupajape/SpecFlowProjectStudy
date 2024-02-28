using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecFlowProject.StepDefinitions
{
    [Binding]
    public class Event
    {
        FeatureContext _fc;

        public Event(FeatureContext fc)
        {                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                               
            this._fc = fc;
        }

        [Given(@"display employee full name")]
        public void GivenDisplayEmployeeFullName()
        {
            Console.WriteLine(_fc["EmployeeFullName"]);
        }

    }
}
