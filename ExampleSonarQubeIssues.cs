using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sonarqube_nemo_on_appveyor
{
    public class ExampleSonarQubeIssues
    {
        private void EmptyMethod()
        {

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
