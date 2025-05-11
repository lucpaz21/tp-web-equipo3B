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
            server.Credentials = new NetworkCredential("programacionwebiii@yahoo.com", "actividad4_");
            server.EnableSsl = true;
            server.Port = 465;
            server.Host = "smtp.mail.yahoo.com";
        
        }

        public void armarCorreo(string emailDestino)
        {
            email = new MailMessage();
            email.From = new MailAddress("noresponder@programacionwebiii.com");
            email.To.Add(emailDestino);
            email.IsBodyHtml = true;
            email.Body = "<h1>Registro exitoso</h1> <p> ¡Ya estas participando! - Enterate de mas novedades en nuestra web </p>";
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
