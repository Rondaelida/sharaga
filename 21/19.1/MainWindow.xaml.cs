using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace _19._1
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

        private void PlayButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Play();
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Pause();
        }

        private void StopButton_Click(object sender, RoutedEventArgs e)
        {
            mediaElement.Stop();
            mediaElement.Source = null;
        }

        private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            int SliderValue = (int)slide.Value;
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, SliderValue);
            mediaElement.Position = ts;
        }

        private void Slider_ValueChanged_1(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            mediaElement.Volume = (double)sliderVol.Value;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                string selectedFileName = Convert.ToString(openFileDialog.FileName);
                mediaElement.Source = new System.Uri(Convert.ToString(selectedFileName));
                sliderVol.Minimum = 0;
                slide.Value = 0;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            mediaElement.Source = new Uri("C:\\Users\\user\\Downloads\\ПРЕМЬЕРА КЛИПА СУПЕРХИТА ЛП Милана Хаметова & Milana Star - ЛП ( Премьера клипа 2022 ) (720p).mp4");
            mediaElement.Play();
        }
    }


}
