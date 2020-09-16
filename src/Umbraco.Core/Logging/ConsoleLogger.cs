﻿using System;

namespace Umbraco.Core.Logging
{
    public class ConsoleLogger<T> : ILogger
    {
        private readonly IMessageTemplates _messageTemplates;

        public ConsoleLogger(IMessageTemplates messageTemplates)
        {
            _messageTemplates = messageTemplates;
        }

        public bool IsEnabled(Type reporting, LogLevel level)
            => true;

        public void Fatal(Type reporting, Exception exception)
        {
            Console.WriteLine("FATAL {0}", reporting.Name);
            Console.WriteLine(exception);
        }

        public void LogCritical(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine("FATAL {0} - {1}", typeof(T).Name, _messageTemplates.Render(messageTemplate, propertyValues));
            Console.WriteLine(exception);
        }

        public void LogCritical(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine("FATAL {0} - {1}", typeof(T).Name, _messageTemplates.Render(messageTemplate, propertyValues));
        }

        public void LogError(Type reporting, Exception exception)
        {
            Console.WriteLine("ERROR {0}", reporting.Name);
            Console.WriteLine(exception);
        }

        public void LogError(Exception exception, string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine("ERROR {0} - {1}", typeof(T).Name, _messageTemplates.Render(messageTemplate, propertyValues));
            Console.WriteLine(exception);
        }

        public void LogError(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine("ERROR {0} - {1}", typeof(T).Name, _messageTemplates.Render(messageTemplate, propertyValues));
        }

        public void LogWarning(string message, params object[] propertyValues)
        {
            Console.WriteLine("WARN {0} - {1}", typeof(T).Name, _messageTemplates.Render(message, propertyValues));
        }

        public void LogWarning(Exception exception, string message, params object[] propertyValues)
        {
            Console.WriteLine("WARN {0} - {1}", typeof(T).Name, _messageTemplates.Render(message, propertyValues));
            Console.WriteLine(exception);
        }

        public void LogInformation(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine("INFO {0} - {1}", typeof(T).Name, _messageTemplates.Render(messageTemplate, propertyValues));
        }

        public void LogDebug(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine("DEBUG {0} - {1}", typeof(T).Name, _messageTemplates.Render(messageTemplate, propertyValues));
        }

        public void LogTrace(string messageTemplate, params object[] propertyValues)
        {
            Console.WriteLine("VERBOSE {0} - {1}", typeof(T).Name, _messageTemplates.Render(messageTemplate, propertyValues));
        }
    }
}