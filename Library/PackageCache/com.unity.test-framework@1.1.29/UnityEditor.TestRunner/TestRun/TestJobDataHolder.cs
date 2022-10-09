<<<<<<< HEAD
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.TestRun
{
    internal class TestJobDataHolder : ScriptableSingleton<TestJobDataHolder>
    {
        [SerializeField]
        public List<TestJobData> TestRuns = new List<TestJobData>();
        
        [InitializeOnLoadMethod]
        private static void ResumeRunningJobs()
        {
            foreach (var testRun in instance.TestRuns.ToArray())
            {
                if (testRun.isRunning)
                {
                    var runner = new TestJobRunner();
                    runner.RunJob(testRun);
                }
                else
                {
                    instance.TestRuns.Remove(testRun);
                }
            }
        }
    }
=======
using System.Collections.Generic;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.TestRun
{
    internal class TestJobDataHolder : ScriptableSingleton<TestJobDataHolder>
    {
        [SerializeField]
        public List<TestJobData> TestRuns = new List<TestJobData>();
        
        [InitializeOnLoadMethod]
        private static void ResumeRunningJobs()
        {
            foreach (var testRun in instance.TestRuns.ToArray())
            {
                if (testRun.isRunning)
                {
                    var runner = new TestJobRunner();
                    runner.RunJob(testRun);
                }
                else
                {
                    instance.TestRuns.Remove(testRun);
                }
            }
        }
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}