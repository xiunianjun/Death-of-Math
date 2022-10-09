<<<<<<< HEAD
using System;
using System.Collections.Generic;

namespace UnityEngine.TestTools.Logging
{
    internal interface ILogScope : IDisposable
    {
        Queue<LogMatch> ExpectedLogs { get; set; }
        List<LogEvent> AllLogs { get; }
        List<LogEvent> FailingLogs { get; }
        bool IgnoreFailingMessages { get; set; }
        bool IsNUnitException { get; }
        bool IsNUnitSuccessException { get; }
        bool IsNUnitInconclusiveException { get; }
        bool IsNUnitIgnoreException { get; }
        string NUnitExceptionMessage { get; }
        void AddLog(string message, string stacktrace, LogType type);
        bool AnyFailingLogs();
        void ProcessExpectedLogs();
        void NoUnexpectedReceived();
    }
}
=======
using System;
using System.Collections.Generic;

namespace UnityEngine.TestTools.Logging
{
    internal interface ILogScope : IDisposable
    {
        Queue<LogMatch> ExpectedLogs { get; set; }
        List<LogEvent> AllLogs { get; }
        List<LogEvent> FailingLogs { get; }
        bool IgnoreFailingMessages { get; set; }
        bool IsNUnitException { get; }
        bool IsNUnitSuccessException { get; }
        bool IsNUnitInconclusiveException { get; }
        bool IsNUnitIgnoreException { get; }
        string NUnitExceptionMessage { get; }
        void AddLog(string message, string stacktrace, LogType type);
        bool AnyFailingLogs();
        void ProcessExpectedLogs();
        void NoUnexpectedReceived();
    }
}
>>>>>>> dc1880a71e6662c12d241e6bea8d41fbdc1ff7f4
