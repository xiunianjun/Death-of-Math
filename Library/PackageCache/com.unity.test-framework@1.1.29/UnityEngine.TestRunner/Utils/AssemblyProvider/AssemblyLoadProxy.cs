<<<<<<< HEAD
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyLoadProxy : IAssemblyLoadProxy
    {
        public IAssemblyWrapper Load(string assemblyString)
        {
            return new AssemblyWrapper(Assembly.Load(assemblyString));
        }
    }
}
=======
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyLoadProxy : IAssemblyLoadProxy
    {
        public IAssemblyWrapper Load(string assemblyString)
        {
            return new AssemblyWrapper(Assembly.Load(assemblyString));
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
