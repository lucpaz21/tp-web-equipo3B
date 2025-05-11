using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Gestion
{
    public class EmailService
    {
        private MailMessage email;
        private SmtpClient server;
        public EmailService() 
        {
            server = new SmtpClient();
            server.Credentials = new NetworkCredential("programacioniiiWEB@gmail.com", "programacion3");
            server.EnableSsl = true;
            server.Port = 587;
            server.Host = "smtp-mail.outlook.com";
        
        }

        public void armarCorreo(string emailDestino)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@programacioniii.com");
            email.To.Add(emailDestino);
            email.IsBodyHtml = true;
            email.Body = "";
        }

        public void enviarEmail() 
        {
            try
            {
                server.Send(email);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        
        }
    }
}
