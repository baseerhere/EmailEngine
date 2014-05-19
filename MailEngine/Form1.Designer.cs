namespace MailEngine
{
    partial class frmEmailEngine
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
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtBody = new System.Windows.Forms.TextBox();
            this.txtEmailAddresses = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(13, 13);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(459, 20);
            this.txtSubject.TabIndex = 0;
            this.txtSubject.Text = "Early-stage start-up looking for a non-technical co-founder.";
            // 
            // txtBody
            // 
            this.txtBody.Location = new System.Drawing.Point(13, 40);
            this.txtBody.Multiline = true;
            this.txtBody.Name = "txtBody";
            this.txtBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBody.Size = new System.Drawing.Size(459, 156);
            this.txtBody.TabIndex = 1;
            // 
            // txtEmailAddresses
            // 
            this.txtEmailAddresses.Location = new System.Drawing.Point(13, 206);
            this.txtEmailAddresses.Multiline = true;
            this.txtEmailAddresses.Name = "txtEmailAddresses";
            this.txtEmailAddresses.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmailAddresses.Size = new System.Drawing.Size(459, 101);
            this.txtEmailAddresses.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(342, 313);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(130, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(13, 359);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(459, 23);
            this.progressBar1.TabIndex = 4;
            // 
            // frmEmailEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 394);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.txtEmailAddresses);
            this.Controls.Add(this.txtBody);
            this.Controls.Add(this.txtSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimizeBox = false;
            this.Name = "frmEmailEngine";
            this.Text = "Email Engine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtBody;
        private System.Windows.Forms.TextBox txtEmailAddresses;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

