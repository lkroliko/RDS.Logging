using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Logging;

namespace RDS.Logging
{
    public class Logger : ILogger
    {
        Microsoft.Extensions.Logging.ILogger _logger;

        internal Logger(Microsoft.Extensions.Logging.ILogger logger)
        {
            _logger = logger;
        }

        public void Information(string message)
        {
            _logger.LogInformation(message);
        }

        public void Information(string message, params object[] args)
        {
            _logger.LogInformation(message, args);
        }

        public void Debug(string message)
        {
            _logger.LogDebug(message);
        }

        public void Debug(string message, params object[] args)
        {
            _logger.LogDebug(message, args);
        }

        public void Warning(string message)
        {
            _logger.LogWarning(message);
        }

        public void Warning(string message, params object[] args)
        {
            _logger.LogWarning(message, args);
        }

        public void Warning(Exception exception, string message)
        {
            _logger.LogWarning(exception, message);
        }

        public void Warning(Exception exception, string message, params object[] args)
        {
            _logger.LogWarning(exception, message, args);
        }

        public void Error(string message)
        {
            _logger.LogError(message);
        }

        public void Error(string message, params object[] args)
        {
            _logger.LogError(message, args);
        }

        public void Error(Exception exception, string message)
        {
            _logger.LogError(exception, message);
        }

        public void Error(Exception exception, string message, params object[] args)
        {
            _logger.LogError(exception, message, args);
        }
    }
}
