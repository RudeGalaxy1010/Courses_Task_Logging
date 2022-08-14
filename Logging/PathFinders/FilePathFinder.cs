namespace Logging.PathFinders
{
    public class FilePathFinder : PathFinder
    {
        private string _filePath;

        public FilePathFinder(string filePath, ILogger logger) : base(logger)
        {
            _filePath = filePath;
        }

        public override void Find()
        {
            File.WriteAllText(_filePath, _logger.GetLog());
        }
    }
}
