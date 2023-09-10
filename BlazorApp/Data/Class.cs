namespace BlazorApp.Data
{
    public class Class : IClass
    {
        public int Number { get; private set; }

        private readonly ILogger<Class> logger;

        public Class(ILogger<Class> logger)
        {

            this.logger = logger;
        }

        public void d(int counterNumber)
        {
            Number = counterNumber;
            logger.LogInformation("tha value of counter changed to : {id}", Number);
        }

    }
}
