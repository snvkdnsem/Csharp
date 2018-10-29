using System;
using System.Windows;

namespace MenuApplication2
{
    /// <summary>
    /// MainWindow.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnExit(object sender, RoutedEventArgs e)
        {
            //Application.Current.Shutdown();
            Environment.Exit(0);
        }
    }
}
