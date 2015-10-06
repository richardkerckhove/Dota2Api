using NLog;


namespace Dota2.Utilities
{
    public static class Dota2Logger 
    {
        private static Logger _logger = LogManager.GetCurrentClassLogger();

        public static void LogError(string message)
        {
            _logger.Error(message);
        }

        public static void LogInfo(string message)
        {
            _logger.Info(message);
        }

        public static void LogDebug(string message)
        {
            _logger.Debug(message);
        }
    }
}
