<<<<<<< HEAD
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
=======
using System;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.TestLaunchers
{
    internal interface IRemoteTestResultDataFactory
    {
        RemoteTestResultDataWithTestData CreateFromTestResult(ITestResult result);
        RemoteTestResultDataWithTestData CreateFromTest(ITest test);
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
