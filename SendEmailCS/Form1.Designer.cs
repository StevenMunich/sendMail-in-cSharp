namespace SendEmailCS
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxFrom = new System.Windows.Forms.TextBox();
            this.textBoxTo = new System.Windows.Forms.TextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxBody = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labeSubject = new System.Windows.Forms.Label();
            this.labelTo = new System.Windows.Forms.Label();
            this.txtBody = new System.Windows.Forms.Label();
            this.labelAPIKEY = new System.Windows.Forms.Label();
            this.textBoxAPIKEY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(376, 373);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(75, 23);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBoxFrom
            // 
            this.textBoxFrom.Location = new System.Drawing.Point(112, 12);
            this.textBoxFrom.Name = "textBoxFrom";
            this.textBoxFrom.Size = new System.Drawing.Size(330, 20);
            this.textBoxFrom.TabIndex = 1;
            this.textBoxFrom.Text = "username33@gmail.com";
            // 
            // textBoxTo
            // 
            this.textBoxTo.Location = new System.Drawing.Point(112, 76);
            this.textBoxTo.Name = "textBoxTo";
            this.textBoxTo.Size = new System.Drawing.Size(330, 20);
            this.textBoxTo.TabIndex = 2;
            this.textBoxTo.Text = "username33@gmail.com";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(112, 113);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(330, 20);
            this.textBoxSubject.TabIndex = 3;
            this.textBoxSubject.Text = "a Test";
            // 
            // textBoxBody
            // 
            this.textBoxBody.Location = new System.Drawing.Point(52, 154);
            this.textBoxBody.Multiline = true;
            this.textBoxBody.Name = "textBoxBody";
            this.textBoxBody.Size = new System.Drawing.Size(390, 173);
            this.textBoxBody.TabIndex = 4;
            this.textBoxBody.Text = "Testing SMTP in C sharp.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "From";
            // 
            // labeSubject
            // 
            this.labeSubject.AutoSize = true;
            this.labeSubject.Location = new System.Drawing.Point(58, 116);
            this.labeSubject.Name = "labeSubject";
            this.labeSubject.Size = new System.Drawing.Size(43, 13);
            this.labeSubject.TabIndex = 6;
            this.labeSubject.Text = "Subject";
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Location = new System.Drawing.Point(71, 79);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(20, 13);
            this.labelTo.TabIndex = 7;
            this.labelTo.Text = "To";
            // 
            // txtBody
            // 
            this.txtBody.AutoSize = true;
            this.txtBody.Location = new System.Drawing.Point(12, 157);
            this.txtBody.Name = "txtBody";
            this.txtBody.Size = new System.Drawing.Size(31, 13);
            this.txtBody.TabIndex = 8;
            this.txtBody.Text = "Body";
            // 
            // labelAPIKEY
            // 
            this.labelAPIKEY.AutoSize = true;
            this.labelAPIKEY.Location = new System.Drawing.Point(12, 41);
            this.labelAPIKEY.Name = "labelAPIKEY";
            this.labelAPIKEY.Size = new System.Drawing.Size(95, 13);
            this.labelAPIKEY.TabIndex = 10;
            this.labelAPIKEY.Text = "Password/API key";
            // 
            // textBoxAPIKEY
            // 
            this.textBoxAPIKEY.Location = new System.Drawing.Point(113, 38);
            this.textBoxAPIKEY.Name = "textBoxAPIKEY";
            this.textBoxAPIKEY.Size = new System.Drawing.Size(330, 20);
            this.textBoxAPIKEY.TabIndex = 9;
            this.textBoxAPIKEY.Text = "aaaa bbbb cccc dddd";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "settings";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelAPIKEY);
            this.Controls.Add(this.textBoxAPIKEY);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.labeSubject);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxBody);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.textBoxTo);
            this.Controls.Add(this.textBoxFrom);
            this.Controls.Add(this.buttonSend);
            this.Name = "Form1";
            this.Text = "SMTP Mail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxFrom;
        private System.Windows.Forms.TextBox textBoxTo;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labeSubject;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.Label txtBody;
        private System.Windows.Forms.Label labelAPIKEY;
        private System.Windows.Forms.TextBox textBoxAPIKEY;
        private System.Windows.Forms.Button button1;
    }
}

