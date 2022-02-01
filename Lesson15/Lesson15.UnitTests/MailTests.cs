using System;
using System.Configuration;
using Xunit;

namespace Lesson15.UnitTests
{
    public class MailTests
    {
       [Fact]
       public void Test_Or_Email_Validation_Trows_Exeption_Then_Email_In_Incorrect_Farmat()
       {
            static void EmailValidation()
            {
               
                
                string enteredEmail = "bandymas@gmail..rfgrg";
                string regexString = @"^[a-zA-Z\.\-_]+@([a-zA-Z\.\-_]+\.)+[a-zA-Z]{2,4}$";
                var myRegexValidator = new RegexStringValidator(regexString);
                myRegexValidator.CanValidate(enteredEmail.GetType());
                try
                {
                    myRegexValidator.Validate(enteredEmail);
                    //Console.WriteLine("Validated. mail sended");
                    
                }
                catch 
                {
                    //Console.WriteLine("Error: {0}", e.Message.ToString());
                    //Console.WriteLine("Try again");
                    throw new ArgumentException("email address incorrect format");
                }
              
            }
            

            Assert.Throws<ArgumentException>(() => EmailValidation());
       }
    }
}
