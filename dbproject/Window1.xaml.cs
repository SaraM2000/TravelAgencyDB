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
using System.Windows.Shapes;

namespace dbproject
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }
        private void Login_button(object sender, RoutedEventArgs e)
        {
            Window3 Search_employees = new Window3();
            this.Visibility = Visibility.Hidden;
            Search_employees.Show();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Search_employees = new MainWindow();
            this.Visibility = Visibility.Hidden;
            Search_employees.Show();
        }
    }
}
