<<<<<<< HEAD
using System;
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyWrapper : IAssemblyWrapper
    {
        public AssemblyWrapper(Assembly assembly)
        {
            Assembly = assembly;
            Name = assembly.GetName();
        }

        public Assembly Assembly { get; }

        public AssemblyName Name { get; }

        public virtual string Location
        {
            get
            {
                //Some platforms dont support this
                throw new NotImplementedException();
            }
        }

        public virtual AssemblyName[] GetReferencedAssemblies()
        {
            //Some platforms dont support this
            throw new NotImplementedException();
        }
    }
}
=======
using System;
using System.Reflection;

namespace UnityEngine.TestTools.Utils
{
    internal class AssemblyWrapper : IAssemblyWrapper
    {
        public AssemblyWrapper(Assembly assembly)
        {
            Assembly = assembly;
            Name = assembly.GetName();
        }

        public Assembly Assembly { get; }

        public AssemblyName Name { get; }

        public virtual string Location
        {
            get
            {
                //Some platforms dont support this
                throw new NotImplementedException();
            }
        }

        public virtual AssemblyName[] GetReferencedAssemblies()
        {
            //Some platforms dont support this
            throw new NotImplementedException();
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
