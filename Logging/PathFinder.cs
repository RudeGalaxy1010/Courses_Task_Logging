namespace Logging
{
    public abstract class PathFinder
    {
        protected ILogger _logger;

        public PathFinder(ILogger logger)
        {
            _logger = logger;
        }

        public abstract void Find();
    }
}
