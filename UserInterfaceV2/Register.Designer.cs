namespace UserInterfaceV2
{
    partial class Register
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
            System.Windows.Forms.Label label4;
            this.txtRePassword = new System.Windows.Forms.TextBox();
            this.btnRegisterSubmit = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.LOGIN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = System.Drawing.Color.Transparent;
            label4.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label4.ForeColor = System.Drawing.Color.White;
            label4.Location = new System.Drawing.Point(77, 144);
            label4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(73, 18);
            label4.TabIndex = 26;
            label4.Text = "Username:";
            // 
            // txtRePassword
            // 
            this.txtRePassword.Location = new System.Drawing.Point(78, 287);
            this.txtRePassword.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtRePassword.Name = "txtRePassword";
            this.txtRePassword.PasswordChar = '*';
            this.txtRePassword.Size = new System.Drawing.Size(153, 20);
            this.txtRePassword.TabIndex = 25;
            // 
            // btnRegisterSubmit
            // 
            this.btnRegisterSubmit.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.btnRegisterSubmit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnRegisterSubmit.Location = new System.Drawing.Point(78, 328);
            this.btnRegisterSubmit.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.btnRegisterSubmit.Name = "btnRegisterSubmit";
            this.btnRegisterSubmit.Size = new System.Drawing.Size(150, 29);
            this.btnRegisterSubmit.TabIndex = 23;
            this.btnRegisterSubmit.Text = "SUBMIT";
            this.btnRegisterSubmit.UseVisualStyleBackColor = false;
            this.btnRegisterSubmit.Click += new System.EventHandler(this.btnRegisterSubmit_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(78, 230);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(153, 20);
            this.txtPassword.TabIndex = 22;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(78, 168);
            this.txtUserName.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(153, 20);
            this.txtUserName.TabIndex = 21;
            // 
            // LOGIN
            // 
            this.LOGIN.AutoSize = true;
            this.LOGIN.BackColor = System.Drawing.Color.Transparent;
            this.LOGIN.Font = new System.Drawing.Font("Microsoft New Tai Lue", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LOGIN.ForeColor = System.Drawing.Color.White;
            this.LOGIN.Location = new System.Drawing.Point(75, 106);
            this.LOGIN.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.LOGIN.Name = "LOGIN";
            this.LOGIN.Size = new System.Drawing.Size(113, 29);
            this.LOGIN.TabIndex = 18;
            this.LOGIN.Text = "REGISTER";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(75, 202);
            this.label3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 263);
            this.label1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(126, 18);
            this.label1.TabIndex = 28;
            this.label1.Text = "Re-Enter Password:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::UserInterfaceV2.Properties.Resources.israel_palacio_IprD0z0zqss_unsplash;
            this.pictureBox1.Image = global::UserInterfaceV2.Resource1.israel_palacio_IprD0z0zqss_unsplash;
            this.pictureBox1.Location = new System.Drawing.Point(78, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(109, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::UserInterfaceV2.Properties.Resources.hunter_so_pK1aczmelMQ_unsplash;
            this.ClientSize = new System.Drawing.Size(300, 381);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(label4);
            this.Controls.Add(this.txtRePassword);
            this.Controls.Add(this.btnRegisterSubmit);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.LOGIN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(1, 1, 1, 1);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRePassword;
        private System.Windows.Forms.Button btnRegisterSubmit;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label LOGIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}