<<<<<<< HEAD
﻿using System;
using System.Collections;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEngine.TestTools
{
    internal class ImmediateEnumerableCommand : DelegatingTestCommand
    {
        public ImmediateEnumerableCommand(TestCommand innerCommand)
            : base(innerCommand) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            if (innerCommand is IEnumerableTestMethodCommand)
            {
                var executeEnumerable = ((IEnumerableTestMethodCommand)innerCommand).ExecuteEnumerable(context);
                foreach (var iterator in executeEnumerable)
                {
                    if (iterator != null)
                    {
                        throw new Exception("Only null can be yielded at this point.");
                    }
                }
                return context.CurrentResult;
            }

            return innerCommand.Execute(context);
        }
    }
}
=======
﻿using System;
using System.Collections;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEngine.TestTools
{
    internal class ImmediateEnumerableCommand : DelegatingTestCommand
    {
        public ImmediateEnumerableCommand(TestCommand innerCommand)
            : base(innerCommand) { }

        public override TestResult Execute(ITestExecutionContext context)
        {
            if (innerCommand is IEnumerableTestMethodCommand)
            {
                var executeEnumerable = ((IEnumerableTestMethodCommand)innerCommand).ExecuteEnumerable(context);
                foreach (var iterator in executeEnumerable)
                {
                    if (iterator != null)
                    {
                        throw new Exception("Only null can be yielded at this point.");
                    }
                }
                return context.CurrentResult;
            }

            return innerCommand.Execute(context);
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
