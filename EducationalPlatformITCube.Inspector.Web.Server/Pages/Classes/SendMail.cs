using System.Net.Mail;
using System.Net;

namespace EducationalPlatformITCube.Inspector.Web.Server.Pages.Classes
{
    public class SendMail
    {
        public async Task SendEmail(string recipient, string subject, string body)
        {
            try
            {
                MailAddress fromM = new MailAddress("secondemilbarish@gmail.com", "It-Cube");
                MailAddress toM = new MailAddress(recipient); //куда отправить

                using (MailMessage message = new MailMessage(fromM, toM))
                using (SmtpClient smtpClient = new SmtpClient())
                {
                    message.Subject = subject; // Заголовок
                    message.Body = body; //Содержание

                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.Port = 587;
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential(fromM.Address, "bgwurnyodcbrvllc");

                    await smtpClient.SendMailAsync(message);
                }
            
            } catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
