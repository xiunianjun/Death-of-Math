<<<<<<< HEAD
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class ExitCallbacksDataHolder : ScriptableSingleton<ExitCallbacksDataHolder>
    {
        [SerializeField] 
        public bool AnyTestsExecuted;
        [SerializeField]
        public bool RunFailed;
    }
=======
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.CommandLineTest
{
    internal class ExitCallbacksDataHolder : ScriptableSingleton<ExitCallbacksDataHolder>
    {
        [SerializeField] 
        public bool AnyTestsExecuted;
        [SerializeField]
        public bool RunFailed;
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}