using System;
using System.Configuration;
using System.Net;
using System.Net.Mail;

namespace Lesson15.Modules
{
    public class Mail
    {
        public static void EmailSend()
        {
            
            string sendingEmailAddress = "enter your mail";
            string emailaddressPassword = "enter your password"; 
            var filePath = new FilePath("CartCheck.txt");
            var mailMsg = new MailMessage();
            var SmtpServer = new SmtpClient("smtp.gmail.com");
            mailMsg.From = new MailAddress(sendingEmailAddress);
            mailMsg.To.Add(EmailValidation());
            mailMsg.Subject = "Store check";
            mailMsg.Body = "Store check of the last buy";
            var attachment = new Attachment(filePath.Path);
            mailMsg.Attachments.Add(attachment);
            SmtpServer.Port = 587;
            SmtpServer.Credentials = new NetworkCredential(sendingEmailAddress, emailaddressPassword);
            SmtpServer.EnableSsl = true;
            SmtpServer.Send(mailMsg);

        }
        public static string EmailValidation()
        {
            while (true)
            {
                Console.WriteLine("enter yuor email");
                string enteredEmail = Console.ReadLine();
                string regexString = @"^[a-zA-Z\.\-_]+@([a-zA-Z\.\-_]+\.)+[a-zA-Z]{2,4}$";
                var myRegexValidator = new RegexStringValidator(regexString);
                Console.WriteLine("Started validation of email: {0}",
                myRegexValidator.CanValidate(enteredEmail.GetType()));
                try
                {
                    myRegexValidator.Validate(enteredEmail);
                    Console.WriteLine("Validated. mail sended");
                    return enteredEmail;
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine($"Error: {e.Message}");
                }
            }
        }
    }
}
