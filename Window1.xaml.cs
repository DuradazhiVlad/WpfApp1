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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        
        public Window1()
        {
            InitializeComponent();
            
            
            
        }

        

        private void tb3_TextChanged(object sender, TextChangedEventArgs e)
        {
            

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
           
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
            Window2 window2 = new Window2(tb1.Text, tb2.Text, tb3.Text);
            window2.ShowDialog();
        }

        private void tb1_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }
    }
}
