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

namespace _19
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

        private void cv1_Click(object sender, RoutedEventArgs e)
        {
            Pole.DefaultDrawingAttributes.Color = Colors.Pink;
        }

        private void cv2_Click(object sender, RoutedEventArgs e)
        {
            Pole.DefaultDrawingAttributes.Color = Color.FromRgb(254, 63, 68);
        }

        private void cv3_Click(object sender, RoutedEventArgs e)
        {
            Pole.DefaultDrawingAttributes.Color = Color.FromRgb(255, 221, 64);
        }

        private void cv4_Click(object sender, RoutedEventArgs e)
        {
            Pole.DefaultDrawingAttributes.Color = Color.FromRgb(186, 243, 0);
        }

        private void cv5_Click(object sender, RoutedEventArgs e)
        {
            Pole.DefaultDrawingAttributes.Color = Color.FromRgb(57, 226, 77);
        }
        private void cv6_Click(object sender, RoutedEventArgs e)
        {
            Pole.DefaultDrawingAttributes.Color = Color.FromRgb(51, 204, 204);
        }
        private void cv7_Click(object sender, RoutedEventArgs e)
        {
            Pole.DefaultDrawingAttributes.Color = Color.FromRgb(18, 64, 171);
        }
        private void cv8_Click(object sender, RoutedEventArgs e)
        {
            Pole.DefaultDrawingAttributes.Color = Colors.Black;
        }
        private void Ydol_Click(object sender, RoutedEventArgs e)
        {
            Pole.Strokes.Clear();
        }

        private void sir_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Pole.DefaultDrawingAttributes.Height = 1;
            double a = sir.Value;
            int b = Convert.ToInt32(a);
            Pole.DefaultDrawingAttributes.Height = b;
        }
        private void sur_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Pole.DefaultDrawingAttributes.Width = 1;
            double a = sur.Value;
            int b = Convert.ToInt32(a);
            Pole.DefaultDrawingAttributes.Width = b;
        }
    }
}
