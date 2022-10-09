<<<<<<< HEAD
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class UnityTestProtocolListener : ScriptableObject, ICallbacks
    {
        private IUtpMessageReporter m_UtpMessageReporter;

        public UnityTestProtocolListener()
        {
            m_UtpMessageReporter = new UtpMessageReporter(new UtpDebugLogger());
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
            m_UtpMessageReporter.ReportTestRunStarted(testsToRun);
        }

        public void RunFinished(ITestResultAdaptor testResults)
        {
            // Apparently does nothing :)
        }

        public void TestStarted(ITestAdaptor test)
        {
            m_UtpMessageReporter.ReportTestStarted(test);
        }

        public void TestFinished(ITestResultAdaptor result)
        {
            m_UtpMessageReporter.ReportTestFinished(result);
        }
    }
}
=======
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class UnityTestProtocolListener : ScriptableObject, ICallbacks
    {
        private IUtpMessageReporter m_UtpMessageReporter;

        public UnityTestProtocolListener()
        {
            m_UtpMessageReporter = new UtpMessageReporter(new UtpDebugLogger());
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
            m_UtpMessageReporter.ReportTestRunStarted(testsToRun);
        }

        public void RunFinished(ITestResultAdaptor testResults)
        {
            // Apparently does nothing :)
        }

        public void TestStarted(ITestAdaptor test)
        {
            m_UtpMessageReporter.ReportTestStarted(test);
        }

        public void TestFinished(ITestResultAdaptor result)
        {
            m_UtpMessageReporter.ReportTestFinished(result);
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
