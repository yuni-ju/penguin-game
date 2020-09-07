namespace 방향키게임
{
    partial class FormMy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMy));
            this.name_lb = new System.Windows.Forms.Label();
            this.bs_lb = new System.Windows.Forms.Label();
            this.br_lb = new System.Windows.Forms.Label();
            this.hvitem_ib = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.time_lb = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.life_lb = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hvcoin_lb = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.lv_lb = new System.Windows.Forms.Label();
            this.penguinpicmy = new System.Windows.Forms.ImageList(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // name_lb
            // 
            this.name_lb.AutoSize = true;
            this.name_lb.BackColor = System.Drawing.Color.Transparent;
            this.name_lb.Font = new System.Drawing.Font("메이플스토리", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.name_lb.Location = new System.Drawing.Point(102, 50);
            this.name_lb.Name = "name_lb";
            this.name_lb.Size = new System.Drawing.Size(172, 26);
            this.name_lb.TabIndex = 1;
            this.name_lb.Text = " 님의 마이페이지";
            // 
            // bs_lb
            // 
            this.bs_lb.AutoSize = true;
            this.bs_lb.BackColor = System.Drawing.Color.Transparent;
            this.bs_lb.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.bs_lb.Location = new System.Drawing.Point(307, 179);
            this.bs_lb.Name = "bs_lb";
            this.bs_lb.Size = new System.Drawing.Size(87, 22);
            this.bs_lb.TabIndex = 2;
            this.bs_lb.Text = "최고점수 :";
            // 
            // br_lb
            // 
            this.br_lb.AutoSize = true;
            this.br_lb.BackColor = System.Drawing.Color.Transparent;
            this.br_lb.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.br_lb.Location = new System.Drawing.Point(307, 139);
            this.br_lb.Name = "br_lb";
            this.br_lb.Size = new System.Drawing.Size(104, 22);
            this.br_lb.TabIndex = 3;
            this.br_lb.Text = "최고라운드 :";
            // 
            // hvitem_ib
            // 
            this.hvitem_ib.AutoSize = true;
            this.hvitem_ib.BackColor = System.Drawing.Color.Transparent;
            this.hvitem_ib.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hvitem_ib.Location = new System.Drawing.Point(307, 264);
            this.hvitem_ib.Name = "hvitem_ib";
            this.hvitem_ib.Size = new System.Drawing.Size(111, 22);
            this.hvitem_ib.TabIndex = 4;
            this.hvitem_ib.Text = "보유 아이템 :";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.time_lb);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.life_lb);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(414, 264);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 48);
            this.panel1.TabIndex = 5;
            // 
            // time_lb
            // 
            this.time_lb.AutoSize = true;
            this.time_lb.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.time_lb.Location = new System.Drawing.Point(184, 10);
            this.time_lb.Name = "time_lb";
            this.time_lb.Size = new System.Drawing.Size(39, 21);
            this.time_lb.TabIndex = 3;
            this.time_lb.Text = "x 0";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(121, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // life_lb
            // 
            this.life_lb.AutoSize = true;
            this.life_lb.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.life_lb.Location = new System.Drawing.Point(62, 10);
            this.life_lb.Name = "life_lb";
            this.life_lb.Size = new System.Drawing.Size(39, 21);
            this.life_lb.TabIndex = 1;
            this.life_lb.Text = "x 0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // hvcoin_lb
            // 
            this.hvcoin_lb.AutoSize = true;
            this.hvcoin_lb.BackColor = System.Drawing.Color.Transparent;
            this.hvcoin_lb.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.hvcoin_lb.Location = new System.Drawing.Point(307, 220);
            this.hvcoin_lb.Name = "hvcoin_lb";
            this.hvcoin_lb.Size = new System.Drawing.Size(86, 22);
            this.hvcoin_lb.TabIndex = 6;
            this.hvcoin_lb.Text = "보유코인 :";
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Location = new System.Drawing.Point(78, 120);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(170, 174);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 7;
            this.pictureBox3.TabStop = false;
            // 
            // lv_lb
            // 
            this.lv_lb.AutoSize = true;
            this.lv_lb.BackColor = System.Drawing.Color.Transparent;
            this.lv_lb.Font = new System.Drawing.Font("메이플스토리", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv_lb.Location = new System.Drawing.Point(74, 310);
            this.lv_lb.Name = "lv_lb";
            this.lv_lb.Size = new System.Drawing.Size(161, 22);
            this.lv_lb.TabIndex = 8;
            this.lv_lb.Text = "현재 캐릭터 레벨 : ";
            // 
            // penguinpicmy
            // 
            this.penguinpicmy.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("penguinpicmy.ImageStream")));
            this.penguinpicmy.TransparentColor = System.Drawing.Color.Transparent;
            this.penguinpicmy.Images.SetKeyName(0, "펭귄0.png");
            this.penguinpicmy.Images.SetKeyName(1, "펭귄1.png");
            this.penguinpicmy.Images.SetKeyName(2, "펭귄2.png");
            this.penguinpicmy.Images.SetKeyName(3, "펭귄3_1.png");
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("메이플스토리", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.Location = new System.Drawing.Point(293, 357);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 38);
            this.button2.TabIndex = 9;
            this.button2.Text = "나가기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FormMy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(744, 418);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lv_lb);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.hvcoin_lb);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hvitem_ib);
            this.Controls.Add(this.br_lb);
            this.Controls.Add(this.bs_lb);
            this.Controls.Add(this.name_lb);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMy";
            this.Text = "내 정보";
            this.Load += new System.EventHandler(this.FormMy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label name_lb;
        private System.Windows.Forms.Label bs_lb;
        private System.Windows.Forms.Label br_lb;
        private System.Windows.Forms.Label hvitem_ib;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label time_lb;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label life_lb;
        private System.Windows.Forms.Label hvcoin_lb;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label lv_lb;
        private System.Windows.Forms.ImageList penguinpicmy;
        private System.Windows.Forms.Button button2;
    }
}