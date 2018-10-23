using System;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
public class Actress
{
    public string name;
    public int year;

    public Actress(string name, int year)
    {
        this.name = name;
        this.year = year;
    }
}

class MForm : Form
{
    private StatusBar sb;

    public MForm()
    {
        Text = "ListView";
        Size = new Size(350, 300);

        List<Actress> actresses = new List<Actress>();

        actresses.Add(new Actress("Jessica Alba", 1981));
        actresses.Add(new Actress("Angelina Jolie", 1975));
        actresses.Add(new Actress("Natalie Portman", 1981));
        actresses.Add(new Actress("Rachel Weiss", 1971));
        actresses.Add(new Actress("Scarlett Johansson", 1984));

        ColumnHeader name = new ColumnHeader();
        name.Text = "Name";
        name.Width = -1;
        ColumnHeader year = new ColumnHeader();
        year.Text = "Year";

        SuspendLayout();

        ListView lv = new ListView();
        lv.Parent = this; // this는 MForm
        lv.FullRowSelect = true;
        lv.GridLines = true;
        lv.AllowColumnReorder = true; // 탭 위치를 바꿀 수 있다.
        //lv.Sorting = SortOrder.Ascending;
        lv.Columns.AddRange(new ColumnHeader[] { name, year }); // AddRange : name, year 따로 할필요 없이 한번에 작성 가능
        lv.ColumnClick += new ColumnClickEventHandler(ColumnClick);

        foreach (Actress act in actresses)
        {
            ListViewItem item = new ListViewItem();
            item.Text = act.name;
            item.SubItems.Add(act.year.ToString());
            lv.Items.Add(item);
        }
        lv.Dock = DockStyle.Fill; // 도킹시스템 : 윈도우를 가득 채워라
        lv.Click += new EventHandler(OnChanged);
        sb = new StatusBar();
        sb.Parent = this;
        lv.View = View.Details; // 윈폼으로 할때는 F4를 통해 View, Details를 설정해줘야한다.
        ResumeLayout();
        CenterToScreen();
    }
    void OnChanged(object sender, EventArgs e)
    {
        ListView lv = (ListView)sender;
        //ListView lv == sender as ListView; // 오류가 나지 않고 null값을 전달해준다.(위의 코드는 오류가 뜬다.)
        string name = lv.SelectedItems[0].SubItems[0].Text;
        string born = lv.SelectedItems[0].SubItems[1].Text;
        sb.Text = name + ", " + born;
    }
    void ColumnClick(object sender, ColumnClickEventArgs e)
    {
        ListView lv = (ListView)sender;
        if (lv.Sorting == SortOrder.Ascending)
        {
            lv.Sorting = SortOrder.Descending;
        }
        else
        {
            lv.Sorting = SortOrder.Ascending;
        }
    }
}
class MApplication
{
    public static void Main()
    {
        Application.Run(new MForm());
    }
}