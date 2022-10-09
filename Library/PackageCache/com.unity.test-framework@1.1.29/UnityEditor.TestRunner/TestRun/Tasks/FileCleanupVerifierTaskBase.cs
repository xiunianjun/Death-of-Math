<<<<<<< HEAD
using System;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class FileCleanupVerifierTaskBase : TestTaskBase
    {
        internal Func<string[]> GetAllAssetPathsAction = AssetDatabase.GetAllAssetPaths;
        
        protected string[] GetAllFilesInAssetsDirectory()
        {
            return GetAllAssetPathsAction();
        }
    }
=======
using System;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal abstract class FileCleanupVerifierTaskBase : TestTaskBase
    {
        internal Func<string[]> GetAllAssetPathsAction = AssetDatabase.GetAllAssetPaths;
        
        protected string[] GetAllFilesInAssetsDirectory()
        {
            return GetAllAssetPathsAction();
        }
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}