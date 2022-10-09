<<<<<<< HEAD
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    class PlayerLauncherTestRunSettings : ITestRunSettings
    {
        public bool buildOnly { set; get; }

        public string buildOnlyLocationPath { set; get; }

        public void Dispose()
        {
        }

        void ITestRunSettings.Apply()
        {
        }
    }
=======
using UnityEditor.TestTools.TestRunner.Api;

namespace UnityEditor.TestTools.TestRunner
{
    class PlayerLauncherTestRunSettings : ITestRunSettings
    {
        public bool buildOnly { set; get; }

        public string buildOnlyLocationPath { set; get; }

        public void Dispose()
        {
        }

        void ITestRunSettings.Apply()
        {
        }
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}