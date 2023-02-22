namespace BLOW_FISH_ENCRYPTION
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
            this.btnencrypt = new System.Windows.Forms.Button();
            this.rchtxtencrypt = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnencrypt
            // 
            this.btnencrypt.Location = new System.Drawing.Point(22, 162);
            this.btnencrypt.Name = "btnencrypt";
            this.btnencrypt.Size = new System.Drawing.Size(282, 47);
            this.btnencrypt.TabIndex = 0;
            this.btnencrypt.Text = "Encrypt file";
            this.btnencrypt.UseVisualStyleBackColor = true;
            this.btnencrypt.Click += new System.EventHandler(this.btnencrypt_Click);
            // 
            // rchtxtencrypt
            // 
            this.rchtxtencrypt.Location = new System.Drawing.Point(22, 105);
            this.rchtxtencrypt.Name = "rchtxtencrypt";
            this.rchtxtencrypt.Size = new System.Drawing.Size(494, 33);
            this.rchtxtencrypt.TabIndex = 1;
            this.rchtxtencrypt.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(341, 162);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(282, 47);
            this.button1.TabIndex = 3;
            this.button1.Text = "Decrypt file";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(522, 105);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 33);
            this.button2.TabIndex = 4;
            this.button2.Text = "browse file";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rchtxtencrypt);
            this.Controls.Add(this.btnencrypt);
            this.Name = "Form1";
            this.Text = "AES encryption demonstration by lenz byahurwa";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnencrypt;
        private System.Windows.Forms.RichTextBox rchtxtencrypt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

