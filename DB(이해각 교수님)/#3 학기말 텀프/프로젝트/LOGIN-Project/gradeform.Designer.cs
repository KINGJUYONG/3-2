namespace LOGIN
{
    partial class gradeform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(gradeform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.assign_combo2 = new System.Windows.Forms.ComboBox();
            this.modify_button = new System.Windows.Forms.Button();
            this.Data3 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.assign_button = new System.Windows.Forms.Button();
            this.Data2 = new System.Windows.Forms.DataGridView();
            this.assign_combo = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.approve_button = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data3)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(35, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 660);
            this.panel1.TabIndex = 23;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.assign_combo2);
            this.panel4.Controls.Add(this.modify_button);
            this.panel4.Controls.Add(this.Data3);
            this.panel4.Location = new System.Drawing.Point(14, 460);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1181, 194);
            this.panel4.TabIndex = 19;
            // 
            // assign_combo2
            // 
            this.assign_combo2.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.assign_combo2.FormattingEnabled = true;
            this.assign_combo2.Items.AddRange(new object[] {
            "VIP",
            "GOLD",
            "SILVER"});
            this.assign_combo2.Location = new System.Drawing.Point(1004, 4);
            this.assign_combo2.Name = "assign_combo2";
            this.assign_combo2.Size = new System.Drawing.Size(165, 27);
            this.assign_combo2.TabIndex = 19;
            // 
            // modify_button
            // 
            this.modify_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("modify_button.BackgroundImage")));
            this.modify_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modify_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.modify_button.Location = new System.Drawing.Point(1004, 112);
            this.modify_button.Name = "modify_button";
            this.modify_button.Size = new System.Drawing.Size(165, 68);
            this.modify_button.TabIndex = 19;
            this.modify_button.Text = "등급 수정";
            this.modify_button.UseVisualStyleBackColor = true;
            this.modify_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // Data3
            // 
            this.Data3.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data3.Location = new System.Drawing.Point(9, 6);
            this.Data3.Name = "Data3";
            this.Data3.RowTemplate.Height = 23;
            this.Data3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data3.Size = new System.Drawing.Size(965, 176);
            this.Data3.TabIndex = 26;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.assign_button);
            this.panel3.Controls.Add(this.Data2);
            this.panel3.Controls.Add(this.assign_combo);
            this.panel3.Location = new System.Drawing.Point(14, 274);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1181, 187);
            this.panel3.TabIndex = 18;
            // 
            // assign_button
            // 
            this.assign_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("assign_button.BackgroundImage")));
            this.assign_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assign_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assign_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.assign_button.Location = new System.Drawing.Point(1004, 105);
            this.assign_button.Name = "assign_button";
            this.assign_button.Size = new System.Drawing.Size(165, 68);
            this.assign_button.TabIndex = 17;
            this.assign_button.Text = "등급 배정";
            this.assign_button.UseVisualStyleBackColor = true;
            this.assign_button.Click += new System.EventHandler(this.assign_button_Click);
            // 
            // Data2
            // 
            this.Data2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data2.Location = new System.Drawing.Point(9, 4);
            this.Data2.Name = "Data2";
            this.Data2.RowTemplate.Height = 23;
            this.Data2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data2.Size = new System.Drawing.Size(965, 175);
            this.Data2.TabIndex = 17;
            // 
            // assign_combo
            // 
            this.assign_combo.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.assign_combo.FormattingEnabled = true;
            this.assign_combo.Items.AddRange(new object[] {
            "VIP",
            "GOLD",
            "SILVER"});
            this.assign_combo.Location = new System.Drawing.Point(1004, 4);
            this.assign_combo.Name = "assign_combo";
            this.assign_combo.Size = new System.Drawing.Size(165, 27);
            this.assign_combo.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.approve_button);
            this.panel2.Controls.Add(this.Data);
            this.panel2.Location = new System.Drawing.Point(14, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 192);
            this.panel2.TabIndex = 13;
            // 
            // approve_button
            // 
            this.approve_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("approve_button.BackgroundImage")));
            this.approve_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.approve_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.approve_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.approve_button.Location = new System.Drawing.Point(1004, 105);
            this.approve_button.Name = "approve_button";
            this.approve_button.Size = new System.Drawing.Size(165, 68);
            this.approve_button.TabIndex = 15;
            this.approve_button.Text = "가입 승인";
            this.approve_button.UseVisualStyleBackColor = true;
            this.approve_button.Click += new System.EventHandler(this.approve_button_Click);
            // 
            // Data
            // 
            this.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(9, 8);
            this.Data.Name = "Data";
            this.Data.RowTemplate.Height = 23;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(965, 175);
            this.Data.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(14, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 62);
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
            this.exit_button.Location = new System.Drawing.Point(1255, 1);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(19, 23);
            this.exit_button.TabIndex = 24;
            this.exit_button.TabStop = false;
            this.exit_button.Text = "X";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("순천향체", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Image = ((System.Drawing.Image)(resources.GetObject("label6.Image")));
            this.label6.Location = new System.Drawing.Point(1125, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 17);
            this.label6.TabIndex = 25;
            this.label6.Text = "철도 예약 시스템";
            // 
            // gradeform
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "gradeform";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data3)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Button approve_button;
        private System.Windows.Forms.DataGridView Data2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button assign_button;
        private System.Windows.Forms.ComboBox assign_combo;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox assign_combo2;
        private System.Windows.Forms.Button modify_button;
        private System.Windows.Forms.DataGridView Data3;
    }
}
