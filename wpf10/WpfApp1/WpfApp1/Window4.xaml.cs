using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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

namespace WPF1
{
    /// <summary>
    /// Логика взаимодействия для Window4.xaml
    /// </summary>
    public partial class Window4 : Window
    {
        public Window4()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Phone phone = (Phone)this.Resources["nexusPhone"];
            phone.Company = "LG"; // Меняем с Google на LG
        }
        class Phone : INotifyPropertyChanged
        {
            private string title;
            private string company;
            private int price;

            public string Title
            {
                get { return title; }
                set
                {
                    title = value;
                    OnPropertyChanged("Title");
                }
            }
            public string Company
            {
                get { return company; }
                set
                {
                    company = value;
                    OnPropertyChanged("Company");
                }
            }
            public int Price
            {
                get { return price; }
                set
                {
                    price = value;
                    OnPropertyChanged("Price");
                }
            }

            public event PropertyChangedEventHandler PropertyChanged;
            public void OnPropertyChanged([CallerMemberName] string prop = "")
            {
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
