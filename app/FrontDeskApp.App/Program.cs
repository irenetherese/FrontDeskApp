using FrontDeskApp.App.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using FrontDeskApp.App.Services;

namespace FrontDeskApp.App;

static class Program
{
    [STAThread]
    static void Main()
    {
        Application.SetHighDpiMode(HighDpiMode.SystemAware);
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        var host = CreateHostBuilder().Build();
        ServiceProvider = host.Services;

        Application.Run(ServiceProvider.GetRequiredService<FrontDeskApp>());
    }
    public static IServiceProvider ServiceProvider { get; private set; }
    static IHostBuilder CreateHostBuilder()
    {
        return Host.CreateDefaultBuilder()
            .ConfigureServices((context, services)=>{
                FrontDeskAppApiSettings settings = context.Configuration.GetSection("FrontDeskAppApiSettings").Get<FrontDeskAppApiSettings>();
        	    services.AddSingleton<FrontDeskAppApiSettings>(settings);
                services.AddScoped<IFrontDeskApiClient, FrontDeskApiClient>();
                services.AddScoped<FrontDeskApp>();
            });
    }
}