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
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DispatcherTimer T;
        public MainWindow()
        {
            InitializeComponent();
            T = new DispatcherTimer() 
            { 
                Interval = new TimeSpan(0, 0, 1) 
            };

            T.Tick += Timer_Tick;

            T.Start();
        }

        private void Button_Click(object sender, EventArgs e)
        {
           BR.Value += BR.Maximum / 10; 
        }

        private void Timer_Tick(object sender, object e)
        {
            a.Value += a.Maximum / 10;
            if (a.Value == 100)
                T.Stop();
        }
        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            ((Slider)sender).SelectionEnd = e.NewValue;
        }
    }
}
