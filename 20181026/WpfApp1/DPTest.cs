//p88
using System.Diagnostics;
using System.Windows;

namespace WpfApp1
{
    public class DPTest : DependencyObject
    {
        public static readonly DependencyProperty TestProperty =
            DependencyProperty.Register(
                "Test", //의존속성의 지원을 받는 자원
                typeof(string),
                typeof(DPTest),
                new PropertyMetadata("Depency Property Initial Value",
                    OnTestPropertyChanged));

        public string Test
        {
            get
            {
                Debug.WriteLine("Test GetValue");
                return (string)GetValue(TestProperty);
            }

            set
            {
                Debug.WriteLine("Test SetValue");
                SetValue(TestProperty, value);
            }
        }

        private static void OnTestPropertyChanged(DependencyObject d,
            DependencyPropertyChangedEventArgs e)
        {
            Debug.WriteLine("Property Change : {0}", e.NewValue);
        }
    }
}