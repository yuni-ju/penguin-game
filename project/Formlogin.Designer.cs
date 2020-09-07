namespace 방향키게임
{
    partial class Formlogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Formlogin));
            this.id_txt = new System.Windows.Forms.TextBox();
            this.pass_txt = new System.Windows.Forms.TextBox();
            this.pass_lb = new System.Windows.Forms.Label();
            this.Id_lb = new System.Windows.Forms.Label();
            this.log_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // id_txt
            // 
            this.id_txt.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.id_txt.Location = new System.Drawing.Point(113, 30);
            this.id_txt.Name = "id_txt";
            this.id_txt.Size = new System.Drawing.Size(100, 24);
            this.id_txt.TabIndex = 0;
            // 
            // pass_txt
            // 
            this.pass_txt.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass_txt.Location = new System.Drawing.Point(113, 66);
            this.pass_txt.Name = "pass_txt";
            this.pass_txt.PasswordChar = '*';
            this.pass_txt.Size = new System.Drawing.Size(100, 25);
            this.pass_txt.TabIndex = 1;
            // 
            // pass_lb
            // 
            this.pass_lb.AutoSize = true;
            this.pass_lb.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pass_lb.Location = new System.Drawing.Point(28, 69);
            this.pass_lb.Name = "pass_lb";
            this.pass_lb.Size = new System.Drawing.Size(76, 21);
            this.pass_lb.TabIndex = 3;
            this.pass_lb.Text = "비밀번호";
            // 
            // Id_lb
            // 
            this.Id_lb.AutoSize = true;
            this.Id_lb.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Id_lb.Location = new System.Drawing.Point(28, 33);
            this.Id_lb.Name = "Id_lb";
            this.Id_lb.Size = new System.Drawing.Size(61, 21);
            this.Id_lb.TabIndex = 4;
            this.Id_lb.Text = "아이디";
            // 
            // log_btn
            // 
            this.log_btn.BackColor = System.Drawing.SystemColors.ControlLight;
            this.log_btn.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.log_btn.Location = new System.Drawing.Point(238, 33);
            this.log_btn.Name = "log_btn";
            this.log_btn.Size = new System.Drawing.Size(75, 51);
            this.log_btn.TabIndex = 5;
            this.log_btn.Text = "로그인";
            this.log_btn.UseVisualStyleBackColor = false;
            this.log_btn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Formlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(340, 120);
            this.Controls.Add(this.log_btn);
            this.Controls.Add(this.Id_lb);
            this.Controls.Add(this.pass_lb);
            this.Controls.Add(this.pass_txt);
            this.Controls.Add(this.id_txt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Formlogin";
            this.Text = "로그인";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox id_txt;
        private System.Windows.Forms.TextBox pass_txt;
        private System.Windows.Forms.Label pass_lb;
        private System.Windows.Forms.Label Id_lb;
        private System.Windows.Forms.Button log_btn;
    }
}