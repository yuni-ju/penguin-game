namespace 방향키게임
{
    partial class FormMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
            this.start_btn = new System.Windows.Forms.Button();
            this.store_btn = new System.Windows.Forms.Button();
            this.lank_btn = new System.Windows.Forms.Button();
            this.my_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.wel_lb = new System.Windows.Forms.Label();
            this.도움말ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.start_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.start_btn.Font = new System.Drawing.Font("메이플스토리", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start_btn.Location = new System.Drawing.Point(237, 228);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(280, 77);
            this.start_btn.TabIndex = 0;
            this.start_btn.Text = "게임시작";
            this.start_btn.UseVisualStyleBackColor = false;
            this.start_btn.Click += new System.EventHandler(this.start_btn_Click);
            // 
            // store_btn
            // 
            this.store_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.store_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("store_btn.BackgroundImage")));
            this.store_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.store_btn.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.store_btn.Location = new System.Drawing.Point(66, 390);
            this.store_btn.Name = "store_btn";
            this.store_btn.Size = new System.Drawing.Size(113, 103);
            this.store_btn.TabIndex = 1;
            this.store_btn.Text = "상점";
            this.store_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.store_btn.UseVisualStyleBackColor = false;
            this.store_btn.Click += new System.EventHandler(this.store_btn_Click);
            // 
            // lank_btn
            // 
            this.lank_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lank_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lank_btn.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lank_btn.Image = ((System.Drawing.Image)(resources.GetObject("lank_btn.Image")));
            this.lank_btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lank_btn.Location = new System.Drawing.Point(237, 390);
            this.lank_btn.Name = "lank_btn";
            this.lank_btn.Size = new System.Drawing.Size(113, 103);
            this.lank_btn.TabIndex = 2;
            this.lank_btn.Text = "순위";
            this.lank_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lank_btn.UseVisualStyleBackColor = false;
            this.lank_btn.Click += new System.EventHandler(this.lank_btn_Click);
            // 
            // my_btn
            // 
            this.my_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.my_btn.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.my_btn.Image = ((System.Drawing.Image)(resources.GetObject("my_btn.Image")));
            this.my_btn.Location = new System.Drawing.Point(410, 390);
            this.my_btn.Name = "my_btn";
            this.my_btn.Size = new System.Drawing.Size(113, 103);
            this.my_btn.TabIndex = 3;
            this.my_btn.Text = "내 정보";
            this.my_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.my_btn.UseVisualStyleBackColor = false;
            this.my_btn.Click += new System.EventHandler(this.my_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.logout_btn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logout_btn.BackgroundImage")));
            this.logout_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logout_btn.Font = new System.Drawing.Font("메이플스토리", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.logout_btn.Location = new System.Drawing.Point(577, 390);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(112, 103);
            this.logout_btn.TabIndex = 4;
            this.logout_btn.Text = "로그아웃";
            this.logout_btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.logout_btn.UseVisualStyleBackColor = false;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // wel_lb
            // 
            this.wel_lb.AutoSize = true;
            this.wel_lb.Font = new System.Drawing.Font("메이플스토리", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.wel_lb.Location = new System.Drawing.Point(29, 21);
            this.wel_lb.Name = "wel_lb";
            this.wel_lb.Size = new System.Drawing.Size(14, 19);
            this.wel_lb.TabIndex = 5;
            this.wel_lb.Text = " ";
            // 
            // 도움말ToolStripMenuItem
            // 
            this.도움말ToolStripMenuItem.Name = "도움말ToolStripMenuItem";
            this.도움말ToolStripMenuItem.Size = new System.Drawing.Size(175, 24);
            this.도움말ToolStripMenuItem.Text = "도움말";
            this.도움말ToolStripMenuItem.Click += new System.EventHandler(this.도움말ToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.도움말ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(176, 56);
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(747, 671);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.wel_lb);
            this.Controls.Add(this.logout_btn);
            this.Controls.Add(this.my_btn);
            this.Controls.Add(this.lank_btn);
            this.Controls.Add(this.store_btn);
            this.Controls.Add(this.start_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMenu";
            this.Text = "메뉴";
            this.Load += new System.EventHandler(this.FormMenu_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button store_btn;
        private System.Windows.Forms.Button lank_btn;
        private System.Windows.Forms.Button my_btn;
        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Label wel_lb;
        private System.Windows.Forms.ToolStripMenuItem 도움말ToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}