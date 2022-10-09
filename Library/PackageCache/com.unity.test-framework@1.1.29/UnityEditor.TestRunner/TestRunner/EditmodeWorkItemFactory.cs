<<<<<<< HEAD
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditmodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new EditorEnumeratorTestWorkItem(method, filter);
        }
    }
}
=======
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditmodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new EditorEnumeratorTestWorkItem(method, filter);
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
