namespace UserInterfaceV2
{
    partial class Game
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlEnemies = new System.Windows.Forms.Panel();
            this.btnE3 = new System.Windows.Forms.Button();
            this.btnE2 = new System.Windows.Forms.Button();
            this.btnE1 = new System.Windows.Forms.Button();
            this.btnEnemy = new System.Windows.Forms.Button();
            this.pnlAeroplanes = new System.Windows.Forms.Panel();
            this.btnA3 = new System.Windows.Forms.Button();
            this.btnA2 = new System.Windows.Forms.Button();
            this.btnA1 = new System.Windows.Forms.Button();
            this.btnAeroplane = new System.Windows.Forms.Button();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.btnUndo = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pbAeroplane = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlEnemies.SuspendLayout();
            this.pnlAeroplanes.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAeroplane)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 15;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlEnemies
            // 
            this.pnlEnemies.Controls.Add(this.btnE3);
            this.pnlEnemies.Controls.Add(this.btnE2);
            this.pnlEnemies.Controls.Add(this.btnE1);
            this.pnlEnemies.Controls.Add(this.btnEnemy);
            this.pnlEnemies.Location = new System.Drawing.Point(996, 19);
            this.pnlEnemies.Margin = new System.Windows.Forms.Padding(2);
            this.pnlEnemies.MaximumSize = new System.Drawing.Size(394, 331);
            this.pnlEnemies.MinimumSize = new System.Drawing.Size(394, 87);
            this.pnlEnemies.Name = "pnlEnemies";
            this.pnlEnemies.Size = new System.Drawing.Size(394, 87);
            this.pnlEnemies.TabIndex = 4;
            // 
            // btnE3
            // 
            this.btnE3.BackColor = System.Drawing.Color.Gray;
            this.btnE3.FlatAppearance.BorderSize = 0;
            this.btnE3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnE3.Location = new System.Drawing.Point(2, 250);
            this.btnE3.Margin = new System.Windows.Forms.Padding(2);
            this.btnE3.Name = "btnE3";
            this.btnE3.Size = new System.Drawing.Size(390, 83);
            this.btnE3.TabIndex = 7;
            this.btnE3.Text = "Javelin";
            this.btnE3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnE3.UseVisualStyleBackColor = false;
            this.btnE3.Click += new System.EventHandler(this.btnE3_Click);
            // 
            // btnE2
            // 
            this.btnE2.BackColor = System.Drawing.Color.Gray;
            this.btnE2.FlatAppearance.BorderSize = 0;
            this.btnE2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnE2.Location = new System.Drawing.Point(2, 167);
            this.btnE2.Margin = new System.Windows.Forms.Padding(2);
            this.btnE2.Name = "btnE2";
            this.btnE2.Size = new System.Drawing.Size(390, 83);
            this.btnE2.TabIndex = 6;
            this.btnE2.Text = "Gammon";
            this.btnE2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnE2.UseVisualStyleBackColor = false;
            this.btnE2.Click += new System.EventHandler(this.btnE2_Click);
            // 
            // btnE1
            // 
            this.btnE1.BackColor = System.Drawing.Color.Gray;
            this.btnE1.FlatAppearance.BorderSize = 0;
            this.btnE1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnE1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnE1.Location = new System.Drawing.Point(2, 85);
            this.btnE1.Margin = new System.Windows.Forms.Padding(2);
            this.btnE1.Name = "btnE1";
            this.btnE1.Size = new System.Drawing.Size(390, 83);
            this.btnE1.TabIndex = 5;
            this.btnE1.Text = "MANTIS";
            this.btnE1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnE1.UseVisualStyleBackColor = false;
            this.btnE1.Click += new System.EventHandler(this.btnE1_Click);
            // 
            // btnEnemy
            // 
            this.btnEnemy.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnEnemy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnemy.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEnemy.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnEnemy.Location = new System.Drawing.Point(2, 2);
            this.btnEnemy.Margin = new System.Windows.Forms.Padding(2);
            this.btnEnemy.Name = "btnEnemy";
            this.btnEnemy.Size = new System.Drawing.Size(390, 83);
            this.btnEnemy.TabIndex = 2;
            this.btnEnemy.Text = "Enemies";
            this.btnEnemy.UseVisualStyleBackColor = false;
            this.btnEnemy.Click += new System.EventHandler(this.btnEnemy_Click);
            // 
            // pnlAeroplanes
            // 
            this.pnlAeroplanes.BackColor = System.Drawing.Color.Gray;
            this.pnlAeroplanes.Controls.Add(this.btnA3);
            this.pnlAeroplanes.Controls.Add(this.btnA2);
            this.pnlAeroplanes.Controls.Add(this.btnA1);
            this.pnlAeroplanes.Controls.Add(this.btnAeroplane);
            this.pnlAeroplanes.Location = new System.Drawing.Point(580, 21);
            this.pnlAeroplanes.Margin = new System.Windows.Forms.Padding(2);
            this.pnlAeroplanes.MaximumSize = new System.Drawing.Size(394, 321);
            this.pnlAeroplanes.MinimumSize = new System.Drawing.Size(394, 87);
            this.pnlAeroplanes.Name = "pnlAeroplanes";
            this.pnlAeroplanes.Size = new System.Drawing.Size(394, 87);
            this.pnlAeroplanes.TabIndex = 3;
            // 
            // btnA3
            // 
            this.btnA3.BackColor = System.Drawing.Color.Gray;
            this.btnA3.FlatAppearance.BorderSize = 0;
            this.btnA3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnA3.Image = global::UserInterfaceV2.Resource1.Plane3;
            this.btnA3.Location = new System.Drawing.Point(2, 248);
            this.btnA3.Margin = new System.Windows.Forms.Padding(2);
            this.btnA3.Name = "btnA3";
            this.btnA3.Size = new System.Drawing.Size(390, 71);
            this.btnA3.TabIndex = 4;
            this.btnA3.Text = "A3";
            this.btnA3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnA3.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnA3.UseVisualStyleBackColor = false;
            this.btnA3.Click += new System.EventHandler(this.btnA3_Click);
            // 
            // btnA2
            // 
            this.btnA2.BackColor = System.Drawing.Color.Gray;
            this.btnA2.FlatAppearance.BorderSize = 0;
            this.btnA2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnA2.Image = global::UserInterfaceV2.Resource1.Plane2;
            this.btnA2.Location = new System.Drawing.Point(2, 165);
            this.btnA2.Margin = new System.Windows.Forms.Padding(2);
            this.btnA2.Name = "btnA2";
            this.btnA2.Size = new System.Drawing.Size(390, 83);
            this.btnA2.TabIndex = 3;
            this.btnA2.Text = "A2";
            this.btnA2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnA2.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnA2.UseVisualStyleBackColor = false;
            this.btnA2.Click += new System.EventHandler(this.btnA2_Click);
            // 
            // btnA1
            // 
            this.btnA1.BackColor = System.Drawing.Color.Gray;
            this.btnA1.FlatAppearance.BorderSize = 0;
            this.btnA1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnA1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnA1.Image = global::UserInterfaceV2.Resource1.Plane1;
            this.btnA1.Location = new System.Drawing.Point(2, 85);
            this.btnA1.Margin = new System.Windows.Forms.Padding(2);
            this.btnA1.Name = "btnA1";
            this.btnA1.Size = new System.Drawing.Size(390, 83);
            this.btnA1.TabIndex = 2;
            this.btnA1.Text = "A1";
            this.btnA1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnA1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnA1.UseVisualStyleBackColor = false;
            this.btnA1.Click += new System.EventHandler(this.btnA1_Click);
            // 
            // btnAeroplane
            // 
            this.btnAeroplane.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.btnAeroplane.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAeroplane.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAeroplane.ForeColor = System.Drawing.Color.White;
            this.btnAeroplane.Location = new System.Drawing.Point(2, 0);
            this.btnAeroplane.Margin = new System.Windows.Forms.Padding(2);
            this.btnAeroplane.Name = "btnAeroplane";
            this.btnAeroplane.Size = new System.Drawing.Size(390, 83);
            this.btnAeroplane.TabIndex = 1;
            this.btnAeroplane.Text = "Aeroplanes";
            this.btnAeroplane.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnAeroplane.UseVisualStyleBackColor = false;
            this.btnAeroplane.Click += new System.EventHandler(this.btnAeroplane_Click);
            this.btnAeroplane.MouseClick += new System.Windows.Forms.MouseEventHandler(this.btnAeroplane_MouseClick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.Tan;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.ForeColor = System.Drawing.Color.Black;
            this.btnUndo.Location = new System.Drawing.Point(1508, 31);
            this.btnUndo.Margin = new System.Windows.Forms.Padding(2);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(192, 69);
            this.btnUndo.TabIndex = 7;
            this.btnUndo.Text = "UNDO";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Tan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(170, 29);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(278, 69);
            this.button1.TabIndex = 8;
            this.button1.Text = "START SIMULATION";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.Location = new System.Drawing.Point(1832, 169);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(396, 712);
            this.richTextBox1.TabIndex = 14;
            this.richTextBox1.Text = "";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(212, 894);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(532, 37);
            this.progressBar1.TabIndex = 14;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BackgroundImage = global::UserInterfaceV2.Resource1.liam_sims_q_AHu__5rrM_unsplash;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pb2);
            this.panel1.Controls.Add(this.pb5);
            this.panel1.Controls.Add(this.pb6);
            this.panel1.Controls.Add(this.pb3);
            this.panel1.Controls.Add(this.pb1);
            this.panel1.Controls.Add(this.pb4);
            this.panel1.Controls.Add(this.pbAeroplane);
            this.panel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Location = new System.Drawing.Point(38, 138);
            this.panel1.Margin = new System.Windows.Forms.Padding(6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1780, 746);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // pb2
            // 
            this.pb2.BackColor = System.Drawing.Color.White;
            this.pb2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb2.Location = new System.Drawing.Point(130, 269);
            this.pb2.Margin = new System.Windows.Forms.Padding(6);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(60, 58);
            this.pb2.TabIndex = 9;
            this.pb2.TabStop = false;
            this.pb2.Visible = false;
            // 
            // pb5
            // 
            this.pb5.BackColor = System.Drawing.Color.White;
            this.pb5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb5.Location = new System.Drawing.Point(58, 410);
            this.pb5.Margin = new System.Windows.Forms.Padding(6);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(60, 58);
            this.pb5.TabIndex = 12;
            this.pb5.TabStop = false;
            this.pb5.Visible = false;
            // 
            // pb6
            // 
            this.pb6.BackColor = System.Drawing.Color.White;
            this.pb6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb6.Location = new System.Drawing.Point(130, 410);
            this.pb6.Margin = new System.Windows.Forms.Padding(6);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(60, 58);
            this.pb6.TabIndex = 13;
            this.pb6.TabStop = false;
            this.pb6.Visible = false;
            // 
            // pb3
            // 
            this.pb3.BackColor = System.Drawing.Color.White;
            this.pb3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb3.Location = new System.Drawing.Point(58, 338);
            this.pb3.Margin = new System.Windows.Forms.Padding(6);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(60, 58);
            this.pb3.TabIndex = 10;
            this.pb3.TabStop = false;
            this.pb3.Visible = false;
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.White;
            this.pb1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb1.Location = new System.Drawing.Point(58, 269);
            this.pb1.Margin = new System.Windows.Forms.Padding(6);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(60, 58);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb1.TabIndex = 8;
            this.pb1.TabStop = false;
            this.pb1.Visible = false;
            // 
            // pb4
            // 
            this.pb4.BackColor = System.Drawing.Color.White;
            this.pb4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pb4.Location = new System.Drawing.Point(130, 338);
            this.pb4.Margin = new System.Windows.Forms.Padding(6);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(60, 58);
            this.pb4.TabIndex = 11;
            this.pb4.TabStop = false;
            this.pb4.Visible = false;
            // 
            // pbAeroplane
            // 
            this.pbAeroplane.BackColor = System.Drawing.Color.White;
            this.pbAeroplane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbAeroplane.Image = global::UserInterfaceV2.Resource1.Plane1;
            this.pbAeroplane.Location = new System.Drawing.Point(1656, 338);
            this.pbAeroplane.Margin = new System.Windows.Forms.Padding(6);
            this.pbAeroplane.Name = "pbAeroplane";
            this.pbAeroplane.Size = new System.Drawing.Size(30, 29);
            this.pbAeroplane.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbAeroplane.TabIndex = 0;
            this.pbAeroplane.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(70, 906);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Fuel Gage";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(1828, 138);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Report";
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImage = global::UserInterfaceV2.Resource1.hunter_so_pK1aczmelMQ_unsplash;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(2258, 948);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlAeroplanes);
            this.Controls.Add(this.pnlEnemies);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MinimumSize = new System.Drawing.Size(1060, 581);
            this.Name = "Game";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.pnlEnemies.ResumeLayout(false);
            this.pnlAeroplanes.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAeroplane)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pnlEnemies;
        private System.Windows.Forms.Button btnE3;
        private System.Windows.Forms.Button btnE2;
        private System.Windows.Forms.Button btnE1;
        private System.Windows.Forms.Panel pnlAeroplanes;
        private System.Windows.Forms.Button btnA3;
        private System.Windows.Forms.Button btnA2;
        private System.Windows.Forms.Button btnA1;
        private System.Windows.Forms.Button btnAeroplane;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnEnemy;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pbAeroplane;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

