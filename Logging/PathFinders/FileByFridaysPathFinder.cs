namespace Logging.PathFinders
{
    public class FileByFridaysPathFinder : PathFinder
    {
        private FilePathFinder _filePathFinder;

        public FileByFridaysPathFinder(string filePath, ILogger logger) : base(logger)
        {
            _filePathFinder = new FilePathFinder(filePath, logger);
        }

        public override void Find()
        {
            if (DateTime.Now.DayOfWeek == DayOfWeek.Friday)
            {
                _filePathFinder.Find();
            }
        }
    }
}
