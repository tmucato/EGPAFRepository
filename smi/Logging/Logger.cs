using log4net;
using System;

namespace smiBLL
{
    public static class Logger
    {
        private static ILog logger = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        public static void LogError(string ErrorMsg, Exception Excep)
        {
            logger.Error(ErrorMsg, Excep);
        }
        public static void LogInfo(string StrInfo)
        {
            logger.Info(StrInfo);
        }
    }
}
