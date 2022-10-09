<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ITestRunnerApi
    {
        string Execute(ExecutionSettings executionSettings);
        void RegisterCallbacks<T>(T testCallbacks, int priority = 0) where T : ICallbacks;
        void UnregisterCallbacks<T>(T testCallbacks) where T : ICallbacks;
        void RetrieveTestList(TestMode testMode, Action<ITestAdaptor> callback);
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    internal interface ITestRunnerApi
    {
        string Execute(ExecutionSettings executionSettings);
        void RegisterCallbacks<T>(T testCallbacks, int priority = 0) where T : ICallbacks;
        void UnregisterCallbacks<T>(T testCallbacks) where T : ICallbacks;
        void RetrieveTestList(TestMode testMode, Action<ITestAdaptor> callback);
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
