using System;
using Ninject.Extensions.Logging;

namespace Illallangi
{
    public sealed class NullLogger : LoggerBase
    {
        public NullLogger(Type type)
            : base(type)
        {
        }

        public NullLogger(string name)
            : base(name)
        {
        }

        public override void Debug(string message)
        {
            //noop
        }

        public override void Debug(string format, params object[] args)
        {
            //noop
        }

        public override void Debug(Exception exception, string format, params object[] args)
        {
            //noop
        }

        public override void DebugException(string message, Exception exception)
        {
            //noop
        }

        public override void Info(string message)
        {
            //noop
        }

        public override void Info(string format, params object[] args)
        {
            //noop
        }

        public override void Info(Exception exception, string format, params object[] args)
        {
            //noop
        }

        public override void InfoException(string message, Exception exception)
        {
            //noop
        }

        public override void Trace(string message)
        {
            //noop
        }

        public override void Trace(string format, params object[] args)
        {
            //noop
        }

        public override void Trace(Exception exception, string format, params object[] args)
        {
            //noop
        }

        public override void TraceException(string message, Exception exception)
        {
            //noop
        }

        public override void Warn(string message)
        {
            //noop
        }

        public override void Warn(string format, params object[] args)
        {
            //noop
        }

        public override void Warn(Exception exception, string format, params object[] args)
        {
            //noop
        }

        public override void WarnException(string message, Exception exception)
        {
            //noop
        }

        public override void Error(string message)
        {
            //noop
        }

        public override void Error(string format, params object[] args)
        {
            //noop
        }

        public override void Error(Exception exception, string format, params object[] args)
        {
            //noop
        }

        public override void ErrorException(string message, Exception exception)
        {
            //noop
        }

        public override void Fatal(string message)
        {
            //noop
        }

        public override void Fatal(string format, params object[] args)
        {
            //noop
        }

        public override void Fatal(Exception exception, string format, params object[] args)
        {
            //noop
        }

        public override void FatalException(string message, Exception exception)
        {
            //noop
        }

        public override bool IsDebugEnabled
        {
            get { return true; }
        }

        public override bool IsInfoEnabled
        {
            get { return true; }
        }

        public override bool IsTraceEnabled
        {
            get { return true; }
        }

        public override bool IsWarnEnabled
        {
            get { return true; }
        }

        public override bool IsErrorEnabled
        {
            get { return true; }
        }

        public override bool IsFatalEnabled
        {
            get { return true; }
        }
    }
}