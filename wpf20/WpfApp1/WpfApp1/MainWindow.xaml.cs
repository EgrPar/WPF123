using System.Windows;

namespace WpfApp1
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext =
                new ApplicationViewModel(new DefaultDialogService(), new JsonFileService());
        }
    }
}