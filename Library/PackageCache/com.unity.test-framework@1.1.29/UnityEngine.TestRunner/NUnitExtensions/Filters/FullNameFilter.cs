<<<<<<< HEAD
﻿using System;
using System.Text.RegularExpressions;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.NUnitExtensions.Filters
{
    internal class FullNameFilter : NUnit.Framework.Internal.Filters.FullNameFilter
    {
        public FullNameFilter(string expectedValue) : base(expectedValue)
        {
        }

        public override bool Match(ITest test)
        {
            return Match(test.GetFullNameWithoutDllPath());
        }

        protected override string ElementName => "test";

    }
}
=======
﻿using System;
using System.Text.RegularExpressions;
using NUnit.Framework.Interfaces;

namespace UnityEngine.TestRunner.NUnitExtensions.Filters
{
    internal class FullNameFilter : NUnit.Framework.Internal.Filters.FullNameFilter
    {
        public FullNameFilter(string expectedValue) : base(expectedValue)
        {
        }

        public override bool Match(ITest test)
        {
            return Match(test.GetFullNameWithoutDllPath());
        }

        protected override string ElementName => "test";

    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
