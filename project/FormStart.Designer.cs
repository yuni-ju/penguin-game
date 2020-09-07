namespace 방향키게임
{
    partial class FormStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormStart));
            this.panel1 = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.life_lb = new System.Windows.Forms.Label();
            this.Timer_lb = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Time_lb = new System.Windows.Forms.Label();
            this.Stage_lb = new System.Windows.Forms.Label();
            this.Score_lb = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pg_pic = new System.Windows.Forms.PictureBox();
            this.penguinpicstart = new System.Windows.Forms.ImageList(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pg_pic)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Location = new System.Drawing.Point(47, 172);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(653, 104);
            this.panel1.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(31, 17);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(589, 72);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "방향키1.png");
            this.imageList1.Images.SetKeyName(1, "방향키2.png");
            this.imageList1.Images.SetKeyName(2, "방향키3.png");
            this.imageList1.Images.SetKeyName(3, "방향키4.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(747, 671);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // life_lb
            // 
            this.life_lb.Font = new System.Drawing.Font("메이플스토리", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.life_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.life_lb.Location = new System.Drawing.Point(23, 108);
            this.life_lb.Name = "life_lb";
            this.life_lb.Size = new System.Drawing.Size(56, 32);
            this.life_lb.TabIndex = 5;
            this.life_lb.Text = "Life";
            // 
            // Timer_lb
            // 
            this.Timer_lb.Font = new System.Drawing.Font("메이플스토리", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Timer_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Timer_lb.Location = new System.Drawing.Point(556, 23);
            this.Timer_lb.Name = "Timer_lb";
            this.Timer_lb.Size = new System.Drawing.Size(89, 32);
            this.Timer_lb.TabIndex = 6;
            this.Timer_lb.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Time_lb
            // 
            this.Time_lb.Font = new System.Drawing.Font("메이플스토리", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Time_lb.Location = new System.Drawing.Point(641, 23);
            this.Time_lb.Name = "Time_lb";
            this.Time_lb.Size = new System.Drawing.Size(66, 33);
            this.Time_lb.TabIndex = 7;
            this.Time_lb.Text = " ";
            // 
            // Stage_lb
            // 
            this.Stage_lb.Font = new System.Drawing.Font("메이플스토리", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Stage_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Stage_lb.Location = new System.Drawing.Point(23, 23);
            this.Stage_lb.Name = "Stage_lb";
            this.Stage_lb.Size = new System.Drawing.Size(192, 32);
            this.Stage_lb.TabIndex = 8;
            this.Stage_lb.Text = "Stage";
            // 
            // Score_lb
            // 
            this.Score_lb.Font = new System.Drawing.Font("메이플스토리", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Score_lb.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Score_lb.Location = new System.Drawing.Point(23, 64);
            this.Score_lb.Name = "Score_lb";
            this.Score_lb.Size = new System.Drawing.Size(192, 32);
            this.Score_lb.TabIndex = 9;
            this.Score_lb.Text = "Score";
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Location = new System.Drawing.Point(78, 108);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(277, 42);
            this.flowLayoutPanel2.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(278, 339);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(278, 383);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 15);
            this.label2.TabIndex = 12;
            // 
            // pg_pic
            // 
            this.pg_pic.BackColor = System.Drawing.Color.Transparent;
            this.pg_pic.Location = new System.Drawing.Point(261, 393);
            this.pg_pic.Name = "pg_pic";
            this.pg_pic.Size = new System.Drawing.Size(170, 174);
            this.pg_pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pg_pic.TabIndex = 13;
            this.pg_pic.TabStop = false;
            // 
            // penguinpicstart
            // 
            this.penguinpicstart.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("penguinpicstart.ImageStream")));
            this.penguinpicstart.TransparentColor = System.Drawing.Color.Transparent;
            this.penguinpicstart.Images.SetKeyName(0, "펭귄0.png");
            this.penguinpicstart.Images.SetKeyName(1, "펭귄1.png");
            this.penguinpicstart.Images.SetKeyName(2, "펭귄2.png");
            this.penguinpicstart.Images.SetKeyName(3, "펭귄3_1.png");
            this.penguinpicstart.Images.SetKeyName(4, "펭귄3_2.png");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(268, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "x 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(100, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 21);
            this.label4.TabIndex = 1;
            this.label4.Text = "x 0";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Location = new System.Drawing.Point(427, 609);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(314, 49);
            this.panel2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(172, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "S.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(15, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "A.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(205, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(48, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 0;
            this.pictureBox3.TabStop = false;
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 671);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pg_pic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.Score_lb);
            this.Controls.Add(this.Stage_lb);
            this.Controls.Add(this.Time_lb);
            this.Controls.Add(this.Timer_lb);
            this.Controls.Add(this.life_lb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormStart";
            this.Text = "게임시작";
            this.TransparencyKey = System.Drawing.SystemColors.ActiveCaption;
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormStart_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pg_pic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label life_lb;
        private System.Windows.Forms.Label Timer_lb;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label Time_lb;
        private System.Windows.Forms.Label Stage_lb;
        private System.Windows.Forms.Label Score_lb;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pg_pic;
        private System.Windows.Forms.ImageList penguinpicstart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
}