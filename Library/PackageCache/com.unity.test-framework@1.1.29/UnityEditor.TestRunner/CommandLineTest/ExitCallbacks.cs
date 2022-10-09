<<<<<<< HEAD
using System;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    [Serializable]
    internal class ExitCallbacks : ScriptableObject, IErrorCallbacks
    {
        internal static bool preventExit;

        public void RunFinished(ITestResultAdaptor testResults)
        {
            if (preventExit)
            {
                return;
            }

            if (!ExitCallbacksDataHolder.instance.AnyTestsExecuted)
            {
                Debug.LogFormat(LogType.Warning, LogOption.NoStacktrace, null, "No tests were executed");
            }

            EditorApplication.Exit(ExitCallbacksDataHolder.instance.RunFailed ? (int)Executer.ReturnCodes.Failed : (int)Executer.ReturnCodes.Ok);
        }

        public void TestStarted(ITestAdaptor test)
        {
            if (!test.IsSuite)
            {
                ExitCallbacksDataHolder.instance.AnyTestsExecuted = true;
            }
        }

        public void TestFinished(ITestResultAdaptor result)
        {
            if (!result.Test.IsSuite && (result.TestStatus == TestStatus.Failed || result.TestStatus == TestStatus.Inconclusive))
            {
                ExitCallbacksDataHolder.instance.RunFailed = true;
            }
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
        }

        public void OnError(string message)
        {
            EditorApplication.Exit((int)Executer.ReturnCodes.RunError);
        }
    }
}
=======
using System;
using UnityEditor.TestTools.TestRunner.Api;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    [Serializable]
    internal class ExitCallbacks : ScriptableObject, IErrorCallbacks
    {
        internal static bool preventExit;

        public void RunFinished(ITestResultAdaptor testResults)
        {
            if (preventExit)
            {
                return;
            }

            if (!ExitCallbacksDataHolder.instance.AnyTestsExecuted)
            {
                Debug.LogFormat(LogType.Warning, LogOption.NoStacktrace, null, "No tests were executed");
            }

            EditorApplication.Exit(ExitCallbacksDataHolder.instance.RunFailed ? (int)Executer.ReturnCodes.Failed : (int)Executer.ReturnCodes.Ok);
        }

        public void TestStarted(ITestAdaptor test)
        {
            if (!test.IsSuite)
            {
                ExitCallbacksDataHolder.instance.AnyTestsExecuted = true;
            }
        }

        public void TestFinished(ITestResultAdaptor result)
        {
            if (!result.Test.IsSuite && (result.TestStatus == TestStatus.Failed || result.TestStatus == TestStatus.Inconclusive))
            {
                ExitCallbacksDataHolder.instance.RunFailed = true;
            }
        }

        public void RunStarted(ITestAdaptor testsToRun)
        {
        }

        public void OnError(string message)
        {
            EditorApplication.Exit((int)Executer.ReturnCodes.RunError);
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
