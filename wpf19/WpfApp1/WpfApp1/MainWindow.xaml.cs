using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = "log.txt";
        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
            this.Closing += MainWindow_Closing;
            this.Closed += MainWindow_Closed;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            Log("Loaded");
        }

        private void MainWindow_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Log("Closing");
        }

        private void MainWindow_Closed(object sender, EventArgs e)
        {
            Log("Closed");
        }

        private void Log(string eventName)
        {
            using (StreamWriter logger = new StreamWriter(path, true))
            {
                logger.WriteLine(DateTime.Now.ToLongTimeString() + " - " + eventName);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window1 window1 = new Window1();
            window1.ViewModel = "ViewModel";

            window1.Owner = this;
            window1.Show();
            window1.ShowViewModel();

            foreach (Window window in this.OwnedWindows)
            {
                window.Background = new SolidColorBrush(Colors.Red);

                if (window is Window1)
                    window.Title = "Новый заголовок!";
            }
        }

        private void Login_Click(object sender, RoutedEventArgs e)
        {
            Window2 window2 = new Window2();

            if (window2.ShowDialog() == true)
            {
                if (window2.Password == "1234")
                    MessageBox.Show("Авторизация пройдена");
                else
                    MessageBox.Show("Неверный пароль");
            }
            else
            {
                MessageBox.Show("Авторизация не пройдена");
            }
        }
    }
}
