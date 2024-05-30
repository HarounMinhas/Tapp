using Microsoft.Extensions.Configuration;

namespace Tapp.Configuration;

public static class ConfigurationHelper
{
    public static IConfigurationRoot BuildConfigurationAppSettings(string basePath)
    {
        var test = Directory.GetParent(Directory.GetCurrentDirectory())!.FullName + "\\" + basePath;

        return new ConfigurationBuilder()
            .SetBasePath(test)
            .AddJsonFile("appsettings.json", optional: false)
            .Build();
    }
}