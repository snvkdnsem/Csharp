using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListViewWindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent(); // design에 생성되어있다.
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lv_ColumnClick(object sender, ColumnClickEventArgs e)
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
}
