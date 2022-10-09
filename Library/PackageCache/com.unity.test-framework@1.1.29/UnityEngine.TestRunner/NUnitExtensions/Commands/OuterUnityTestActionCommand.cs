<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEngine.TestTools
{
    internal class OuterUnityTestActionCommand : BeforeAfterTestCommandBase<IOuterUnityTestAction>
    {
        static readonly Dictionary<MethodInfo, List<IOuterUnityTestAction>> m_TestActionsCache = new Dictionary<MethodInfo, List<IOuterUnityTestAction>>();
        public OuterUnityTestActionCommand(TestCommand innerCommand)
            : base(innerCommand, "BeforeTest", "AfterTest")
        {
            if (Test.TypeInfo.Type != null)
            {
                BeforeActions = GetTestActions(m_TestActionsCache, Test.Method.MethodInfo);
                AfterActions = BeforeActions;
            }
        }

        protected override IEnumerator InvokeBefore(IOuterUnityTestAction action, Test test, UnityTestExecutionContext context)
        {
            return action.BeforeTest(test);
        }

        protected override IEnumerator InvokeAfter(IOuterUnityTestAction action, Test test, UnityTestExecutionContext context)
        {
            return action.AfterTest(test);
        }

        protected override BeforeAfterTestCommandState GetState(UnityTestExecutionContext context)
        {
            return context.OuterUnityTestActionState;
        }
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;
using UnityEngine.TestRunner.NUnitExtensions.Runner;

namespace UnityEngine.TestTools
{
    internal class OuterUnityTestActionCommand : BeforeAfterTestCommandBase<IOuterUnityTestAction>
    {
        static readonly Dictionary<MethodInfo, List<IOuterUnityTestAction>> m_TestActionsCache = new Dictionary<MethodInfo, List<IOuterUnityTestAction>>();
        public OuterUnityTestActionCommand(TestCommand innerCommand)
            : base(innerCommand, "BeforeTest", "AfterTest")
        {
            if (Test.TypeInfo.Type != null)
            {
                BeforeActions = GetTestActions(m_TestActionsCache, Test.Method.MethodInfo);
                AfterActions = BeforeActions;
            }
        }

        protected override IEnumerator InvokeBefore(IOuterUnityTestAction action, Test test, UnityTestExecutionContext context)
        {
            return action.BeforeTest(test);
        }

        protected override IEnumerator InvokeAfter(IOuterUnityTestAction action, Test test, UnityTestExecutionContext context)
        {
            return action.AfterTest(test);
        }

        protected override BeforeAfterTestCommandState GetState(UnityTestExecutionContext context)
        {
            return context.OuterUnityTestActionState;
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
