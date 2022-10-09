<<<<<<< HEAD

using System.Collections;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal class FailCommand : TestCommand, IEnumerableTestMethodCommand
    {
        private ResultState m_ResultState;
        private string m_Message;

        public FailCommand(Test test, ResultState resultState, string message)
            : base(test)
        {
            m_ResultState = resultState;
            m_Message = message;
        }

        public override TestResult Execute(ITestExecutionContext context)
        {
            context.CurrentResult.SetResult(m_ResultState, m_Message);
            return context.CurrentResult;
        }

        public IEnumerable ExecuteEnumerable(ITestExecutionContext context)
        {
            context.CurrentResult.SetResult(m_ResultState, m_Message);
            yield return null;
        }
    }

=======

using System.Collections;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Commands;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal class FailCommand : TestCommand, IEnumerableTestMethodCommand
    {
        private ResultState m_ResultState;
        private string m_Message;

        public FailCommand(Test test, ResultState resultState, string message)
            : base(test)
        {
            m_ResultState = resultState;
            m_Message = message;
        }

        public override TestResult Execute(ITestExecutionContext context)
        {
            context.CurrentResult.SetResult(m_ResultState, m_Message);
            return context.CurrentResult;
        }

        public IEnumerable ExecuteEnumerable(ITestExecutionContext context)
        {
            context.CurrentResult.SetResult(m_ResultState, m_Message);
            yield return null;
        }
    }

>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}