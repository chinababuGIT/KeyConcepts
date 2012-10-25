using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace smtpclient
{



    class Program
    {
        static void Main(string[] args)
        {
            var fromAdress = new MailAddress("ed_tsang@yahoo.com", "slbilling");
            var toAddress = new MailAddress("tsangwngkein@gmail.com", "slbilling test");

            MailMessage mailMessage = new MailMessage(fromAdress, toAddress)
            {
                Subject = "Your bill is ready",
                Body = "Your bill is ready to be viewed"
            };
           

          //  EmailJob emailJob = new EmailJob(mailMessage, new NetworkCredential("edkdtree", "kiddney11"));

            using (SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.mail.yahoo.com",
                Port = 587,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAdress.Address, "pdrpass1"),
                EnableSsl = true
            })
            {
                smtp.Send(mailMessage);
            }





        }
    }
}
