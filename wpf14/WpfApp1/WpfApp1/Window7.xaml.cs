using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для Window7.xaml
    /// </summary>
    public partial class Window7 : Window
    {
        PersonModel Tom;
        public Window7()
        {
            InitializeComponent();
            Tom = new PersonModel();
            this.DataContext = Tom;
        }
        public interface IDataErrorInfo
        {
            string Error { get; }
            string this[string columnName] { get; }
        }
        public class PersonModel : IDataErrorInfo
        {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Position { get; set; }
            public string this[string columnName]
            {
                get
                {
                    string error = String.Empty;
                    switch (columnName)
                    {
                        case "Age":
                            if ((Age < 0) || (Age > 100))
                            {
                                error = "Возраст должен быть больше 0 и меньше 100";
                            }
                            break;
                        case "Name":
                            //Обработка ошибок для свойства Name
                            break;
                        case "Position":
                            //Обработка ошибок для свойства Position
                            break;
                    }
                    return error;
                }
            }
            public string Error
            {
                get { throw new NotImplementedException(); }
            }
        }
    }
}
