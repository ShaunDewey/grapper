using System.Net.Mail;
using System.Text;


namespace GrapperNew
{
    class Mail
    {
        public string Address;
        public string Subject;
        public string Body;
        public string AttachmentPath;

        public Mail(string address, string subject, string body, string attachementPath)
        {
            Address = address;
            Subject = subject;
            Body = body;
            AttachmentPath = attachementPath;
        }

        public void Send()
        {
            
                SmtpClient client = new SmtpClient();
                client.Port = 587;
                client.Host = "smtp.gmail.com";
                client.EnableSsl = true;
                client.Timeout = 10000;
                client.DeliveryMethod = SmtpDeliveryMethod.Network;
                client.UseDefaultCredentials = false;
                client.Credentials = new System.Net.NetworkCredential("[email removed]", "[application password removed]");

                MailMessage mail = new MailMessage("[email removed]", Address, Subject, Body);
                mail.BodyEncoding = UTF8Encoding.UTF8;
                mail.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;

                //MessageBox.Show(save_dir);

                Attachment attachment = new Attachment(AttachmentPath);
                mail.Attachments.Add(attachment);

                client.Send(mail);
                mail.Dispose();
            
        }
    }
}
