using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace DPS.HelperFunctions
{
    public class Helper
    {
        public static async Task SendEmail(string Subject, string Body, string To)
        {
            System.Net.Mail.MailMessage mail = new System.Net.Mail.MailMessage();
            mail.To.Add(To);
            mail.BodyEncoding = Encoding.UTF8;
            mail.SubjectEncoding = Encoding.UTF8;
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient();
            smtp.Send(mail);
        }


    }
}