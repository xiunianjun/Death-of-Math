<<<<<<< HEAD
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    interface ITestRunnerApiMapper
    {
        string GetRunStateFromResultNunitXml(ITestResultAdaptor result);
        TestState GetTestStateFromResult(ITestResultAdaptor result);
        List<string> FlattenTestNames(ITestAdaptor testsToRun);
        TestPlanMessage MapTestToTestPlanMessage(ITestAdaptor testsToRun);
        TestStartedMessage MapTestToTestStartedMessage(ITestAdaptor test);
        TestFinishedMessage TestResultToTestFinishedMessage(ITestResultAdaptor result);
    }
}
=======
using System.Collections.Generic;
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    interface ITestRunnerApiMapper
    {
        string GetRunStateFromResultNunitXml(ITestResultAdaptor result);
        TestState GetTestStateFromResult(ITestResultAdaptor result);
        List<string> FlattenTestNames(ITestAdaptor testsToRun);
        TestPlanMessage MapTestToTestPlanMessage(ITestAdaptor testsToRun);
        TestStartedMessage MapTestToTestStartedMessage(ITestAdaptor test);
        TestFinishedMessage TestResultToTestFinishedMessage(ITestResultAdaptor result);
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
