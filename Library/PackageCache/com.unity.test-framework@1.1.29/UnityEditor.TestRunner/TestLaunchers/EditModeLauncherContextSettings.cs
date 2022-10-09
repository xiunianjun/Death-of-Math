<<<<<<< HEAD
using System;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModeLauncherContextSettings : IDisposable
    {
        private bool m_RunInBackground;

        public EditModeLauncherContextSettings()
        {
            SetupProjectParameters();
        }

        public void Dispose()
        {
            CleanupProjectParameters();
        }

        private void SetupProjectParameters()
        {
            m_RunInBackground = Application.runInBackground;
            Application.runInBackground = true;
        }

        private void CleanupProjectParameters()
        {
            Application.runInBackground = m_RunInBackground;
        }
    }
}
=======
using System;
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner
{
    internal class EditModeLauncherContextSettings : IDisposable
    {
        private bool m_RunInBackground;

        public EditModeLauncherContextSettings()
        {
            SetupProjectParameters();
        }

        public void Dispose()
        {
            CleanupProjectParameters();
        }

        private void SetupProjectParameters()
        {
            m_RunInBackground = Application.runInBackground;
            Application.runInBackground = true;
        }

        private void CleanupProjectParameters()
        {
            Application.runInBackground = m_RunInBackground;
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
