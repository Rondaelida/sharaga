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

namespace _11
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

        private void add_Click_1(object sender, RoutedEventArgs e)
        {
            string fam = Convert.ToString(box1.Text);
            string name = Convert.ToString(box2.Text);
            string fn = fam + " " + name;
            if (name.Length == 0 && fam.Length == 0)
            {
                MessageBox.Show("Введите данные.");
            }
            else if (fam.Length == 0)
            {
                MessageBox.Show("Введите фамилию.");
            }
            else if (name.Length == 0)
            {
                MessageBox.Show("Введите имя.");
            }
            else
            {
                list.Items.Add(fn);
            }
        }
        private void del_Click_1(object sender, RoutedEventArgs e)
        {
            list.Items.Remove(list.SelectedItem);
        }

        private void clear_Click_1(object sender, RoutedEventArgs e)
        {
            list.Items.Clear();
        }

        
    }
}