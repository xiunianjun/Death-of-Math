<<<<<<< HEAD
using System;

namespace UnityEngine.TestTools
{
    /// <summary>
    /// A flag indicating the targeted test platforms.
    /// </summary>
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        /// <summary>
        /// Both platforms.
        /// </summary>
        All = 0xFF,
        /// <summary>
        /// The EditMode test platform.
        /// </summary>
        EditMode = 1 << 1,
        /// <summary>
        /// The PlayMode test platform.
        /// </summary>
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
=======
using System;

namespace UnityEngine.TestTools
{
    /// <summary>
    /// A flag indicating the targeted test platforms.
    /// </summary>
    [Flags]
    [Serializable]
    public enum TestPlatform : byte
    {
        /// <summary>
        /// Both platforms.
        /// </summary>
        All = 0xFF,
        /// <summary>
        /// The EditMode test platform.
        /// </summary>
        EditMode = 1 << 1,
        /// <summary>
        /// The PlayMode test platform.
        /// </summary>
        PlayMode = 1 << 2
    }

    internal static class TestPlatformEnumExtensions
    {
        public static bool IsFlagIncluded(this TestPlatform flags, TestPlatform flag)
        {
            return (flags & flag) == flag;
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
