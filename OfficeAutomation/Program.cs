using System.Net.Mail;
using System.Net;
using System; 
using System.Text;

namespace Program
{
    class Entry
    {
        static void Main()
        {
            Console.WriteLine("程序入口");
            try 
            {
                MailMessage msg = new MailMessage();
                msg.Priority = MailPriority.High;
                // msg.SubjectEncoding = Encoding.GetEncoding(936);
                msg.From = new MailAddress("betrayalpromise@163.com", "商务中心区");
                msg.To.Add("343021187@qq.com");
                msg.Subject = "subject";   //标题
                msg.Body = "body"; //内容

                SmtpClient client = new SmtpClient();
                client.Host = "smtp.163.com";   //发件方服务器地址
                client.Port = 25;  //发件方端口
                // client.UseDefaultCredentials = true;
                client.DeliveryMethod = System.Net.Mail.SmtpDeliveryMethod.Network;
                NetworkCredential credential = new NetworkCredential("betrayalpromise@163.com", "RUYVWQGZJJTGGBOC");
                client.Credentials = credential;
                client.Send(msg);
                client.Dispose();
            }
            catch (Exception e) 
            {
                Console.WriteLine(e);
                Console.WriteLine("邮件发送失败！");
            }
            finally
            {
                Console.WriteLine("邮件发送成功！");
            }
        }
    }

    // class Email
    // {


    // }
}