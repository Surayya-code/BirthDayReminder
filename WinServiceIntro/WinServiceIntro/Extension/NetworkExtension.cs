using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace WinServiceIntro.Extension
{
    static partial class Extension
    {
        internal static bool SendEmail(this string ToEmail, string Body,string subject,string[] attachments=null )
        {
            try
            {
            lblToMailNull:
                if (string.IsNullOrWhiteSpace(ToEmail))
                {
                    throw new ArgumentNullException("ToEmail", "Boş buraxıla bilməz!");

                }

                string[] acceptedMails = ToEmail.Split(new[] { ';' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (acceptedMails.Count()<1)
                {
                    ToEmail = "";
                    goto lblToMailNull;
                }

                MailMessage message = new MailMessage();
                foreach (var email in acceptedMails)
                    message.To.Add(email);
                    message.Subject = subject;
                    message.Body = Body;


                //
                message.From = new MailAddress("sureyyahesenova@mail.ru", "Crazy Girl");
                message.IsBodyHtml = true;

                if (attachments != null)
                {
                    foreach (string attachment in attachments)
                    {
                        message.Attachments.Add(new Attachment(attachment));
                    }
                }

                //message.Body =;
               // message.From = new MailAddress("sureyyahesenova@mail.ru", "Crazy Girl");
                SmtpClient smptclient = new SmtpClient("smpt.mail.ru", 587);
                smptclient.EnableSsl = true;
                smptclient.UseDefaultCredentials = false;
                smptclient.DeliveryMethod = SmtpDeliveryMethod.Network;
                smptclient.Credentials = new NetworkCredential("sureyyahesenova", "15sureyya94s");
                smptclient.Send(message);

                return true;
            }

            catch (Exception ex)
            {
                return false;
            }

        }
    }
 }

