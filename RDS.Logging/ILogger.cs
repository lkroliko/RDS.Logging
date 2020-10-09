using System;
using System.Collections.Generic;
using System.Text;

namespace RDS.Logging
{
    public interface ILogger
    {
        void Information(string message);
        void Information(string message, params object[] args);
        void Debug(string message);
        void Debug(string message, params object[] args);
        void Warning(string message);
        void Warning(string message, params object[] args);
        void Warning(Exception exception, string message);
        void Warning(Exception exception, string message, params object[] args);
        void Error(string message);
        void Error(string message, params object[] args);
        void Error(Exception exception, string message);
        void Error(Exception exception, string message, params object[] args);
        void Trace(string message);
        void Trace(string message, params object[] args);
        void Trace(Exception exception, string message);
        void Trace(Exception exception, string message, params object[] args);
    }
}
