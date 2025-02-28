using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using WpfApp1;
/// <summary>
/// Логика взаимодействия для App.xaml
/// </summary>
public partial class App : Application
{
    [STAThread]
    static void Main()
    {
        App app = new App();
        MainWindow window = new MainWindow();
        window.Title = "Hello METANIT.COM";
        app.Run(window);
    }
    //Запуск одной копии приложения
    System.Threading.Mutex mutex;
    private void App_Startup(object sender, StartupEventArgs e)
    {
        bool createdNew;
        string mutName = "Приложение";
        mutex = new System.Threading.Mutex(true, mutName, out createdNew);
        if (!createdNew)
        {
            this.Shutdown();
        }
    }
    private void Button1_Click(object sender, RoutedEventArgs e)
    {
        foreach (Window window in Application.Current.Windows)
        {
            MessageBox.Show(window.ToString());
        }
    }
}