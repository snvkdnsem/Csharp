using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace p288
{
    public partial class Form1 : Form
    {
        OleDbDataAdapter adapter = null;
        DataSet ds = null;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ds = new DataSet("emp");
            //아래 onj 는 $ORACLE_HOME/network/admin 의 tnsnames.ora 파일에 정의된 TNS 이름
            string conStr = "Provider=ORAOLEDB.ORACLE;data source=topcredu;User ID = scott; Password = tiger";
            //string conStr = "Provider=MSDAORA;data source=topcredu;User ID=scott;Password=tiger";
            using (OleDbConnection connection = new OleDbConnection(conStr))
            {
                OleDbCommand command = new OleDbCommand();
                OleDbTransaction tr = null;
                try
                {
                    connection.Open();
                    tr = connection.BeginTransaction();
                    command.Connection = connection;
                    command.Transaction = tr;
                    command.CommandText = "insert into emp (empno, ename)"
                    + " values (3456, '3000 길동')";
                    int i = command.ExecuteNonQuery();
                    Console.WriteLine(i + "건 Inserted!");
                    command.CommandText = "insert into emp (empno, ename)"
                    + " values (7890, '3000 길동')";
                    i = command.ExecuteNonQuery();
                    tr.Commit(); //영구히 DB에 저장해라
                    adapter = new OleDbDataAdapter("select * from emp", connection);
                    adapter.Fill(ds, "EMP");
                    dataGridView1.DataSource = ds.Tables["EMP"];
                    adapter.Fill(ds, "EMP");
                }
                catch (Exception ex)
                {
                    tr?.Rollback(); // 취소
                    MessageBox.Show(ex.Message, "emp Table Loading Error");
                }
                finally
                {
                    connection.Close();
                }
            }
        }
    }
}