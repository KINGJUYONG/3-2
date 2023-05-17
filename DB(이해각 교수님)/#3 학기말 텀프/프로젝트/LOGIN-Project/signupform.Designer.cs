namespace LOGIN
{
    partial class signupform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(signupform));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pw_textbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.confirm_button = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.card_textbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.submit_button = new System.Windows.Forms.Button();
            this.cancel_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
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
            this.pw_textbox.Location = new System.Drawing.Point(25, 279);
            this.pw_textbox.Multiline = true;
            this.pw_textbox.Name = "pw_textbox";
            this.pw_textbox.Size = new System.Drawing.Size(306, 48);
            this.pw_textbox.TabIndex = 4;
            this.pw_textbox.Text = "\r\n  비밀번호를 입력하세요";
            this.pw_textbox.WordWrap = false;
            this.pw_textbox.Enter += new System.EventHandler(this.pw_textbox_Enter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.confirm_button);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.name_textbox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.card_textbox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.phone_textbox);
            this.panel1.Controls.Add(this.id_textbox);
            this.panel1.Controls.Add(this.submit_button);
            this.panel1.Controls.Add(this.cancel_button);
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
            // confirm_button
            // 
            this.confirm_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm_button.BackgroundImage")));
            this.confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirm_button.Location = new System.Drawing.Point(250, 148);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(81, 48);
            this.confirm_button.TabIndex = 2;
            this.confirm_button.Text = "중복 확인";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label5.Location = new System.Drawing.Point(33, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 20;
            this.label5.Text = "회원이름";
            // 
            // name_textbox
            // 
            this.name_textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.name_textbox.Location = new System.Drawing.Point(25, 214);
            this.name_textbox.Multiline = true;
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(306, 48);
            this.name_textbox.TabIndex = 3;
            this.name_textbox.Text = "\r\n  회원이름을 입력하세요";
            this.name_textbox.WordWrap = false;
            this.name_textbox.Enter += new System.EventHandler(this.name_textbox_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(33, 396);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "카드번호";
            // 
            // card_textbox
            // 
            this.card_textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.card_textbox.Location = new System.Drawing.Point(25, 410);
            this.card_textbox.Multiline = true;
            this.card_textbox.Name = "card_textbox";
            this.card_textbox.Size = new System.Drawing.Size(306, 48);
            this.card_textbox.TabIndex = 6;
            this.card_textbox.Text = "\r\n  카드번호를 입력하세요";
            this.card_textbox.WordWrap = false;
            this.card_textbox.Enter += new System.EventHandler(this.card_textbox_Enter);
            this.card_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.card_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label3.Location = new System.Drawing.Point(33, 330);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 16;
            this.label3.Text = "휴대전화";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // phone_textbox
            // 
            this.phone_textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.phone_textbox.Location = new System.Drawing.Point(25, 344);
            this.phone_textbox.Multiline = true;
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(306, 48);
            this.phone_textbox.TabIndex = 5;
            this.phone_textbox.Text = "\r\n  전화번호를 입력하세요";
            this.phone_textbox.WordWrap = false;
            this.phone_textbox.Enter += new System.EventHandler(this.phone_textbox_Enter);
            this.phone_textbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.phone_KeyPress);
            // 
            // id_textbox
            // 
            this.id_textbox.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.id_textbox.Location = new System.Drawing.Point(25, 148);
            this.id_textbox.Multiline = true;
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(229, 48);
            this.id_textbox.TabIndex = 1;
            this.id_textbox.Text = "\r\n  ID를 입력하세요";
            this.id_textbox.Enter += new System.EventHandler(this.id_textbox_Enter);
            this.id_textbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.id_submit_enter);
            // 
            // submit_button
            // 
            this.submit_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("submit_button.BackgroundImage")));
            this.submit_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit_button.Location = new System.Drawing.Point(189, 460);
            this.submit_button.Name = "submit_button";
            this.submit_button.Size = new System.Drawing.Size(142, 36);
            this.submit_button.TabIndex = 7;
            this.submit_button.Text = "회원가입";
            this.submit_button.UseVisualStyleBackColor = true;
            this.submit_button.Click += new System.EventHandler(this.submit_button_Click);
            // 
            // cancel_button
            // 
            this.cancel_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("cancel_button.BackgroundImage")));
            this.cancel_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancel_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancel_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cancel_button.Location = new System.Drawing.Point(25, 460);
            this.cancel_button.Name = "cancel_button";
            this.cancel_button.Size = new System.Drawing.Size(142, 36);
            this.cancel_button.TabIndex = 8;
            this.cancel_button.Text = "돌아가기";
            this.cancel_button.UseVisualStyleBackColor = true;
            this.cancel_button.Click += new System.EventHandler(this.cancel_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label2.Location = new System.Drawing.Point(33, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "비밀번호";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label1.Location = new System.Drawing.Point(33, 134);
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
            this.exit_button.TabStop = false;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("순천향체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(302, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 22;
            this.label6.Text = "철도 예약 시스템";
            // 
            // signupform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(479, 561);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "signupform";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
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
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button submit_button;
        private System.Windows.Forms.Button cancel_button;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox card_textbox;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label6;
    }
}

