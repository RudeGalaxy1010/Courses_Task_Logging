namespace Logging.PathFinders
{
    public class ConsolePathFinder : PathFinder
    {
        public ConsolePathFinder(ILogger logger) : base(logger) { }

        public override void Find()
        {
            Console.WriteLine(_logger.GetLog());
        }
    }
}
