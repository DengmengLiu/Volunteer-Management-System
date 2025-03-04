using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace program.Tools
{
    public class EmailNotification
    {
        public static void SendEmail(string Email, string Password, string toEmail, string subject, string body)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(Email);
                mail.To.Add(toEmail);
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = false;  // Set to true if your body contains HTML

                using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                {
                    smtp.Credentials = new NetworkCredential(Email, Password);
                    smtp.EnableSsl = true;  // SSL is required by Gmail
                    smtp.Send(mail);
                }
            }
            catch (Exception ex)
            {
            }
        }
    }
}
