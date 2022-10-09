<<<<<<< HEAD
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PrebuildSetupAttributeFinder : AttributeFinderBase<IPrebuildSetup, PrebuildSetupAttribute>
    {
        public PrebuildSetupAttributeFinder() : base((attribute) => attribute.TargetClass) {}
    }
}
=======
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PrebuildSetupAttributeFinder : AttributeFinderBase<IPrebuildSetup, PrebuildSetupAttribute>
    {
        public PrebuildSetupAttributeFinder() : base((attribute) => attribute.TargetClass) {}
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
