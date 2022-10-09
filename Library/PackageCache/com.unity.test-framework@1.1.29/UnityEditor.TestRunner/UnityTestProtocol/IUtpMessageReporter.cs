<<<<<<< HEAD
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal interface IUtpMessageReporter
    {
        void ReportTestFinished(ITestResultAdaptor result);
        void ReportTestRunStarted(ITestAdaptor testsToRun);
        void ReportTestStarted(ITestAdaptor test);
    }
}
=======
using System.Collections.Generic;
using UnityEditor.Compilation;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal interface IUtpMessageReporter
    {
        void ReportTestFinished(ITestResultAdaptor result);
        void ReportTestRunStarted(ITestAdaptor testsToRun);
        void ReportTestStarted(ITestAdaptor test);
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
