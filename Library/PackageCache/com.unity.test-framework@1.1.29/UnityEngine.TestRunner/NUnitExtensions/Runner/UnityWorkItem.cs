<<<<<<< HEAD
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Execution;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal abstract class UnityWorkItem
    {
        protected readonly WorkItemFactory m_Factory;
        protected bool m_ExecuteTestStartEvent;
        protected bool m_DontRunRestoringResult;
        protected const int k_DefaultTimeout = 1000 * 180;
        public event EventHandler Completed;

        public bool ResultedInDomainReload { get; internal set; }

        public UnityTestExecutionContext Context { get; private set; }

        public Test Test { get; private set; }

        public TestResult Result { get; protected set; }

        public WorkItemState State { get; private set; }

        public List<ITestAction> Actions { get; private set; }

        protected UnityWorkItem(Test test, WorkItemFactory factory)
        {
            m_Factory = factory;
            Test = test;
            Actions = new List<ITestAction>();
            Result = test.MakeTestResult();
            State = WorkItemState.Ready;
            m_ExecuteTestStartEvent = ShouldExecuteStartEvent();
            m_DontRunRestoringResult = ShouldRestore(test);
        }

        protected static bool ShouldRestore(ITest loadedTest)
        {
            return UnityWorkItemDataHolder.alreadyExecutedTests != null &&
                   UnityWorkItemDataHolder.alreadyExecutedTests.Contains(loadedTest.GetUniqueName());
        }

        protected bool ShouldExecuteStartEvent()
        {
            return UnityWorkItemDataHolder.alreadyStartedTests != null &&
                   UnityWorkItemDataHolder.alreadyStartedTests.All(x => x != Test.GetUniqueName()) &&
                   !ShouldRestore(Test);
        }

        protected abstract IEnumerable PerformWork();

        public void InitializeContext(UnityTestExecutionContext context)
        {
            Context = context;

            if (Test is TestAssembly)
                Actions.AddRange(ActionsHelper.GetActionsFromTestAssembly((TestAssembly)Test));
            else if (Test is ParameterizedMethodSuite)
                Actions.AddRange(ActionsHelper.GetActionsFromTestMethodInfo(Test.Method));
            else if (Test.TypeInfo != null)
                Actions.AddRange(ActionsHelper.GetActionsFromTypesAttributes(Test.TypeInfo.Type));
        }

        public virtual IEnumerable Execute()
        {
            Context.CurrentTest = this.Test;
            Context.CurrentResult = this.Result;

            if (m_ExecuteTestStartEvent)
            {
                Context.Listener.TestStarted(Test);
            }

            Context.StartTime = DateTime.UtcNow;
            Context.StartTicks = Stopwatch.GetTimestamp();

            State = WorkItemState.Running;

            return PerformWork();
        }

        protected void WorkItemComplete()
        {
            State = WorkItemState.Complete;

            Result.StartTime = Context.StartTime;
            Result.EndTime = DateTime.UtcNow;

            long tickCount = Stopwatch.GetTimestamp() - Context.StartTicks;
            double seconds = (double)tickCount / Stopwatch.Frequency;
            Result.Duration = seconds;

            //Result.AssertCount += Context.AssertCount;

            Context.Listener.TestFinished(Result);

            if (Completed != null)
                Completed(this, EventArgs.Empty);

            Context.TestObject = null;
            Test.Fixture = null;
        }

        public virtual void Cancel(bool force)
        {
            Result.SetResult(ResultState.Cancelled, "Cancelled by user");
            Context.Listener.TestFinished(Result);
        }
    }
}
=======
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using NUnit.Framework.Internal.Execution;

namespace UnityEngine.TestRunner.NUnitExtensions.Runner
{
    internal abstract class UnityWorkItem
    {
        protected readonly WorkItemFactory m_Factory;
        protected bool m_ExecuteTestStartEvent;
        protected bool m_DontRunRestoringResult;
        protected const int k_DefaultTimeout = 1000 * 180;
        public event EventHandler Completed;

        public bool ResultedInDomainReload { get; internal set; }

        public UnityTestExecutionContext Context { get; private set; }

        public Test Test { get; private set; }

        public TestResult Result { get; protected set; }

        public WorkItemState State { get; private set; }

        public List<ITestAction> Actions { get; private set; }

        protected UnityWorkItem(Test test, WorkItemFactory factory)
        {
            m_Factory = factory;
            Test = test;
            Actions = new List<ITestAction>();
            Result = test.MakeTestResult();
            State = WorkItemState.Ready;
            m_ExecuteTestStartEvent = ShouldExecuteStartEvent();
            m_DontRunRestoringResult = ShouldRestore(test);
        }

        protected static bool ShouldRestore(ITest loadedTest)
        {
            return UnityWorkItemDataHolder.alreadyExecutedTests != null &&
                   UnityWorkItemDataHolder.alreadyExecutedTests.Contains(loadedTest.GetUniqueName());
        }

        protected bool ShouldExecuteStartEvent()
        {
            return UnityWorkItemDataHolder.alreadyStartedTests != null &&
                   UnityWorkItemDataHolder.alreadyStartedTests.All(x => x != Test.GetUniqueName()) &&
                   !ShouldRestore(Test);
        }

        protected abstract IEnumerable PerformWork();

        public void InitializeContext(UnityTestExecutionContext context)
        {
            Context = context;

            if (Test is TestAssembly)
                Actions.AddRange(ActionsHelper.GetActionsFromTestAssembly((TestAssembly)Test));
            else if (Test is ParameterizedMethodSuite)
                Actions.AddRange(ActionsHelper.GetActionsFromTestMethodInfo(Test.Method));
            else if (Test.TypeInfo != null)
                Actions.AddRange(ActionsHelper.GetActionsFromTypesAttributes(Test.TypeInfo.Type));
        }

        public virtual IEnumerable Execute()
        {
            Context.CurrentTest = this.Test;
            Context.CurrentResult = this.Result;

            if (m_ExecuteTestStartEvent)
            {
                Context.Listener.TestStarted(Test);
            }

            Context.StartTime = DateTime.UtcNow;
            Context.StartTicks = Stopwatch.GetTimestamp();

            State = WorkItemState.Running;

            return PerformWork();
        }

        protected void WorkItemComplete()
        {
            State = WorkItemState.Complete;

            Result.StartTime = Context.StartTime;
            Result.EndTime = DateTime.UtcNow;

            long tickCount = Stopwatch.GetTimestamp() - Context.StartTicks;
            double seconds = (double)tickCount / Stopwatch.Frequency;
            Result.Duration = seconds;

            //Result.AssertCount += Context.AssertCount;

            Context.Listener.TestFinished(Result);

            if (Completed != null)
                Completed(this, EventArgs.Empty);

            Context.TestObject = null;
            Test.Fixture = null;
        }

        public virtual void Cancel(bool force)
        {
            Result.SetResult(ResultState.Cancelled, "Cancelled by user");
            Context.Listener.TestFinished(Result);
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
