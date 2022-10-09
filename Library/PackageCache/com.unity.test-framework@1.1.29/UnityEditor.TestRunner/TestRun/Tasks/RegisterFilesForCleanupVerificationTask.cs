<<<<<<< HEAD
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class RegisterFilesForCleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.existingFiles = GetAllFilesInAssetsDirectory();
            yield return null;
        }
    }
=======
using System.Collections;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class RegisterFilesForCleanupVerificationTask : FileCleanupVerifierTaskBase
    {
        public override IEnumerator Execute(TestJobData testJobData)
        {
            testJobData.existingFiles = GetAllFilesInAssetsDirectory();
            yield return null;
        }
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}