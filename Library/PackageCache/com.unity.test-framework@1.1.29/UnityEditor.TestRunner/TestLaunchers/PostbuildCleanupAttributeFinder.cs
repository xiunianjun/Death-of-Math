<<<<<<< HEAD
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PostbuildCleanupAttributeFinder : AttributeFinderBase<IPostBuildCleanup, PostBuildCleanupAttribute>
    {
        public PostbuildCleanupAttributeFinder() : base(attribute => attribute.TargetClass) {}
    }
}
=======
using UnityEngine.TestTools;

namespace UnityEditor.TestTools.TestRunner
{
    internal class PostbuildCleanupAttributeFinder : AttributeFinderBase<IPostBuildCleanup, PostBuildCleanupAttribute>
    {
        public PostbuildCleanupAttributeFinder() : base(attribute => attribute.TargetClass) {}
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
