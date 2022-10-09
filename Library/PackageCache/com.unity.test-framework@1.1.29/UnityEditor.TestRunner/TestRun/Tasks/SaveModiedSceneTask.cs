<<<<<<< HEAD
using System;
using System.Collections;
using UnityEditor.SceneManagement;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveModiedSceneTask : TestTaskBase
    {
        internal Func<bool> SaveCurrentModifiedScenesIfUserWantsTo =
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var cancelled = !SaveCurrentModifiedScenesIfUserWantsTo();
            if (cancelled)
            {
                throw new TestRunCanceledException();
            }

            yield break;
        }
    }
=======
using System;
using System.Collections;
using UnityEditor.SceneManagement;

namespace UnityEditor.TestTools.TestRunner.TestRun.Tasks
{
    internal class SaveModiedSceneTask : TestTaskBase
    {
        internal Func<bool> SaveCurrentModifiedScenesIfUserWantsTo =
            EditorSceneManager.SaveCurrentModifiedScenesIfUserWantsTo;
        public override IEnumerator Execute(TestJobData testJobData)
        {
            var cancelled = !SaveCurrentModifiedScenesIfUserWantsTo();
            if (cancelled)
            {
                throw new TestRunCanceledException();
            }

            yield break;
        }
    }
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
}