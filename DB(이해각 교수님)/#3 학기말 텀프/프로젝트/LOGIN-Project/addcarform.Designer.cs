namespace LOGIN
{
    partial class addcarform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addcarform));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Data2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.trnum_label = new System.Windows.Forms.Label();
            this.trdir_label = new System.Windows.Forms.Label();
            this.trainnum_label = new System.Windows.Forms.Label();
            this.train_gr = new System.Windows.Forms.Label();
            this.addschedule_button = new System.Windows.Forms.Button();
            this.sm_button = new System.Windows.Forms.Button();
            this.train_date = new System.Windows.Forms.DateTimePicker();
            this.mg_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.up_button = new System.Windows.Forms.Button();
            this.addcar_button = new System.Windows.Forms.Button();
            this.Data = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.date_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel11.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.panel11);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel7);
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
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.Data2);
            this.panel4.Location = new System.Drawing.Point(14, 274);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1181, 373);
            this.panel4.TabIndex = 19;
            // 
            // Data2
            // 
            this.Data2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data2.Location = new System.Drawing.Point(6, 24);
            this.Data2.Name = "Data2";
            this.Data2.RowTemplate.Height = 23;
            this.Data2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data2.Size = new System.Drawing.Size(1167, 341);
            this.Data2.TabIndex = 17;
            this.Data2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data2_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel9);
            this.panel2.Controls.Add(this.panel8);
            this.panel2.Controls.Add(this.panel10);
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.train_date);
            this.panel2.Controls.Add(this.addschedule_button);
            this.panel2.Controls.Add(this.addcar_button);
            this.panel2.Location = new System.Drawing.Point(14, 83);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1181, 192);
            this.panel2.TabIndex = 13;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.trnum_label);
            this.panel5.Location = new System.Drawing.Point(678, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(281, 45);
            this.panel5.TabIndex = 30;
            // 
            // trnum_label
            // 
            this.trnum_label.AutoSize = true;
            this.trnum_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trnum_label.Location = new System.Drawing.Point(9, 13);
            this.trnum_label.Name = "trnum_label";
            this.trnum_label.Size = new System.Drawing.Size(216, 19);
            this.trnum_label.TabIndex = 20;
            this.trnum_label.Text = "열차번호를 선택하세요";
            // 
            // trdir_label
            // 
            this.trdir_label.AutoSize = true;
            this.trdir_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trdir_label.Location = new System.Drawing.Point(7, 13);
            this.trdir_label.Name = "trdir_label";
            this.trdir_label.Size = new System.Drawing.Size(176, 19);
            this.trdir_label.TabIndex = 20;
            this.trdir_label.Text = "방향을 선택하세요";
            // 
            // trainnum_label
            // 
            this.trainnum_label.AutoSize = true;
            this.trainnum_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.trainnum_label.Location = new System.Drawing.Point(25, 13);
            this.trainnum_label.Name = "trainnum_label";
            this.trainnum_label.Size = new System.Drawing.Size(61, 19);
            this.trainnum_label.TabIndex = 18;
            this.trainnum_label.Text = "label1";
            // 
            // train_gr
            // 
            this.train_gr.AutoSize = true;
            this.train_gr.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.train_gr.Location = new System.Drawing.Point(25, 13);
            this.train_gr.Name = "train_gr";
            this.train_gr.Size = new System.Drawing.Size(223, 19);
            this.train_gr.TabIndex = 19;
            this.train_gr.Text = "열차 등급을 선택하세요";
            // 
            // addschedule_button
            // 
            this.addschedule_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addschedule_button.BackgroundImage")));
            this.addschedule_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addschedule_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addschedule_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addschedule_button.Location = new System.Drawing.Point(988, 115);
            this.addschedule_button.Name = "addschedule_button";
            this.addschedule_button.Size = new System.Drawing.Size(165, 68);
            this.addschedule_button.TabIndex = 19;
            this.addschedule_button.Text = "운행시간표 추가";
            this.addschedule_button.UseVisualStyleBackColor = true;
            this.addschedule_button.Click += new System.EventHandler(this.modify_button_Click);
            // 
            // sm_button
            // 
            this.sm_button.BackColor = System.Drawing.Color.White;
            this.sm_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("sm_button.BackgroundImage")));
            this.sm_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.sm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sm_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sm_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.sm_button.Location = new System.Drawing.Point(3, 53);
            this.sm_button.Name = "sm_button";
            this.sm_button.Size = new System.Drawing.Size(208, 44);
            this.sm_button.TabIndex = 16;
            this.sm_button.Text = "새마을호";
            this.sm_button.UseVisualStyleBackColor = false;
            this.sm_button.Click += new System.EventHandler(this.sm_button_Click);
            // 
            // train_date
            // 
            this.train_date.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.train_date.Location = new System.Drawing.Point(970, 7);
            this.train_date.Name = "train_date";
            this.train_date.Size = new System.Drawing.Size(200, 26);
            this.train_date.TabIndex = 28;
            this.train_date.ValueChanged += new System.EventHandler(this.train_date_ValueChanged);
            // 
            // mg_button
            // 
            this.mg_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mg_button.BackgroundImage")));
            this.mg_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mg_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mg_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.mg_button.Location = new System.Drawing.Point(3, 7);
            this.mg_button.Name = "mg_button";
            this.mg_button.Size = new System.Drawing.Size(208, 45);
            this.mg_button.TabIndex = 17;
            this.mg_button.Text = "무궁화호";
            this.mg_button.UseVisualStyleBackColor = true;
            this.mg_button.Click += new System.EventHandler(this.mg_button_Click);
            // 
            // down_button
            // 
            this.down_button.BackColor = System.Drawing.Color.White;
            this.down_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("down_button.BackgroundImage")));
            this.down_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.down_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.down_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.down_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.down_button.Location = new System.Drawing.Point(141, 8);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(105, 44);
            this.down_button.TabIndex = 27;
            this.down_button.Text = "하행";
            this.down_button.UseVisualStyleBackColor = false;
            this.down_button.Click += new System.EventHandler(this.down_button_Click);
            // 
            // up_button
            // 
            this.up_button.BackColor = System.Drawing.Color.White;
            this.up_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("up_button.BackgroundImage")));
            this.up_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.up_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.up_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.up_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.up_button.Location = new System.Drawing.Point(30, 8);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(105, 44);
            this.up_button.TabIndex = 20;
            this.up_button.Text = "상행";
            this.up_button.UseVisualStyleBackColor = false;
            this.up_button.Click += new System.EventHandler(this.up_button_Click);
            // 
            // addcar_button
            // 
            this.addcar_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("addcar_button.BackgroundImage")));
            this.addcar_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addcar_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addcar_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.addcar_button.Location = new System.Drawing.Point(221, 107);
            this.addcar_button.Name = "addcar_button";
            this.addcar_button.Size = new System.Drawing.Size(165, 68);
            this.addcar_button.TabIndex = 15;
            this.addcar_button.Text = "열차 추가";
            this.addcar_button.UseVisualStyleBackColor = true;
            this.addcar_button.Click += new System.EventHandler(this.approve_button_Click);
            // 
            // Data
            // 
            this.Data.AllowUserToOrderColumns = true;
            this.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data.Location = new System.Drawing.Point(8, 8);
            this.Data.Name = "Data";
            this.Data.RowTemplate.Height = 23;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(270, 175);
            this.Data.TabIndex = 14;
            this.Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellContentClick);
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
            // date_label
            // 
            this.date_label.AutoSize = true;
            this.date_label.Font = new System.Drawing.Font("굴림", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.date_label.Location = new System.Drawing.Point(7, 14);
            this.date_label.Name = "date_label";
            this.date_label.Size = new System.Drawing.Size(176, 19);
            this.date_label.TabIndex = 21;
            this.date_label.Text = "날짜를 선택하세요";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 12);
            this.label1.TabIndex = 18;
            this.label1.Text = "전체 운행시간표 조회";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.Data);
            this.panel6.Location = new System.Drawing.Point(393, -1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(288, 192);
            this.panel6.TabIndex = 31;
            // 
            // panel7
            // 
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.Controls.Add(this.trdir_label);
            this.panel7.Location = new System.Drawing.Point(695, 127);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(279, 45);
            this.panel7.TabIndex = 32;
            // 
            // panel8
            // 
            this.panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel8.Controls.Add(this.date_label);
            this.panel8.Location = new System.Drawing.Point(680, 87);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(279, 45);
            this.panel8.TabIndex = 33;
            // 
            // panel9
            // 
            this.panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel9.Controls.Add(this.train_gr);
            this.panel9.Location = new System.Drawing.Point(-1, 43);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(395, 45);
            this.panel9.TabIndex = 34;
            // 
            // panel10
            // 
            this.panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel10.Controls.Add(this.trainnum_label);
            this.panel10.Location = new System.Drawing.Point(-1, -1);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(395, 45);
            this.panel10.TabIndex = 35;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.up_button);
            this.panel3.Controls.Add(this.down_button);
            this.panel3.Location = new System.Drawing.Point(680, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 60);
            this.panel3.TabIndex = 34;
            // 
            // panel11
            // 
            this.panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel11.Controls.Add(this.mg_button);
            this.panel11.Controls.Add(this.sm_button);
            this.panel11.Location = new System.Drawing.Point(14, 171);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(216, 104);
            this.panel11.TabIndex = 35;
            // 
            // addcarform
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addcarform";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
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
        private System.Windows.Forms.Button addcar_button;
        private System.Windows.Forms.DataGridView Data2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addschedule_button;
        private System.Windows.Forms.Button mg_button;
        private System.Windows.Forms.Button sm_button;
        private System.Windows.Forms.Label trainnum_label;
        private System.Windows.Forms.Label train_gr;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.Label trdir_label;
        private System.Windows.Forms.Label trnum_label;
        private System.Windows.Forms.DateTimePicker train_date;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label date_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel11;
    }
}
