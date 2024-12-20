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

namespace WpfApp3
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
            Window1 next = new Window1();
            next.Show();
            this.Close();
        }

        private void ColorClick(object sender, RoutedEventArgs e)
        {
            Random rnd = new Random();
            Byte[] b = new Byte[3];
            rnd.NextBytes(b);
            this.Background = new SolidColorBrush(Color.FromRgb(b[0], b[1], b[2]));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window2 next = new Window2();
            next.Show();
            this.Close();
        }
    }
}
