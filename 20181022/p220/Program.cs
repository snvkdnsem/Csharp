//p220 client
using System;
using System.IO; // StreamWriter(19번째 줄) 사용시 필요
using System.Text;
using System.Net;
using System.Net.Sockets; //TcpClient(11번째 줄), NetworkStream(18번째 줄) 사용시 필요
class TcpClientTest
{
    static void Main(string[] args)
    {
        TcpClient client = null;
        try
        {
            //LocalHost에 지정 포트로 TCP Connection을 생성하고 데이터를 송수신하기
            //위한 스트림을 얻는다.
            client = new TcpClient();
            client.Connect("192.168.0.217", 5001);
            NetworkStream stream = client.GetStream();
            StreamWriter writer = new StreamWriter(stream) { AutoFlush = true }; // 작성하기 위해 Wirter작성
            string dataToSend = Console.ReadLine();
            while (true)
            {
                writer.WriteLine(dataToSend); // data를 보낸다.
                if (dataToSend.IndexOf("<EOF>") > -1) break;
                dataToSend = Console.ReadLine();
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        finally
        {
            client.Close();
        }
    }
}