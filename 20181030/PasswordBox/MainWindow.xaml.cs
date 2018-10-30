using System.Windows;

namespace PasswordBox
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

        private void passwordBox1_PasswordChanged(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Password changed");
        }

        private void Logon_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(pwd.SecurePassword.Length.ToString());
            MessageBox.Show(pwd.Password);        }
    }
}
