using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Text;

namespace RDS.Logging
{
    public class LoggerBuilder
    {
        Microsoft.Extensions.Logging.ILogger _logger = Microsoft.Extensions.Logging.Abstractions.NullLogger.Instance;

        public LoggerBuilder AddSerilogLogger(Serilog.ILogger logger)
        {
            LoggerFactory loggerFactory = new LoggerFactory();
            loggerFactory.AddSerilog(logger);
            _logger = loggerFactory.CreateLogger("Logger");
            return this;
        }

        public LoggerBuilder AddMicrosoftLogger(Microsoft.Extensions.Logging.ILogger logger)
        {
            _logger = logger;
            return this;
        }

        public Logger Build()
        {
            return new Logger(_logger);
        }

        public static LoggerBuilder New { get { return new LoggerBuilder(); } }

        public static implicit operator Logger(LoggerBuilder builder)
        {
            return builder.Build();
        }
    }
}
