namespace 방향키게임
{
    partial class FormJoin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJoin));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.jname_txt = new System.Windows.Forms.TextBox();
            this.jpasc_txt = new System.Windows.Forms.TextBox();
            this.jpas_txt = new System.Windows.Forms.TextBox();
            this.jid_txt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.join_btn = new System.Windows.Forms.Button();
            this.can_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.jname_txt);
            this.groupBox1.Controls.Add(this.jpasc_txt);
            this.groupBox1.Controls.Add(this.jpas_txt);
            this.groupBox1.Controls.Add(this.jid_txt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.groupBox1.Location = new System.Drawing.Point(30, 32);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(280, 194);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "회원가입";
            // 
            // jname_txt
            // 
            this.jname_txt.Location = new System.Drawing.Point(149, 148);
            this.jname_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jname_txt.Name = "jname_txt";
            this.jname_txt.Size = new System.Drawing.Size(100, 24);
            this.jname_txt.TabIndex = 7;
            // 
            // jpasc_txt
            // 
            this.jpasc_txt.Location = new System.Drawing.Point(149, 112);
            this.jpasc_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jpasc_txt.Name = "jpasc_txt";
            this.jpasc_txt.PasswordChar = '*';
            this.jpasc_txt.Size = new System.Drawing.Size(100, 24);
            this.jpasc_txt.TabIndex = 6;
            // 
            // jpas_txt
            // 
            this.jpas_txt.Location = new System.Drawing.Point(149, 78);
            this.jpas_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jpas_txt.Name = "jpas_txt";
            this.jpas_txt.PasswordChar = '*';
            this.jpas_txt.Size = new System.Drawing.Size(100, 24);
            this.jpas_txt.TabIndex = 5;
            // 
            // jid_txt
            // 
            this.jid_txt.Location = new System.Drawing.Point(149, 42);
            this.jid_txt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.jid_txt.Name = "jid_txt";
            this.jid_txt.Size = new System.Drawing.Size(100, 24);
            this.jid_txt.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "이름";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "비밀번호 확인";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "비밀번호";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "아이디";
            // 
            // join_btn
            // 
            this.join_btn.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_btn.Location = new System.Drawing.Point(81, 254);
            this.join_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(75, 39);
            this.join_btn.TabIndex = 1;
            this.join_btn.Text = "가입";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // can_btn
            // 
            this.can_btn.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.can_btn.Location = new System.Drawing.Point(182, 254);
            this.can_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.can_btn.Name = "can_btn";
            this.can_btn.Size = new System.Drawing.Size(75, 39);
            this.can_btn.TabIndex = 2;
            this.can_btn.Text = "취소";
            this.can_btn.UseVisualStyleBackColor = true;
            this.can_btn.Click += new System.EventHandler(this.can_btn_Click);
            // 
            // FormJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(341, 319);
            this.Controls.Add(this.can_btn);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormJoin";
            this.Text = "FormJoin";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox jname_txt;
        private System.Windows.Forms.TextBox jpasc_txt;
        private System.Windows.Forms.TextBox jpas_txt;
        private System.Windows.Forms.TextBox jid_txt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.Button can_btn;
    }
}