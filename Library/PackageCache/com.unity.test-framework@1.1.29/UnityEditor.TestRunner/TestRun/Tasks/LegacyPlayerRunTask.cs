<<<<<<< HEAD
using System.Collections;
using System.Linq;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyPlayerRunTask : TestTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var executionSettings = testJobData.executionSettings;
            var settings = PlaymodeTestsControllerSettings.CreateRunnerSettings(executionSettings.filters.Select(filter => filter.ToRuntimeTestRunnerFilter(executionSettings.runSynchronously)).ToArray());
            var launcher = new PlayerLauncher(settings, executionSettings.targetPlatform, executionSettings.overloadTestRunSettings, executionSettings.playerHeartbeatTimeout);
            launcher.Run();
            yield return null;
        }
    }
=======
using System.Collections;
using System.Linq;
using UnityEngine.TestTools.TestRunner;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class LegacyPlayerRunTask : TestTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var executionSettings = testJobData.executionSettings;
            var settings = PlaymodeTestsControllerSettings.CreateRunnerSettings(executionSettings.filters.Select(filter => filter.ToRuntimeTestRunnerFilter(executionSettings.runSynchronously)).ToArray());
            var launcher = new PlayerLauncher(settings, executionSettings.targetPlatform, executionSettings.overloadTestRunSettings, executionSettings.playerHeartbeatTimeout);
            launcher.Run();
            yield return null;
        }
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}