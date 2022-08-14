namespace Logging
{
    public class MockLogger : ILogger
    {
        private const string TestString = "This is a test string. Please, don't pay your attention";

        public string GetLog()
        {
            return TestString;
        }
    }
}
