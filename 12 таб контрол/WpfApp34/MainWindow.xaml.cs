using System;
using System.Windows;

namespace WpfApp34
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (c1.SelectedIndex == 2)
            {
                c1.SelectedIndex = 0;

            }
            else
            {
                c1.SelectedIndex++;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (c1.SelectedIndex == 0)
            {
                c1.SelectedIndex = 2;

            }
            else
            {
                c1.SelectedIndex--;
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Вкладка " + Convert.ToString(c1.SelectedIndex + 1));
        }
    }
}
