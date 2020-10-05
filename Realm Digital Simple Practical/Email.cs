using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace Realm_Digital_Simple_Practical
{
    public class Email
    {
        EmployeeModel emp = new EmployeeModel();
        public void EmailConfig()
        {

            //Email config sample 
            //Note email config was never provided on the question paper
                SmtpClient client = new SmtpClient(" server", 25);
                MailMessage msg = new MailMessage();

                NetworkCredential cred = new NetworkCredential("username", "password");
                msg.From = new MailAddress("emailsending the mail");
                msg.To.Add("EmailAdresslist");
                client.EnableSsl = false;
                client.Timeout = 10000;
                msg.Subject = "Birthday Wishes";
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                msg.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
                msg.Body = "Happy birth day "+emp.name +"" + emp.lastname;
                client.Credentials = cred;
                client.Send(msg);


            }
    }
}
