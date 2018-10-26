/* p18
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HelloWorld_2
{
    class MyMain : Application
    {
        [STAThread]
        public static void Main()
        {
            MyMain app = new MyMain();
            app.ShutdownMode = ShutdownMode.OnMainWindowClose;//OnMainWindowClose을 끄면 자동적으로 떠있는 윈도우 창들이 꺼진다.
            app.Run();
        }

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown;
            mainWindow.Show();

            for(int i=0; i<2; i++)//윈도우 3개가 뜬다
            {
                Window win = new Window();
                win.Title = "Extra Window No. " + (i + 1);
                win.Show();
            }
        }

        void WinMouseDown(Object sender, MouseEventArgs args)
        {
            Window win = new Window();
            win.Title = "Modal DialogBox";
            win.Width = 400;
            win.Height = 200;

            Button b = new Button();
            b.Content = "Click Me!"; //버튼에 보이는 글씨
            b.Click += Button_Click;

            win.Content = b; //윈도우에 content속성
            win.ShowDialog();//modal 상태일때 뒤에있는 화면을 선택할 수 없다.(여기서는 메인을 클릭후 click me가 나온 이후에)
        }

        private void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}
*/

//p21 Application 상속을 받지 않을시 아래와 같이 작성
using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HelloWorld_2
{
    class MyMain
    {
        [STAThread]
        public static void Main()
        {
            Window mainWindow = new Window();
            mainWindow.Title = "WPF Sample(Main)";
            mainWindow.MouseDown += WinMouseDown;
            //mainWindow.Show();

            for (int i = 0; i < 2; i++)//윈도우 3개가 뜬다
            {
                Window win = new Window();
                win.Title = "Extra Window No. " + (i + 1);
                //win.ShowInTaskbar = false; // 하단 태스크바에 아이콘 세개를 하나로 나타나게 하는 방법
                win.Show();
            }

            //WPF Sample(Main) 윈도루를 맨 마지막에 띄움
            Application app = new Application();
            app.ShutdownMode = ShutdownMode.OnLastWindowClose;
            app.Run(mainWindow); // 현재는 메인이 맨마지막에 뜨므로 메인을 끄면 다른 윈도우 창들도 자동으로 종료된다.
        }

        static void WinMouseDown(Object sender, MouseEventArgs args)
        {
            Window win = new Window();
            win.Title = "Modal DialogBox";
            win.Width = 400;
            win.Height = 200;

            Button b = new Button();
            b.Content = "Click Me!"; //버튼에 보이는 글씨
            b.Click += Button_Click;

            win.Content = b; //윈도우에 content속성
            win.ShowDialog();//modal 상태일때 뒤에있는 화면을 선택할 수 없다.(여기서는 메인을 클릭후 click me가 나온 이후에)
        }

        static void Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Button Click!", sender.ToString());
        }
    }
}