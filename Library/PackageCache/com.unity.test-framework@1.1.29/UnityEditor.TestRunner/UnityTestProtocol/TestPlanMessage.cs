<<<<<<< HEAD
using System.Collections.Generic;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestPlanMessage : Message
    {
        public List<string> tests;

        public TestPlanMessage()
        {
            type = "TestPlan";
        }
    }
}
=======
using System.Collections.Generic;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestPlanMessage : Message
    {
        public List<string> tests;

        public TestPlanMessage()
        {
            type = "TestPlan";
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
