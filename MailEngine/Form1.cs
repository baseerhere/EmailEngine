using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailEngine
{
    public partial class frmEmailEngine : Form
    {
        public frmEmailEngine()
        {
            InitializeComponent();
        }


        public string FromEmailAddress = "rana@email.arizona.edu";
        public string EmailHostName = "smtpgate.email.arizona.edu";
        public string EmailPortNo = "587";
        public string EmailUserName = "rana";
        public string EmailPassword = "7UJM2WSX4RFV4RFV";

        private void btnSend_Click(object sender, EventArgs e)
        {
            btnSend.Enabled = false;
            try
            {
                // Get emails
                List<Recipient> _Recipients = new List<Recipient>();

                string _RecupientText = txtEmailAddresses.Text.Trim();
                string[] _EachRec = _RecupientText.Split('\n');
                foreach (var item in _EachRec)
                {
                    _Recipients.Add(new Recipient { Name = item.Split('\t')[0].Trim(), EmailAddress = item.Split('\t')[1].Trim() });
                }

                progressBar1.Maximum = _Recipients.Count();
                progressBar1.Value = 1;
                string _HtmlText = "";
                foreach (var item in _Recipients)
                {
                    _HtmlText = txtBody.Text;

                    _HtmlText = _HtmlText.Replace("[%Name%]", item.Name.Replace(",",""));
                    _HtmlText = _HtmlText.Replace("[%email%]", item.EmailAddress);

                    // Send email
                    SendEmail(item.EmailAddress, _HtmlText, txtSubject.Text);
                    progressBar1.Value = progressBar1.Value + 1;
                }
            }
            catch (Exception)
            {

            }
            btnSend.Enabled = true;


        }

        public bool SendEmail(string _Email, string _Message, string _Subject)
        {
            try
            {
                //creating object for MailMessage Class
                MailMessage _Mail = new MailMessage();
                //Setting values for _Mail object 
                _Mail.Subject = _Subject;
                _Mail.Body = _Message;
                _Mail.IsBodyHtml = true;
                _Mail.To.Add(new MailAddress(_Email));
                _Mail.From = new MailAddress(FromEmailAddress,"Rana Suryadevara");
                _Mail.Bcc.Add(new MailAddress("baseer.intellidate@gmail.com"));

                //Creating Object for SmtpClient Class
                SmtpClient _Smtp = new SmtpClient();

                //Setting values for SmtpClient class object
                _Smtp.EnableSsl = true;

                //Setting gmail credentails to smtp server
                _Smtp.Host = EmailHostName;
                _Smtp.Port = Convert.ToInt32(EmailPortNo);
                _Smtp.Credentials = new System.Net.NetworkCredential(EmailUserName, EmailPassword);
                
                //Sending Mail Using Smtp Server
                _Smtp.Send(_Mail);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    public class Recipient
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
    }
}
