﻿using System;
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
    /// Логика взаимодействия для Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        public ObservableCollection<Phone> Phones { get; set; }
        public Window2()
        {
            InitializeComponent();

            Phones = new ObservableCollection<Phone>
        {
            new Phone {Id=1, ImagePath="/Images/iphone6s.jpg", Title="iPhone 6S", Company="Apple" },
            new Phone {Id=2, ImagePath="/Images/lumia950.jpg", Title="Lumia 950", Company="Microsoft" },
            new Phone {Id=3, ImagePath="/Images/nexus5x.jpg", Title="Nexus 5X", Company="Google" },
            new Phone {Id=4, ImagePath="/Images/galaxys6.jpg", Title="Galaxy S6", Company="Samsung"}
        };
            phonesList.ItemsSource = Phones;
        }
        public class Phone
        {
            public int Id { get; set; }
            public string Title { get; set; } // модель телефона
            public string Company { get; set; } // производитель
            public string ImagePath { get; set; } // путь к изображению
        }
        private void phonesList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Phone p = (Phone)phonesList.SelectedItem;
            MessageBox.Show(p.Title);
        }
    }
}
