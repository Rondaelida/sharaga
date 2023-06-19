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

namespace _13
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void b1_Click(object sender, RoutedEventArgs e)
        {
                MessageBox.Show("тру");
        }

        private void b3_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void b2_Click(object sender, RoutedEventArgs e)
        {
            if (b2.IsChecked == true)
            {
                b1.IsEnabled = false;
                b5.IsEnabled = false;
                b8.IsEnabled = false;
            }
            else if (b2.IsChecked == false)
            {
                b1.IsEnabled = true;
                b5.IsEnabled = true;
                b8.IsEnabled = true;
            }
        }

        private void b4_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Да я сам не знаю что это такое ._.");
        }

        private void b5_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("кек");
        }

        private void b6_Click(object sender, RoutedEventArgs e)
        {
            if (b6.IsChecked == true)
            {
                b1.IsEnabled = false;
                b5.IsEnabled = false;
                b8.IsEnabled = false;
            }
            else if (b6.IsChecked == false)
            {
                b1.IsEnabled = true;
                b5.IsEnabled = true;
                b8.IsEnabled = true;
            }
        }

        private void b7_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void b8_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Лол");
        }

        private void b9_Click(object sender, RoutedEventArgs e)
        {
            if (b9.IsChecked == true)
            {
                b1.IsEnabled = false;
                b5.IsEnabled = false;
                b8.IsEnabled = false;
            }
            else if (b9.IsChecked == false)
            {
                b1.IsEnabled = true;
                b5.IsEnabled = true;
                b8.IsEnabled = true;
            }
        }

        private void b10_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
