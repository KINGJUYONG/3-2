namespace LOGIN
{
    partial class selectform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(selectform));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.modmem_button = new System.Windows.Forms.Button();
            this.addgrad = new System.Windows.Forms.Button();
            this.addcar = new System.Windows.Forms.Button();
            this.lkup = new System.Windows.Forms.Button();
            this.rsrv = new System.Windows.Forms.Button();
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
            // panel1
            // 
            this.panel1.Controls.Add(this.modmem_button);
            this.panel1.Controls.Add(this.addgrad);
            this.panel1.Controls.Add(this.addcar);
            this.panel1.Controls.Add(this.lkup);
            this.panel1.Controls.Add(this.rsrv);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(61, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(359, 499);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // modmem_button
            // 
            this.modmem_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modmem_button.BackgroundImage")));
            this.modmem_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modmem_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modmem_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modmem_button.Location = new System.Drawing.Point(76, 255);
            this.modmem_button.Name = "modmem_button";
            this.modmem_button.Size = new System.Drawing.Size(211, 36);
            this.modmem_button.TabIndex = 12;
            this.modmem_button.Text = "회원정보 수정 / 조회";
            this.modmem_button.UseVisualStyleBackColor = true;
            this.modmem_button.Click += new System.EventHandler(this.modmem_button_Click);
            // 
            // addgrad
            // 
            this.addgrad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addgrad.BackgroundImage")));
            this.addgrad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addgrad.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addgrad.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addgrad.Location = new System.Drawing.Point(76, 340);
            this.addgrad.Name = "addgrad";
            this.addgrad.Size = new System.Drawing.Size(211, 36);
            this.addgrad.TabIndex = 11;
            this.addgrad.Text = "회원등급관리(관리자용)";
            this.addgrad.UseVisualStyleBackColor = true;
            this.addgrad.Click += new System.EventHandler(this.addgrad_Click);
            // 
            // addcar
            // 
            this.addcar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addcar.BackgroundImage")));
            this.addcar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcar.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addcar.Location = new System.Drawing.Point(76, 297);
            this.addcar.Name = "addcar";
            this.addcar.Size = new System.Drawing.Size(211, 36);
            this.addcar.TabIndex = 10;
            this.addcar.Text = "배차(관리자용)";
            this.addcar.UseVisualStyleBackColor = true;
            this.addcar.Click += new System.EventHandler(this.addcar_Click);
            // 
            // lkup
            // 
            this.lkup.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lkup.BackgroundImage")));
            this.lkup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lkup.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkup.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lkup.Location = new System.Drawing.Point(76, 213);
            this.lkup.Name = "lkup";
            this.lkup.Size = new System.Drawing.Size(211, 36);
            this.lkup.TabIndex = 9;
            this.lkup.Text = "예매 조회";
            this.lkup.UseVisualStyleBackColor = true;
            this.lkup.Click += new System.EventHandler(this.lkup_Click);
            // 
            // rsrv
            // 
            this.rsrv.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rsrv.BackgroundImage")));
            this.rsrv.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rsrv.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rsrv.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.rsrv.Location = new System.Drawing.Point(76, 170);
            this.rsrv.Name = "rsrv";
            this.rsrv.Size = new System.Drawing.Size(211, 36);
            this.rsrv.TabIndex = 8;
            this.rsrv.Text = "예매";
            this.rsrv.UseVisualStyleBackColor = true;
            this.rsrv.Click += new System.EventHandler(this.rsrv_Click);
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
            // selectform
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
            this.Name = "selectform";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.panel1.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button rsrv;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button addgrad;
        private System.Windows.Forms.Button addcar;
        private System.Windows.Forms.Button lkup;
        private System.Windows.Forms.Button modmem_button;
    }
}

