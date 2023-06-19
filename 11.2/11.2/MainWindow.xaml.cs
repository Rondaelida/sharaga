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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _11._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a = 0;

        public MainWindow()
        {
            InitializeComponent();
            string[] arr = { "Энергос", "Крэк", "Бомж", "Чарон+" };
            foreach (string s in arr)
            { list1.Items.Add(s); }
            

        }

        
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int[] arr1 = {32,60,100,15};
            
            if (list1.SelectedIndex==0)
            {
                a =a+ arr1[0];
                list2.Items.Add(list1.SelectedItem);
            }
            else if (list1.SelectedIndex == 1)
            {
                a =a+ arr1[1];
                list2.Items.Add(list1.SelectedItem);
            }
            else if (list1.SelectedIndex == 2)
            {
                a=a+ arr1[2];
                list2.Items.Add(list1.SelectedItem);
            }
            else if (list1.SelectedIndex == 3)
            {
                a=a+ arr1[3];
                list2.Items.Add(list1.SelectedItem);
            }
            t1.Text = Convert.ToString(a);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int[] arr1 = { 32, 60, 100, 15 };
            if (list1.SelectedIndex == 0)
            {
                a = a - arr1[0];
                list2.Items.Remove(list1.SelectedItem);
            }
            else if (list1.SelectedIndex == 1)
            {
                a = a - arr1[1];
                list2.Items.Remove(list1.SelectedItem);
            }
            else if (list1.SelectedIndex == 2)
            {
                a = a - arr1[2];
                list2.Items.Remove(list1.SelectedItem);
            }
            else if (list1.SelectedIndex == 3)
            {
                a = a - arr1[3];
                list2.Items.Remove(list1.SelectedItem);
            }
            t1.Text = Convert.ToString(a);

        }
    }
}
