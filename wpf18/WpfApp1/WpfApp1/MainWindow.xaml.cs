using System;
using System.Windows;
using System.Windows.Controls;

using System.Windows.Media.Animation;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // анимация для ширины
            DoubleAnimation widthAnimation = new DoubleAnimation();
            widthAnimation.From = helloButton.ActualWidth;
            widthAnimation.To = 150;
            widthAnimation.Duration = TimeSpan.FromSeconds(5);

            // анимация для высоты
            DoubleAnimation heightAnimation = new DoubleAnimation();
            heightAnimation.From = helloButton.ActualHeight;
            heightAnimation.To = 60;
            heightAnimation.Duration = TimeSpan.FromSeconds(5);

            helloButton.BeginAnimation(Button.WidthProperty, widthAnimation);
            helloButton.BeginAnimation(Button.HeightProperty, heightAnimation);

            //Повторение анимации
            DoubleAnimation buttonAnimation = new DoubleAnimation();
            buttonAnimation.From = helloButton.ActualWidth;
            buttonAnimation.To = 150;
            buttonAnimation.Duration = TimeSpan.FromSeconds(3);
            buttonAnimation.AutoReverse = true;
            buttonAnimation.RepeatBehavior = new RepeatBehavior(6);
            buttonAnimation.Completed += ButtonAnimation_Completed;
            helloButton.BeginAnimation(Button.WidthProperty, buttonAnimation);
        }

        private void ButtonAnimation_Completed(object sender, EventArgs e)
        {
            MessageBox.Show("Анимация завершена");
        }
    }
}
