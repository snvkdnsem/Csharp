using System;
using System.Net;
using System.Net.Mail;

namespace EmailSmtp
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Credentials
                var credentials = new NetworkCredential("구글계정@gmail.com", "비번");
                // 내 구글계정 및 비번을 넣어야한다.

                // Mail message
                var mail = new MailMessage()
                {
                    From = new MailAddress("구글계정@gmail.com"), //메일 보내는 사람
                    Subject = "Test email.", // 메일제목
                    Body = "Test email body" // 메일내용
                };

                mail.To.Add(new MailAddress("받는사람 이메일주소"));

                // Smtp client
                var client = new SmtpClient()
                {
                    Port = 587,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Host = "smtp.gmail.com", // 전세계적으로 정해진 주소이다.
                    EnableSsl = true,
                    Credentials = credentials
                };

                // Send it...         
                client.Send(mail);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error in sending email: " + ex.Message);
                Console.ReadKey();
                return;
            }

            Console.WriteLine("Email sccessfully sent");
            Console.ReadKey();
        }
    }
}