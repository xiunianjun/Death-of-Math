<<<<<<< HEAD
using System;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Filters;

namespace UnityEngine.TestRunner.NUnitExtensions.Filters
{
    internal class AssemblyNameFilter : ValueMatchFilter
    {
        public AssemblyNameFilter(string assemblyName) : base(assemblyName) {}

        public override bool Match(ITest test)
        {
            string assemblyName = string.Empty;
            //Assembly fullname is in the format "Assembly-name, meta data ...", so extract the name by looking for the comma
            if (test.TypeInfo != null && test.TypeInfo.Assembly != null && test.TypeInfo.FullName != null)
                assemblyName = test.TypeInfo.Assembly.FullName.Substring(0, test.TypeInfo.Assembly.FullName.IndexOf(',')).TrimEnd(',');
            return ExpectedValue.Equals(assemblyName, StringComparison.OrdinalIgnoreCase);
        }

        protected override string ElementName
        {
            get { return "id"; }
        }
    }
}
=======
using System;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal.Filters;

namespace UnityEngine.TestRunner.NUnitExtensions.Filters
{
    internal class AssemblyNameFilter : ValueMatchFilter
    {
        public AssemblyNameFilter(string assemblyName) : base(assemblyName) {}

        public override bool Match(ITest test)
        {
            string assemblyName = string.Empty;
            //Assembly fullname is in the format "Assembly-name, meta data ...", so extract the name by looking for the comma
            if (test.TypeInfo != null && test.TypeInfo.Assembly != null && test.TypeInfo.FullName != null)
                assemblyName = test.TypeInfo.Assembly.FullName.Substring(0, test.TypeInfo.Assembly.FullName.IndexOf(',')).TrimEnd(',');
            return ExpectedValue.Equals(assemblyName, StringComparison.OrdinalIgnoreCase);
        }

        protected override string ElementName
        {
            get { return "id"; }
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
