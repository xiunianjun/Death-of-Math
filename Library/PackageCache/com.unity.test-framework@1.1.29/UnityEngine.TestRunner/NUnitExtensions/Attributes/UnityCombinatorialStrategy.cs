<<<<<<< HEAD
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Builders;

namespace UnityEngine.TestTools
{
    internal class UnityCombinatorialStrategy : CombinatorialStrategy, ICombiningStrategy
    {
        public new IEnumerable<ITestCaseData> GetTestCases(IEnumerable[] sources)
        {
            var testCases = base.GetTestCases(sources);
            foreach (var testCase in testCases)
            {
                testCase.GetType().GetProperty("ExpectedResult").SetValue(testCase, new object(), null);
            }
            return testCases;
        }
    }
}
=======
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Builders;

namespace UnityEngine.TestTools
{
    internal class UnityCombinatorialStrategy : CombinatorialStrategy, ICombiningStrategy
    {
        public new IEnumerable<ITestCaseData> GetTestCases(IEnumerable[] sources)
        {
            var testCases = base.GetTestCases(sources);
            foreach (var testCase in testCases)
            {
                testCase.GetType().GetProperty("ExpectedResult").SetValue(testCase, new object(), null);
            }
            return testCases;
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
