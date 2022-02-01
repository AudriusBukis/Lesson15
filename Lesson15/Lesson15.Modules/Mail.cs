using System;
using System.Net;
using System.Net.Mail;

namespace Lesson15.Modules
{
    public class Mail
    {
        public static void EmailSend()
        {
            string sendingEmailAddress = "enter your email";
            string emailaddressPassword = "enter yout password";
            var filePath = new FilePath("CartCheck.txt");
            var mailMsg = new MailMessage();
            var SmtpServer = new SmtpClient("smtp.gmail.com");
            mailMsg.From = new MailAddress(sendingEmailAddress);
            Console.WriteLine("enter yuor email");
            mailMsg.To.Add(Console.ReadLine());
            mailMsg.Subject = "Store check";
            mailMsg.Body = "Store check of the last buy";
            var attachment = new Attachment(filePath.Path);
            mailMsg.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential(sendingEmailAddress, emailaddressPassword);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mailMsg);

        }
    }
}
