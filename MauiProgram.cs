using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Syncfusion.Licensing;
using Syncfusion.Maui.Core.Hosting;
using System.Reflection;

namespace MAUI_EasyBMI
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureSyncfusionCore()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.AddAppSettings();
            string? syncKey = builder.Configuration.GetValue<string>("SyncfusionLicenseKey");
            if (!string.IsNullOrEmpty(syncKey))
            {
                SyncfusionLicenseProvider.RegisterLicense(syncKey);
            }
#if DEBUG
                builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
        private static void AddAppSettings(this MauiAppBuilder builder)
        {
            using Stream? stream = Assembly.
                GetExecutingAssembly()
                .GetManifestResourceStream("MAUI_EasyBMI.appsettings.json");

            if (stream != null)
            {
                IConfigurationRoot config = new ConfigurationBuilder()
                    .AddJsonStream(stream)
                    .Build();
                builder.Configuration.AddConfiguration(config);
            }
        }
    }
}
