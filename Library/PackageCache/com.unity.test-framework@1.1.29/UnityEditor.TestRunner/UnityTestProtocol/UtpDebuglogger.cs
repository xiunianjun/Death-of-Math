<<<<<<< HEAD
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    class UtpDebugLogger : IUtpLogger
    {
        public void Log(Message msg)
        {
            var msgJson = JsonUtility.ToJson(msg);
            Debug.LogFormat(LogType.Log, LogOption.NoStacktrace, null, "\n##utp:{0}", msgJson);
        }
    }
}
=======
using UnityEngine;

namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    class UtpDebugLogger : IUtpLogger
    {
        public void Log(Message msg)
        {
            var msgJson = JsonUtility.ToJson(msg);
            Debug.LogFormat(LogType.Log, LogOption.NoStacktrace, null, "\n##utp:{0}", msgJson);
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
