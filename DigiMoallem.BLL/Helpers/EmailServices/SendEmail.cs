using System.Net.Mail;
using System.Threading.Tasks;

namespace DigiMoallem.BLL.Helpers.EmailServices
{
    public class SendEmail
    {
        public static void Send(string To, string Subject, string Body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("mail.digimoallem.ir");
            mail.From = new MailAddress("Support@digimoallem.ir", "دیجی معلم");
            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            //System.Net.Mail.Attachment attachment;
            // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            // mail.Attachments.Add(attachment);

            SmtpServer.Port = 25;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("Support@DEFAULT", "*3O8PBw");
            SmtpServer.EnableSsl = false;

            SmtpServer.Send(mail);

        }

        public static async Task SendAsync(string To,string Subject,string Body)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("mail.digimoallem.ir");
            mail.From = new MailAddress("Support@digimoallem.ir", "دیجی معلم");
            mail.To.Add(To);
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            //System.Net.Mail.Attachment attachment;
            // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            // mail.Attachments.Add(attachment);

            SmtpServer.Port = 25;
            SmtpServer.UseDefaultCredentials = false;
            SmtpServer.Credentials = new System.Net.NetworkCredential("Support@DEFAULT", "*3O8PBw");
            SmtpServer.EnableSsl = false;

            await Task.Run(() => {
                SmtpServer.Send(mail);
            });
        }
    }
}