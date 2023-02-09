using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CourseTask.Services
{
    public class EmailSender
    {
        public void SendEmail(string text)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("vytas.sts@gmail.com", "dibvcilpwbuklegn"),
                EnableSsl = true,
            };
            smtpClient.Send("vytas.sts@gmail.com", "vytas.sts@gmail.com", "test", text);
        }
    }
}
