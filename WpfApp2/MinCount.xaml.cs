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

namespace WpfApp2
{
    /// <summary>
    /// Логика взаимодействия для MinCount.xaml
    /// </summary>
    public partial class MinCount : Window
    {
        public MinCount()
        {
            InitializeComponent();
        }
        int newMinCount;

        private void ButtOk_Click(object sender, RoutedEventArgs e)
        {
            newMinCount = 0;
        }
    }
}
