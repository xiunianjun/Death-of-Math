<<<<<<< HEAD
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TestTools.TestRunner.GUI;

namespace TestRunner.Callbacks
{
    internal class WindowResultUpdaterDataHolder : ScriptableSingleton<WindowResultUpdaterDataHolder>
    {
        public List<TestRunnerResult> CachedResults = new List<TestRunnerResult>();
    }
=======
using System.Collections.Generic;
using UnityEditor;
using UnityEditor.TestTools.TestRunner.GUI;

namespace TestRunner.Callbacks
{
    internal class WindowResultUpdaterDataHolder : ScriptableSingleton<WindowResultUpdaterDataHolder>
    {
        public List<TestRunnerResult> CachedResults = new List<TestRunnerResult>();
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}