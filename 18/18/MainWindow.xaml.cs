﻿using System;
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

namespace _18
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

        private void calendar_SelectedDatesChanged(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = calendar1.SelectedDate;

        }

        private void calendar_SelectedDatesChanged1(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = calendar2.SelectedDate;

        }

        private void calendar_SelectedDatesChanged2(object sender, SelectionChangedEventArgs e)
        {
            DateTime? selectedDate = calendar3.SelectedDate;

        }

    }
}
