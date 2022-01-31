using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Lesson15.Modules
{
    public class Mail
    {
        public void email_send()
        {
            string sendingEmailAddress = "<yours email>";
            string emailaddressPassword = "<yours password>";
            FilePath filePath = new FilePath("CartCheck.txt");

            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(sendingEmailAddress);
            Console.WriteLine("enter yuor email");
            mail.To.Add(Console.ReadLine());
            mail.Subject = "Store check";
            mail.Body = "Store check of the last buy";
            Attachment attachment;
            attachment = new Attachment(filePath.Path);
            mail.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential(sendingEmailAddress, emailaddressPassword);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mail);

        }
    }
}
