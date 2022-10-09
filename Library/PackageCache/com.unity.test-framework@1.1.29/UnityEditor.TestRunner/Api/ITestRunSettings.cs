<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    /// <summary>
    /// ITestRunSettings lets you set any of the global settings right before building a Player for a test run and then reverts the settings afterward. ITestRunSettings implements 
    /// [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable?view=netframework-4.8), and runs after building the Player with tests.
    /// </summary>
    public interface ITestRunSettings : IDisposable
    {
        /// <summary>
        /// A method called before building the Player.
        /// </summary>
        void Apply();
    }
}
=======
using System;

namespace UnityEditor.TestTools.TestRunner.Api
{
    /// <summary>
    /// ITestRunSettings lets you set any of the global settings right before building a Player for a test run and then reverts the settings afterward. ITestRunSettings implements 
    /// [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable?view=netframework-4.8), and runs after building the Player with tests.
    /// </summary>
    public interface ITestRunSettings : IDisposable
    {
        /// <summary>
        /// A method called before building the Player.
        /// </summary>
        void Apply();
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
