<<<<<<< HEAD
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework.Api;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IAsyncTestAssemblyBuilder : ITestAssemblyBuilder
    {
        IEnumerator<ITest> BuildAsync(Assembly[] assemblies, TestPlatform[] testPlatforms, IDictionary<string, object> options);
    }
=======
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework.Api;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestTools.NUnitExtensions
{
    internal interface IAsyncTestAssemblyBuilder : ITestAssemblyBuilder
    {
        IEnumerator<ITest> BuildAsync(Assembly[] assemblies, TestPlatform[] testPlatforms, IDictionary<string, object> options);
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}