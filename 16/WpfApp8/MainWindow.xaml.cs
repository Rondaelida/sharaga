using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp8
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Qwerty zxc = new Qwerty();
            zxc.qwerty1 = "001";
            zxc.qwerty2 = "ОЛГА";
            zxc.qwerty3 = "23";
            zxc.qwerty4 = "ТУРЦИЯ";

            dg.Items.Add(zxc);

            Qwerty ASD = new Qwerty();
            ASD.qwerty1 = "002";
            ASD.qwerty2 = "махмуд";
            ASD.qwerty3 = "30";
            ASD.qwerty4 = "таджикистан";

            dg.Items.Add(ASD);
        }
        public class Qwerty
        {
            public string qwerty1 { get; set; }
            public string qwerty2 { get; set; }
            public string qwerty3 { get; set; }
            public string qwerty4 { get; set; }



        }

        private void bt_clicked(object sender, RoutedEventArgs e)
        {
            Qwerty yty = new Qwerty();
            yty.qwerty1 = bt1.Text;
            yty.qwerty2 = bt2.Text;
            yty.qwerty3 = bt3.Text;
            yty.qwerty4 = bt4.Text;

            dg.Items.Add(yty);
        }

        private void dg_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Qwerty path = dg.SelectedItem as Qwerty;
            MessageBox.Show($"Первое: {path.qwerty1}\nВторое: {path.qwerty2}\nТретие: {path.qwerty3} \nЧетвертое: {path.qwerty4}");
        }
    }
}
