using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonarqube_nemo_on_appveyor
{
    // The full list of C# SonarQube rules is at http://dist.sonarsource.com/reports/coverage/rules/csharpsquid_rules_coverage.html
    public class ExampleSonarQubeIssues
    {
        void EmptyMethod()
        {

        }

        void InfiniteRecusrion()
        {
            InfiniteRecusrion();
        }

        public int ExceptionInProperty
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public void Example()
        {
            String unusedString;
        }
    }
}
