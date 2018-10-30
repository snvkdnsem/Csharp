using System;
using System.Windows;

namespace MvvmExam
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Environment.Exit(0);
            //System.Diagnostics.Process.GetCurrentProcess().Kill();
            //this.Close();
        }
    }
}
