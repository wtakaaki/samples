﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DataGridSample01
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = Enumerable.Range(1, 100).Select(i => new Person
                {
                    Name = "田中　太郎" + i,
                    Age = 20 + i % 50,
                    Kana = "たなか　たろう" + i,
                    Address = "東京都新宿区" + i,
                    Phone = "XXX-XXXX-XXX" + i % 10
                })
                .ToList();
        }
    }
}
