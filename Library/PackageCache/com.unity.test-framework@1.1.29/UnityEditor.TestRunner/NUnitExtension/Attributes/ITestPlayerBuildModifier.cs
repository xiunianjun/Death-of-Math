<<<<<<< HEAD
namespace UnityEditor.TestTools
{
    /// <summary>
    /// An interface for a callback modifying the <see cref="BuildPlayerOptions"/> when building a player for running tests in the runtime.
    /// </summary>
    public interface ITestPlayerBuildModifier
    {
        /// <summary>
        /// A callback to modify the <see cref="BuildPlayerOptions"/> when building a player for test run. Return the modified version of the provided build options.
        /// </summary>
        /// <param name="playerOptions">The unmodified BuildPlayerOptions.</param>
        /// <returns>The modified BuildPlayerOptions.</returns>
        BuildPlayerOptions ModifyOptions(BuildPlayerOptions playerOptions);
    }
=======
namespace UnityEditor.TestTools
{
    /// <summary>
    /// An interface for a callback modifying the <see cref="BuildPlayerOptions"/> when building a player for running tests in the runtime.
    /// </summary>
    public interface ITestPlayerBuildModifier
    {
        /// <summary>
        /// A callback to modify the <see cref="BuildPlayerOptions"/> when building a player for test run. Return the modified version of the provided build options.
        /// </summary>
        /// <param name="playerOptions">The unmodified BuildPlayerOptions.</param>
        /// <returns>The modified BuildPlayerOptions.</returns>
        BuildPlayerOptions ModifyOptions(BuildPlayerOptions playerOptions);
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}