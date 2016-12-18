using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;
using Logic.Repository;
using System.Net.Mail;
using System.Net;
namespace UI
{
    static class Functions
    {
        static public void Color(out List<string> first)
        {
            using (var DB = new Context())
            {
                List<string> temp = new List<string>();
                IQueryable<Colour> data = from d in DB.Colours select d;
                foreach (var second in data)
                {
                    temp.Add(second.colour);
                }
                first = temp;
            }
        }
        static public void For_User_Data(out List<Costume> a, string a1)
        {
            using (var DB = new Context())
            {

                IQueryable<Costume> data = from d in DB.Costumes where d.name == a1 select d;
                List<Costume> temp = new List<Costume>();
                foreach (var first in data)
                {

                    temp.Add(first);
                }
                a = temp;
            }

        }


        static public void Mail(string text, string email)
        {
            //all data was correct
            MailMessage mail = new MailMessage();

            mail.From = new MailAddress("inna96i@mail.ru");

            mail.To.Add(new MailAddress(email));

            mail.Subject = "Payment";

            mail.Body = text;

            SmtpClient client = new SmtpClient();

            client.Host = "smtp.mail.ru";

            client.Port = 587;

            client.EnableSsl = true;

            client.Credentials = new NetworkCredential("ruslankh@yahoo.com", "12457896rR");

            client.DeliveryMethod = SmtpDeliveryMethod.Network;

            client.Send(mail);

            mail.Dispose();

        }
    }
}
