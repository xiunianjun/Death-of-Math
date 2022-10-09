<<<<<<< HEAD
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal interface IAssemblyWrapper
    {
        Assembly Assembly { get; }
        AssemblyName Name { get; }
        string Location { get; }
        AssemblyName[] GetReferencedAssemblies();
    }
}
=======
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal interface IAssemblyWrapper
    {
        Assembly Assembly { get; }
        AssemblyName Name { get; }
        string Location { get; }
        AssemblyName[] GetReferencedAssemblies();
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
