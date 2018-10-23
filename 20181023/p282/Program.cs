using System;
using System.Data.OleDb; // OleDb에 접근해서 아래와 같이 using을 안써도 된다.
using Oracle.ManagedDataAccess.Client;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //아래에서 data source의 onj는 tnsnames.ora 파일의 DB접속이름이다.
            
             string str = @"Data Source=(DESCRIPTION =
            (ADDRESS = (PROTOCOL = TCP)(HOST = 192.168.0.27)(PORT = 1521))
            (CONNECT_DATA =
            (SERVER = DEDICATED)
            (SERVICE_NAME = topcredu)
            )
            ) ; User Id = scott; Password = tiger; Provider=OraOleDB.Oracle"; // OleDb를 추가하면 Provider=OraOleDB.Oracle를 추가 필요
            //콘솔프로그램에서 TNS 이름을 해석하지 못하는 오류가 발생한다면 위와 같이
            // TNSNAMES.ORA 파일의 내용을 직접 기술하여 처리하자.

            //string str = "data source=topcredu;user id=scott; password=tiger"; // DB연결문
            OleDbConnection Conn = new OleDbConnection(str);
            OleDbCommand Comm = new OleDbCommand();
            Comm.Connection = Conn;

            try
            {
                Conn.Open();
                Comm.CommandText = "SELECT ENAME FROM EMP"; // Comm.CommandText에 SQL을 넣으면 된다.
                OleDbDataReader reader = Comm.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader.GetString(reader.GetOrdinal("ENAME")));
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            finally
            {
                Conn.Close();
            }
        }
    }
}
