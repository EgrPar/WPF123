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
using System.Windows.Annotations;
using System.Windows.Annotations.Storage;
using System.IO;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window9.xaml
    /// </summary>
    public partial class Window9 : Window
    {
        FileStream fs;
        AnnotationService anService;
        public Window9()
        {
            InitializeComponent();
            this.Loaded += Window_Loaded;
            this.Unloaded += Window_Unloaded;
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //инициализация службы аннотаций
            anService = new AnnotationService(docViewer);
            // создание связанного потока
            fs = new FileStream("storage.xml", FileMode.OpenOrCreate);
            // привязка потока к хранилищу аннотаций
            AnnotationStore store = new XmlStreamStore(fs);
            store.AutoFlush = true;
            // включение службы
            anService.Enable(store);
        }

        private void Window_Unloaded(object sender, RoutedEventArgs e)
        {
            if (anService != null && anService.IsEnabled)
            {
                anService.Store.Flush();
                anService.Disable();
                fs.Close();
            }
        }
    }
}
