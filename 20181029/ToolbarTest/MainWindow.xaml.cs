﻿using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;

namespace ToolbarTest
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            List<String> list = new List<string>();
            InitializeComponent();
            list.Add("서울");
            list.Add("대전");
            list.Add("춘천");
            list.Add("제주");

            toolbar.ItemsSource = list;
        }

        public void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(((Button)sender).Content.ToString());
        }
    }
}
