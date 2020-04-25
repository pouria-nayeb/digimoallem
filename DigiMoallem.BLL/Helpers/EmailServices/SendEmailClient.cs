using System.Net.Mail;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Helpers.EmailServices
{
    public class SendEmailClient
    {
        public static void Send(string To, string Subject, string Body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("ppour68@gmail.com", "دیجی معلم");
            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            //System.Net.Mail.Attachment attachment;
            // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            // mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ppour68@gmail.com", "@pou.nay681!");
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }

        public static async Task SendAsync(string To,string Subject,string Body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress("ppour68@gmail.com", "دیجی معلم");
            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            //System.Net.Mail.Attachment attachment;
            // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            // mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("ppour68@gmail.com", "@pou.nay681!");
            SmtpServer.EnableSsl = true;

            await Task.Run(() => {
                SmtpServer.Send(mail);
            });
        }
    }
}