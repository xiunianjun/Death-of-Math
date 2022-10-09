<<<<<<< HEAD
using System;
using NUnit.Framework.Interfaces;
using UnityEngine.Events;

namespace UnityEngine.TestTools.TestRunner
{
    internal interface ITestRunnerListener
    {
        void RunStarted(ITest testsToRun);
        void RunFinished(ITestResult testResults);
        void TestStarted(ITest test);
        void TestFinished(ITestResult result);
    }

    [Serializable]
    internal class TestFinishedEvent : UnityEvent<ITestResult> {}

    [Serializable]
    internal class TestStartedEvent : UnityEvent<ITest> {}

    [Serializable]
    internal class RunFinishedEvent : UnityEvent<ITestResult> {}

    [Serializable]
    internal class RunStartedEvent : UnityEvent<ITest> {}
}
=======
using System;
using NUnit.Framework.Interfaces;
using UnityEngine.Events;

namespace UnityEngine.TestTools.TestRunner
{
    internal interface ITestRunnerListener
    {
        void RunStarted(ITest testsToRun);
        void RunFinished(ITestResult testResults);
        void TestStarted(ITest test);
        void TestFinished(ITestResult result);
    }

    [Serializable]
    internal class TestFinishedEvent : UnityEvent<ITestResult> {}

    [Serializable]
    internal class TestStartedEvent : UnityEvent<ITest> {}

    [Serializable]
    internal class RunFinishedEvent : UnityEvent<ITestResult> {}

    [Serializable]
    internal class RunStartedEvent : UnityEvent<ITest> {}
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
