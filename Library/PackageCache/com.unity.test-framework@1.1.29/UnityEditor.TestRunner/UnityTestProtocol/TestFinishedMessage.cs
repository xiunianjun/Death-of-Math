<<<<<<< HEAD
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestFinishedMessage : Message
    {
        public string name;
        public TestState state;
        public string message;
        public ulong duration; // milliseconds
        public ulong durationMicroseconds;
        public string stackTrace;

        public TestFinishedMessage()
        {
            type = "TestStatus";
            phase = "End";
        }
    }
}
=======
namespace UnityEditor.TestTools.TestRunner.UnityTestProtocol
{
    internal class TestFinishedMessage : Message
    {
        public string name;
        public TestState state;
        public string message;
        public ulong duration; // milliseconds
        public ulong durationMicroseconds;
        public string stackTrace;

        public TestFinishedMessage()
        {
            type = "TestStatus";
            phase = "End";
        }
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
