namespace Logging.PathFinders
{
    public class ConsoleByFridaysPathFinder : PathFinder
    {
        private ConsolePathFinder _consolePathFinder;

        public ConsoleByFridaysPathFinder(ILogger logger) : base(logger)
        {
            _consolePathFinder = new ConsolePathFinder(logger);
        }

        public override void Find()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                _consolePathFinder.Find();
            }
        }
    }
}
