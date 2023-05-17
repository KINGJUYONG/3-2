namespace LOGIN
{
    partial class loginform
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loginform));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pw_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.findpw_button = new System.Windows.Forms.Button();
            this.findid_button = new System.Windows.Forms.Button();
            this.signup_button = new System.Windows.Forms.Button();
            this.login_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList2
            // 
            this.imageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList2.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageList3
            // 
            this.imageList3.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList3.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // pw_textbox
            // 
            this.pw_textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.pw_textbox.Location = new System.Drawing.Point(25, 262);
            this.pw_textbox.Multiline = true;
            this.pw_textbox.Name = "pw_textbox";
            this.pw_textbox.Size = new System.Drawing.Size(306, 48);
            this.pw_textbox.TabIndex = 2;
            this.pw_textbox.Text = "\r\n  비밀번호를 입력하세요";
            this.pw_textbox.WordWrap = false;
            this.pw_textbox.Enter += new System.EventHandler(this.pw_textbox_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.id_textbox);
            this.panel1.Controls.Add(this.findpw_button);
            this.panel1.Controls.Add(this.findid_button);
            this.panel1.Controls.Add(this.signup_button);
            this.panel1.Controls.Add(this.login_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pw_textbox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(61, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 499);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // id_textbox
            // 
            this.id_textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.id_textbox.Location = new System.Drawing.Point(25, 182);
            this.id_textbox.Multiline = true;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(306, 48);
            this.id_textbox.TabIndex = 1;
            this.id_textbox.Text = "\r\n  ID를 입력하세요";
            this.id_textbox.Enter += new System.EventHandler(this.id_textbox_Enter);
            // 
            // findpw_button
            // 
            this.findpw_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findpw_button.BackgroundImage")));
            this.findpw_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findpw_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findpw_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findpw_button.Location = new System.Drawing.Point(107, 449);
            this.findpw_button.Name = "findpw_button";
            this.findpw_button.Size = new System.Drawing.Size(142, 36);
            this.findpw_button.TabIndex = 6;
            this.findpw_button.Text = "비밀번호 재설정";
            this.findpw_button.UseVisualStyleBackColor = true;
            this.findpw_button.Click += new System.EventHandler(this.findpw_button_Click);
            // 
            // findid_button
            // 
            this.findid_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("findid_button.BackgroundImage")));
            this.findid_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.findid_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findid_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.findid_button.Location = new System.Drawing.Point(107, 407);
            this.findid_button.Name = "findid_button";
            this.findid_button.Size = new System.Drawing.Size(142, 36);
            this.findid_button.TabIndex = 5;
            this.findid_button.Text = "ID 찾기";
            this.findid_button.UseVisualStyleBackColor = true;
            this.findid_button.Click += new System.EventHandler(this.findid_button_Click);
            // 
            // signup_button
            // 
            this.signup_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signup_button.BackgroundImage")));
            this.signup_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signup_button.Location = new System.Drawing.Point(107, 365);
            this.signup_button.Name = "signup_button";
            this.signup_button.Size = new System.Drawing.Size(142, 36);
            this.signup_button.TabIndex = 4;
            this.signup_button.Text = "회원가입";
            this.signup_button.UseVisualStyleBackColor = true;
            this.signup_button.Click += new System.EventHandler(this.signup_button_Click);
            // 
            // login_button
            // 
            this.login_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_button.BackgroundImage")));
            this.login_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.login_button.Location = new System.Drawing.Point(107, 323);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(142, 36);
            this.login_button.TabIndex = 3;
            this.login_button.Text = "로그인";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(33, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "PW";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(33, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(31, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(299, 113);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // exit_button
            // 
            this.exit_button.FlatAppearance.BorderSize = 0;
            this.exit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit_button.Image = ((System.Drawing.Image)(resources.GetObject("exit_button.Image")));
            this.exit_button.Location = new System.Drawing.Point(460, 0);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(19, 23);
            this.exit_button.TabIndex = 12;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("순천향체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Image = ((System.Drawing.Image)(resources.GetObject("label3.Image")));
            this.label3.Location = new System.Drawing.Point(302, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "철도 예약 시스템";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // loginform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 561);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "loginform";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox pw_textbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button signup_button;
        private System.Windows.Forms.Button findpw_button;
        private System.Windows.Forms.Button findid_button;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
    }
}

