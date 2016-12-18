using System;
using log4net;

[assembly: log4net.Config.XmlConfigurator(ConfigFile = "log4Net.config", Watch = true)]
namespace OesLogic
{
    public static class Log4NetHelper
    {
        /// <summary>
        /// Print log to Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="ex"></param>
        #region

        public static void WriteErrorLog(Type type, Exception ex)
        {
            ILog log = LogManager.GetLogger(type);
            log.Error("Error", ex);
        }

        #endregion

        /// <summary>
        /// Print log to Log4Net
        /// </summary>
        /// <param name="t"></param>
        /// <param name="msg"></param>
        #region

        public static void WriteInfoLog(Type type, string msg)
        {
            ILog log = LogManager.GetLogger(type);
            log.Info(msg);
        }

        #endregion
    }
}
