<<<<<<< HEAD
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal class PlaymodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new CoroutineTestWorkItem(method, filter);
        }
    }
}
=======
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal class PlaymodeWorkItemFactory : WorkItemFactory
    {
        protected override UnityWorkItem Create(TestMethod method, ITestFilter filter, ITest loadedTest)
        {
            return new CoroutineTestWorkItem(method, filter);
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
