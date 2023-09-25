using NLog;
using System;
using System.Collections.Generic;
using System.Text;

namespace UsingNLog
{
    internal class NLog
    {
        public static readonly Logger logger = LogManager.GetCurrentClassLogger();

        public void LogInfo(string msg)
        {
            logger.Info(msg);
        }

        public void LogError(string msg)
        {
            logger.Error(msg);
        }
    }
}
