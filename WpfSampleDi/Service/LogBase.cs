using System;
using System.IO;

namespace WpfSampleDi.Service
{
    /// <summary>
    /// Log base constructor />
    /// </summary>
    public class LogBase : ILogBase
    {
        /// <summary>
        /// Get Log File Information
        /// </summary>
        private readonly FileInfo _logFileInfo;

        public LogBase(FileInfo logLogFile)
        {
            _logFileInfo = logLogFile;
        }

        /// <summary>
        /// Information events describe things happening in the system that correspond to its responsibilities and functions. Generally these are the observable actions the system can perform.
        /// </summary>
        /// <param name="message"></param>
        public string Info(string message)
        {
            return $"This is just example does not save log to: {_logFileInfo} with Info: {message}";
        }

        /// <summary>
        /// Debug is used for internal system events that are not necessarily observable from the outside, but useful when determining how something happened.
        /// </summary>
        /// <param name="message"></param>
        public string Debug(string message)
        {
            return $"This is just example does not save log to: {_logFileInfo} with Debug: {message}";
        }

        /// <summary>
        /// When functionality is unavailable or expectations broken, an Error event is used.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="exception"></param>
        public string Error(Exception exception, string message)
        {
            return $"This is just example does not save log to: {_logFileInfo} with Error: {message}, Exception: {exception.Message}";
        }

    }

    public interface ILogBase
    {
        string Info(string message);
        string Debug(string message);
        string Error(Exception exception, string message);
    }
}
