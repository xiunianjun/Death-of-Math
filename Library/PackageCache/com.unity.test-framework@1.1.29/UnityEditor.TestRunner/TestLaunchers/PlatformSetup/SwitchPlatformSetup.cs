<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner
{
    internal class SwitchPlatformSetup : IPlatformSetup
    {
        public void Setup()
        {
            EditorUserBuildSettings.switchCreateRomFile = true;
            EditorUserBuildSettings.switchNVNGraphicsDebugger = false;
#if UNITY_2020_1_OR_NEWER
            EditorUserBuildSettings.switchNVNDrawValidation_Heavy = true; // catches more graphics errors
#else
            EditorUserBuildSettings.switchNVNDrawValidation = true; // catches more graphics errors
#endif
            EditorUserBuildSettings.development = true;
            EditorUserBuildSettings.switchRedirectWritesToHostMount = true;

            // We can use these when more debugging is required:
            //EditorUserBuildSettings.switchNVNDrawValidation = false; // cannot be used with shader debug
            //EditorUserBuildSettings.switchNVNGraphicsDebugger = true;
            //EditorUserBuildSettings.switchNVNShaderDebugging = true;
            //EditorUserBuildSettings.switchCreateSolutionFile = true; // for shorter iteration time
            //EditorUserBuildSettings.allowDebugging = true; // managed debugger can be attached
        }

        public void PostBuildAction()
        {
        }

        public void PostSuccessfulBuildAction()
        {
        }

        public void PostSuccessfulLaunchAction()
        {
        }

        public void CleanUp()
        {
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner
{
    internal class SwitchPlatformSetup : IPlatformSetup
    {
        public void Setup()
        {
            EditorUserBuildSettings.switchCreateRomFile = true;
            EditorUserBuildSettings.switchNVNGraphicsDebugger = false;
#if UNITY_2020_1_OR_NEWER
            EditorUserBuildSettings.switchNVNDrawValidation_Heavy = true; // catches more graphics errors
#else
            EditorUserBuildSettings.switchNVNDrawValidation = true; // catches more graphics errors
#endif
            EditorUserBuildSettings.development = true;
            EditorUserBuildSettings.switchRedirectWritesToHostMount = true;

            // We can use these when more debugging is required:
            //EditorUserBuildSettings.switchNVNDrawValidation = false; // cannot be used with shader debug
            //EditorUserBuildSettings.switchNVNGraphicsDebugger = true;
            //EditorUserBuildSettings.switchNVNShaderDebugging = true;
            //EditorUserBuildSettings.switchCreateSolutionFile = true; // for shorter iteration time
            //EditorUserBuildSettings.allowDebugging = true; // managed debugger can be attached
        }

        public void PostBuildAction()
        {
        }

        public void PostSuccessfulBuildAction()
        {
        }

        public void PostSuccessfulLaunchAction()
        {
        }

        public void CleanUp()
        {
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
