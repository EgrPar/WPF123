using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Windows;

namespace WpfApp1
{
    public class Program
    {
        [STAThread]
        public static void Main()
        {
            var host = Host.CreateDefaultBuilder()
                .ConfigureServices(services =>
                {
                    services.AddSingleton<App>();
                    services.AddSingleton<MainWindow>();
                    // добавляем сервис IDateService
                    services.AddTransient<IDateService, RuDateService>();
                })
                .Build();
            var app = host.Services.GetService<App>();
            app?.Run();
        }
    }
    public interface IDateService
    {
        string FormatedDate { get; }
    }
    public class RuDateService : IDateService
    {
        public string FormatedDate => $"Сегодня: {DateTime.Now.ToString("dd.MM.yyyy")}";
    }
    public class EnDateService : IDateService
    {
        public string FormatedDate => $"Today: {DateTime.Now.ToString("MM.dd.yyyy")}";
    }
}
