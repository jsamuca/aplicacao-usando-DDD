using Aurora.Application;

namespace Aurora.IntegrationTests.Drivers
{
    public static class ServerSetup
    {
        public static TestServer Setup()
        {
            var webHost = new WebHostBuilder().UseStartup<Startup>();

            var configurations = new ConfigurationBuilder()
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                .AddEnvironmentVariables()
                .Build();

            webHost.UseConfiguration(configurations);

            return new TestServer(webHost);
        }
    }
}
