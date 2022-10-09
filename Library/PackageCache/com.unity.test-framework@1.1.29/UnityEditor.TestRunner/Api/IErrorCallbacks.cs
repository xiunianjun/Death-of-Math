<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.Api
{
    /// <summary>
    /// An extended version of the <see cref="ICallbacks"/>, which get invoked if the test run fails due to a build error or if any <see cref="UnityEngine.TestTools.IPrebuildSetup"/> has a failure.
    /// </summary>
    public interface IErrorCallbacks : ICallbacks
    {
        /// <summary>
        /// Method invoked on failure.
        /// </summary>
        /// <param name="message">
        /// The error message detailing the reason for the run to fail.
        /// </param>
        void OnError(string message);
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.Api
{
    /// <summary>
    /// An extended version of the <see cref="ICallbacks"/>, which get invoked if the test run fails due to a build error or if any <see cref="UnityEngine.TestTools.IPrebuildSetup"/> has a failure.
    /// </summary>
    public interface IErrorCallbacks : ICallbacks
    {
        /// <summary>
        /// Method invoked on failure.
        /// </summary>
        /// <param name="message">
        /// The error message detailing the reason for the run to fail.
        /// </param>
        void OnError(string message);
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
