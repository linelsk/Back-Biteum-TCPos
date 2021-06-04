using biz.premier.Models.Email;
using System;
using System.IO;
using System.Net;
using System.Net.Mail;

namespace biz.premier.Servicies
{
    public class EmailService : IEmailService
    {
        private const string V = "C:/Users/erick/Documents/Premier API/back-3.1/back/api.premier/api.aldea/Files/";

        public string SendEmail(EmailModel email)
        {
            var response = "";
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "Smtp.Gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 10000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("erick@minimalist.mx", "minimalist2019");
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("no-reply@premier.com", "Premier");
                mailMessage.To.Add(email.To);
                mailMessage.Subject = email.Subject;
                mailMessage.IsBodyHtml = email.IsBodyHtml;
                mailMessage.Body = email.Body;
                smtpClient.Send(mailMessage);
                // new SmtpClient
                // {
                //     Host = "Smtp.Gmail.com",
                //     Port = 587,
                //     EnableSsl = true,
                //     Timeout = 10000,
                //     DeliveryMethod = SmtpDeliveryMethod.Network,
                //     UseDefaultCredentials = false,
                //     Credentials = new NetworkCredential("rodrigo.stps@gmail.com", "$dvs1188")
                // }.Send(new MailMessage
                // {
                //     From = new MailAddress("no-reply@premier.com", "Premier"),
                //     To = { email.To },
                //     Subject = email.Subject,
                //     IsBodyHtml = email.IsBodyHtml,
                //     Body = email.Body,
                // });

                response = "Correo enviado";
            }
            catch (Exception ex)
            {
                response = ex.ToString();
            }

            return response;
        }

        public string SendEmailAttach(EmailModelAttach email)
        {
            var response = "";
            try
            {
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "Smtp.Gmail.com";
                smtpClient.Port = 587;
                smtpClient.EnableSsl = true;
                smtpClient.Timeout = 10000;
                smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smtpClient.UseDefaultCredentials = false;
                smtpClient.Credentials = new NetworkCredential("erick@minimalist.mx", "minimalist2019");
                
                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress("no-reply@premier.com", "Premier");
                mailMessage.To.Add(email.To);
                mailMessage.Subject = email.Subject;
                mailMessage.IsBodyHtml = email.IsBodyHtml;
                mailMessage.Body = email.Body;

                foreach(var data in email.File)
                {
                    //string path = HttpContext.Current.Server.MapPath();
                    string random = Path.GetFullPath(data.attach);
                    Attachment attachment;
                    attachment = new Attachment(random);
                    mailMessage.Attachments.Add(attachment);
                }

                smtpClient.Send(mailMessage);
                //new SmtpClient
                //{
                //    Host = "Smtp.Gmail.com",
                //    Port = 587,
                //    EnableSsl = true,
                //    Timeout = 10000,
                //    DeliveryMethod = SmtpDeliveryMethod.Network,
                //    UseDefaultCredentials = false,
                //    Credentials = new NetworkCredential("rodrigo.stps@gmail.com", "$dvs1188")
                //}.Send(new MailMessage
                //{
                    
                //});

                response = "Correo enviado";
            }
            catch (Exception ex)
            {
                response = ex.ToString();
            }

            return response;
        }
    }
}
