using System.Text;
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
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Phone MyPhone { get; set; }
        public MainWindow()
        {
            InitializeComponent();

            MyPhone = new Phone
            {
                Name = "Lumia 630",
                Company = new Company { Title = "Microsoft" },
                Price = 1000
            };
            this.DataContext = MyPhone;
        }
        public class Phone
        {
            public string Name { get; set; }
            public Company Company { get; set; }
            public decimal Price { get; set; }
        }

        public class Company
        {
            public string Title { get; set; }
        }

    }
}