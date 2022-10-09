<<<<<<< HEAD
namespace UnityEngine.TestTools.Logging
{
    internal class LogEvent
    {
        public string Message { get; set; }

        public string StackTrace { get; set; }

        public LogType LogType { get; set; }

        public bool IsHandled { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1}", LogType, Message);
        }
    }
}
=======
namespace UnityEngine.TestTools.Logging
{
    internal class LogEvent
    {
        public string Message { get; set; }

        public string StackTrace { get; set; }

        public LogType LogType { get; set; }

        public bool IsHandled { get; set; }

        public override string ToString()
        {
            return string.Format("[{0}] {1}", LogType, Message);
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
