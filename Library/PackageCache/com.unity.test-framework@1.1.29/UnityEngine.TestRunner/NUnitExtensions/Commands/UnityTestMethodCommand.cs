<<<<<<< HEAD
﻿using System;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using Unity.Profiling;

namespace UnityEngine.TestTools
{
    internal class UnityTestMethodCommand : TestMethodCommand
    {
        public UnityTestMethodCommand(TestMethod testMethod)
            : base(testMethod) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            using (new ProfilerMarker(Test.FullName).Auto())
                return base.Execute(context);
        }
    }
}
=======
﻿using System;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using Unity.Profiling;

namespace UnityEngine.TestTools
{
    internal class UnityTestMethodCommand : TestMethodCommand
    {
        public UnityTestMethodCommand(TestMethod testMethod)
            : base(testMethod) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            using (new ProfilerMarker(Test.FullName).Auto())
                return base.Execute(context);
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
