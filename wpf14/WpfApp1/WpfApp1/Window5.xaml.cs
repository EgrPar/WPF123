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
    /// Логика взаимодействия для Window5.xaml
    /// </summary>
    public partial class Window5 : Window
    {
        public class Company
        {
            public string Name { get; set; }
            public ObservableCollection<Smartphone> Phones { get; set; }
            public Company()
            {
                Phones = new ObservableCollection<Smartphone>();
            }
        }
        public class Smartphone
        {
            public string Title { get; set; }
        }
        public Window5()
        {
            InitializeComponent();

            ObservableCollection<Company> companies = new ObservableCollection<Company>()
            {
                new Company
                {
                    Name = "Samsung",
                    Phones = new ObservableCollection<Smartphone>
                    {
                        new Smartphone { Title = "Galaxy Note 7" },
                        new Smartphone { Title = "Galaxy S 7" }
                    }
                },
                new Company
                {
                    Name = "Apple",
                    Phones = new ObservableCollection<Smartphone>
                    {
                        new Smartphone { Title = "iPhone 7" },
                        new Smartphone { Title = "iPhone 6S" }
                    }
                },
                new Company
                {
                    Name = "Xiaomi",
                    Phones = new ObservableCollection<Smartphone>
                    {
                        new Smartphone { Title = "Redmi Note 2" },
                        new Smartphone { Title = "Mi5" }
                    }
                }
            };
            mainMenu.ItemsSource = companies;
        }
    }
}
