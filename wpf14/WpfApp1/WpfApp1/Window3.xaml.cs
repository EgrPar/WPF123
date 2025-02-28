using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window3.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        public Window3()
        {
            InitializeComponent();
        }
    }

    public class PhoneRepository
    {
        private ObservableCollection<Phone> phones;

        public PhoneRepository()
        {
            phones = new ObservableCollection<Phone>
        {
            new Phone {Id=1, Title="iPhone 6S", Company="Apple" },
            new Phone {Id=2, Title="Lumia 950", Company="Microsoft" },
            new Phone {Id=3, Title="Nexus 5X", Company="Google" },
            new Phone {Id=4, Title="Galaxy S6", Company="Samsung"}
        };
        }
        public ObservableCollection<Phone> GetPhones()
        {
            return phones;
        }
    }

    public class Phone
    {
        public int Id { get; set; }
        public string Title { get; set; } // модель телефона
        public string Company { get; set; } // производитель
    }
}
