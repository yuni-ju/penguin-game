namespace 방향키게임
{
    partial class FormMain
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.join_btn = new System.Windows.Forms.Button();
            this.close_btn = new System.Windows.Forms.Button();
            this.login_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // join_btn
            // 
            this.join_btn.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.join_btn.Location = new System.Drawing.Point(309, 436);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(111, 50);
            this.join_btn.TabIndex = 1;
            this.join_btn.Text = "회원가입";
            this.join_btn.UseVisualStyleBackColor = true;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // close_btn
            // 
            this.close_btn.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.close_btn.Location = new System.Drawing.Point(309, 511);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(111, 50);
            this.close_btn.TabIndex = 2;
            this.close_btn.Text = "닫기";
            this.close_btn.UseVisualStyleBackColor = true;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // login_btn
            // 
            this.login_btn.Font = new System.Drawing.Font("메이플스토리", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.login_btn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_btn.Location = new System.Drawing.Point(309, 360);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(111, 50);
            this.login_btn.TabIndex = 0;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = true;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(152, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(429, 146);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 671);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.join_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.Text = "방향키게임";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

