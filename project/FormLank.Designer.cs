namespace 방향키게임
{
    partial class FormLank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLank));
            this.lvList = new System.Windows.Forms.ListView();
            this.lankname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lanklevel = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lankround = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lankscore = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.sco_rdi = new System.Windows.Forms.RadioButton();
            this.lv_rdi = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // lvList
            // 
            this.lvList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.lankname,
            this.lanklevel,
            this.lankround,
            this.lankscore});
            this.lvList.Font = new System.Drawing.Font("메이플스토리", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvList.FullRowSelect = true;
            this.lvList.GridLines = true;
            this.lvList.Location = new System.Drawing.Point(65, 154);
            this.lvList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lvList.Name = "lvList";
            this.lvList.Size = new System.Drawing.Size(470, 226);
            this.lvList.TabIndex = 0;
            this.lvList.UseCompatibleStateImageBehavior = false;
            this.lvList.View = System.Windows.Forms.View.Details;
            // 
            // lankname
            // 
            this.lankname.Text = "이름";
            this.lankname.Width = 83;
            // 
            // lanklevel
            // 
            this.lanklevel.Text = "레벨";
            this.lanklevel.Width = 78;
            // 
            // lankround
            // 
            this.lankround.Text = "최고 단계";
            this.lankround.Width = 101;
            // 
            // lankscore
            // 
            this.lankscore.Text = "최고 점수";
            this.lankscore.Width = 104;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("메이플스토리", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(46, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "순위";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("메이플스토리", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(220, 418);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 38);
            this.button2.TabIndex = 6;
            this.button2.Text = "나가기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // sco_rdi
            // 
            this.sco_rdi.AutoSize = true;
            this.sco_rdi.BackColor = System.Drawing.Color.Transparent;
            this.sco_rdi.Checked = true;
            this.sco_rdi.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.sco_rdi.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.sco_rdi.Location = new System.Drawing.Point(294, 106);
            this.sco_rdi.Name = "sco_rdi";
            this.sco_rdi.Size = new System.Drawing.Size(95, 21);
            this.sco_rdi.TabIndex = 7;
            this.sco_rdi.TabStop = true;
            this.sco_rdi.Text = "최고점수 순";
            this.sco_rdi.UseVisualStyleBackColor = false;
            this.sco_rdi.CheckedChanged += new System.EventHandler(this.sco_rdi_CheckedChanged);
            // 
            // lv_rdi
            // 
            this.lv_rdi.AutoSize = true;
            this.lv_rdi.BackColor = System.Drawing.Color.Transparent;
            this.lv_rdi.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lv_rdi.Location = new System.Drawing.Point(411, 106);
            this.lv_rdi.Name = "lv_rdi";
            this.lv_rdi.Size = new System.Drawing.Size(96, 21);
            this.lv_rdi.TabIndex = 8;
            this.lv_rdi.Text = "최고레벨 순";
            this.lv_rdi.UseVisualStyleBackColor = false;
            // 
            // FormLank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(617, 467);
            this.Controls.Add(this.lv_rdi);
            this.Controls.Add(this.sco_rdi);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvList);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormLank";
            this.Text = "순위";
            this.Load += new System.EventHandler(this.FormLank_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvList;
        private System.Windows.Forms.ColumnHeader lankname;
        private System.Windows.Forms.ColumnHeader lankround;
        private System.Windows.Forms.ColumnHeader lankscore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader lanklevel;
        private System.Windows.Forms.RadioButton sco_rdi;
        private System.Windows.Forms.RadioButton lv_rdi;
    }
}