using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.IO;

namespace SendEmailCS{
    public partial class Form1 : Form{
        public Form1(){
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            string source = textBoxFrom.Text; //From
            string destination = textBoxTo.Text; //To
            string subject = textBoxSubject.Text;
            string body = textBoxBody.Text;

            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("username33@gmail.com", textBoxAPIKEY.Text),
                EnableSsl = true,
            }; //end obj
       
            //Client already has credintials: SMTP can now send.
            try{
                smtpClient.Send(source, destination, subject, body);
                MessageBox.Show("Done");
                
            }catch { 
                MessageBox.Show("failed"); 
            }
            //end try
   
        }//end btnClick
       
    }//end Form1

}//end nameSpace
