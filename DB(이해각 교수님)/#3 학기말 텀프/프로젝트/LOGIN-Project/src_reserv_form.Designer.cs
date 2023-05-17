namespace LOGIN
{
    partial class src_reserv_form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(src_reserv_form));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chosen_time = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.cash_button = new System.Windows.Forms.Button();
            this.card_button = new System.Windows.Forms.Button();
            this.car_1st = new System.Windows.Forms.Button();
            this.car_2st = new System.Windows.Forms.Button();
            this.chosen_seat = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.last_seat_label = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Data2 = new System.Windows.Forms.DataGridView();
            this.confirm_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.sel_date = new System.Windows.Forms.DateTimePicker();
            this.reset_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.end_comboBox = new System.Windows.Forms.ComboBox();
            this.start_comboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Data = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.exit_button = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Data2);
            this.panel1.Controls.Add(this.confirm_button);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.Data);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(35, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1210, 660);
            this.panel1.TabIndex = 23;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.chosen_time);
            this.panel3.Controls.Add(this.price);
            this.panel3.Controls.Add(this.cash_button);
            this.panel3.Controls.Add(this.card_button);
            this.panel3.Controls.Add(this.car_1st);
            this.panel3.Controls.Add(this.car_2st);
            this.panel3.Controls.Add(this.chosen_seat);
            this.panel3.Controls.Add(this.button5);
            this.panel3.Controls.Add(this.last_seat_label);
            this.panel3.Controls.Add(this.button6);
            this.panel3.Controls.Add(this.button4);
            this.panel3.Controls.Add(this.button3);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Location = new System.Drawing.Point(14, 371);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1009, 278);
            this.panel3.TabIndex = 15;
            // 
            // chosen_time
            // 
            this.chosen_time.AutoSize = true;
            this.chosen_time.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chosen_time.Location = new System.Drawing.Point(667, 58);
            this.chosen_time.Name = "chosen_time";
            this.chosen_time.Size = new System.Drawing.Size(183, 27);
            this.chosen_time.TabIndex = 14;
            this.chosen_time.Text = "선택한 시간 : ";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.price.Location = new System.Drawing.Point(667, 104);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(129, 27);
            this.price.TabIndex = 19;
            this.price.Text = "총 금액 : ";
            // 
            // cash_button
            // 
            this.cash_button.BackColor = System.Drawing.Color.White;
            this.cash_button.Location = new System.Drawing.Point(735, 145);
            this.cash_button.Name = "cash_button";
            this.cash_button.Size = new System.Drawing.Size(75, 38);
            this.cash_button.TabIndex = 18;
            this.cash_button.Text = "현금";
            this.cash_button.UseVisualStyleBackColor = false;
            this.cash_button.Click += new System.EventHandler(this.cash_button_Click);
            // 
            // card_button
            // 
            this.card_button.BackColor = System.Drawing.Color.Transparent;
            this.card_button.Location = new System.Drawing.Point(654, 145);
            this.card_button.Name = "card_button";
            this.card_button.Size = new System.Drawing.Size(75, 38);
            this.card_button.TabIndex = 17;
            this.card_button.Text = "카드";
            this.card_button.UseVisualStyleBackColor = false;
            this.card_button.Click += new System.EventHandler(this.card_button_Click);
            // 
            // car_1st
            // 
            this.car_1st.Location = new System.Drawing.Point(32, 16);
            this.car_1st.Name = "car_1st";
            this.car_1st.Size = new System.Drawing.Size(284, 38);
            this.car_1st.TabIndex = 16;
            this.car_1st.Text = "1호차";
            this.car_1st.UseVisualStyleBackColor = true;
            this.car_1st.Click += new System.EventHandler(this.car_1st_Click);
            // 
            // car_2st
            // 
            this.car_2st.BackColor = System.Drawing.Color.White;
            this.car_2st.Location = new System.Drawing.Point(322, 16);
            this.car_2st.Name = "car_2st";
            this.car_2st.Size = new System.Drawing.Size(284, 38);
            this.car_2st.TabIndex = 15;
            this.car_2st.Text = "2호차";
            this.car_2st.UseVisualStyleBackColor = false;
            this.car_2st.Click += new System.EventHandler(this.car_2st_Click);
            // 
            // chosen_seat
            // 
            this.chosen_seat.AutoSize = true;
            this.chosen_seat.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chosen_seat.Location = new System.Drawing.Point(649, 241);
            this.chosen_seat.Name = "chosen_seat";
            this.chosen_seat.Size = new System.Drawing.Size(174, 27);
            this.chosen_seat.TabIndex = 14;
            this.chosen_seat.Text = "선택한 좌석 :";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button5.Location = new System.Drawing.Point(433, 58);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 100);
            this.button5.TabIndex = 10;
            this.button5.Text = "5번 좌석";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // last_seat_label
            // 
            this.last_seat_label.AutoSize = true;
            this.last_seat_label.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.last_seat_label.Location = new System.Drawing.Point(649, 197);
            this.last_seat_label.Name = "last_seat_label";
            this.last_seat_label.Size = new System.Drawing.Size(147, 27);
            this.last_seat_label.TabIndex = 13;
            this.last_seat_label.Text = "잔여좌석 : ";
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button6.Location = new System.Drawing.Point(433, 165);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 100);
            this.button6.TabIndex = 11;
            this.button6.Text = "6번 좌석";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button4.Location = new System.Drawing.Point(221, 165);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 100);
            this.button4.TabIndex = 9;
            this.button4.Text = "4번 좌석";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.MouseCaptureChanged += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Location = new System.Drawing.Point(221, 58);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 100);
            this.button3.TabIndex = 8;
            this.button3.Text = "3번 좌석";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(12, 59);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 6;
            this.button1.Text = "1번 좌석";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Location = new System.Drawing.Point(12, 165);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 100);
            this.button2.TabIndex = 7;
            this.button2.Text = "2번 좌석";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(18, 308);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 27);
            this.label4.TabIndex = 12;
            this.label4.Text = "도착시간";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(18, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 27);
            this.label3.TabIndex = 11;
            this.label3.Text = "출발시간";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // Data2
            // 
            this.Data2.AllowUserToAddRows = false;
            this.Data2.AllowUserToDeleteRows = false;
            this.Data2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Data2.ColumnHeadersHeight = 29;
            this.Data2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Data2.Location = new System.Drawing.Point(156, 270);
            this.Data2.Name = "Data2";
            this.Data2.RowHeadersWidth = 51;
            this.Data2.RowTemplate.Height = 23;
            this.Data2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data2.Size = new System.Drawing.Size(1038, 99);
            this.Data2.TabIndex = 10;
            // 
            // confirm_button
            // 
            this.confirm_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirm_button.BackgroundImage")));
            this.confirm_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.confirm_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirm_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirm_button.Location = new System.Drawing.Point(1033, 581);
            this.confirm_button.Name = "confirm_button";
            this.confirm_button.Size = new System.Drawing.Size(165, 68);
            this.confirm_button.TabIndex = 8;
            this.confirm_button.Text = "예약";
            this.confirm_button.UseVisualStyleBackColor = true;
            this.confirm_button.Click += new System.EventHandler(this.confirm_button_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.sel_date);
            this.panel2.Controls.Add(this.reset_button);
            this.panel2.Controls.Add(this.search_button);
            this.panel2.Controls.Add(this.end_comboBox);
            this.panel2.Controls.Add(this.start_comboBox);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(14, 79);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1180, 87);
            this.panel2.TabIndex = 9;
            // 
            // sel_date
            // 
            this.sel_date.Location = new System.Drawing.Point(45, 8);
            this.sel_date.Name = "sel_date";
            this.sel_date.Size = new System.Drawing.Size(200, 21);
            this.sel_date.TabIndex = 10;
            this.sel_date.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // reset_button
            // 
            this.reset_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reset_button.BackgroundImage")));
            this.reset_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reset_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reset_button.Location = new System.Drawing.Point(794, 8);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(165, 68);
            this.reset_button.TabIndex = 8;
            this.reset_button.Text = "초기화";
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // search_button
            // 
            this.search_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("search_button.BackgroundImage")));
            this.search_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_button.Font = new System.Drawing.Font("Bahnschrift Condensed", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_button.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.search_button.Location = new System.Drawing.Point(965, 8);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(165, 68);
            this.search_button.TabIndex = 7;
            this.search_button.Text = "검색";
            this.search_button.UseVisualStyleBackColor = true;
            this.search_button.Click += new System.EventHandler(this.search_button_Click);
            // 
            // end_comboBox
            // 
            this.end_comboBox.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.end_comboBox.FormattingEnabled = true;
            this.end_comboBox.Items.AddRange(new object[] {
            "부산",
            "대구",
            "대전",
            "천안",
            "서울"});
            this.end_comboBox.Location = new System.Drawing.Point(547, 43);
            this.end_comboBox.Name = "end_comboBox";
            this.end_comboBox.Size = new System.Drawing.Size(210, 26);
            this.end_comboBox.TabIndex = 6;
            // 
            // start_comboBox
            // 
            this.start_comboBox.Font = new System.Drawing.Font("굴림", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.start_comboBox.FormattingEnabled = true;
            this.start_comboBox.Items.AddRange(new object[] {
            "서울",
            "천안",
            "대전",
            "대구",
            "부산"});
            this.start_comboBox.Location = new System.Drawing.Point(295, 43);
            this.start_comboBox.Name = "start_comboBox";
            this.start_comboBox.Size = new System.Drawing.Size(210, 26);
            this.start_comboBox.TabIndex = 5;
            this.start_comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(594, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 27);
            this.label2.TabIndex = 4;
            this.label2.Text = "도착역";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(344, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 27);
            this.label1.TabIndex = 3;
            this.label1.Text = "출발역";
            // 
            // Data
            // 
            this.Data.AllowUserToAddRows = false;
            this.Data.AllowUserToDeleteRows = false;
            this.Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Data.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.Data.ColumnHeadersHeight = 29;
            this.Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.Data.Location = new System.Drawing.Point(156, 168);
            this.Data.Name = "Data";
            this.Data.RowHeadersWidth = 51;
            this.Data.RowTemplate.Height = 23;
            this.Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data.Size = new System.Drawing.Size(1038, 99);
            this.Data.TabIndex = 8;
            this.Data.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellContentClick);
            this.Data.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Data_CellContentClick_1);
            this.Data.Enter += new System.EventHandler(this.data_Enter);
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
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // src_reserv_form
            // 
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "src_reserv_form";
            this.Load += new System.EventHandler(this.serviceform_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Data2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
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
        private System.Windows.Forms.DataGridView Data;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox start_comboBox;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.Button confirm_button;
        private System.Windows.Forms.Button reset_button;
        private System.Windows.Forms.ComboBox end_comboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker sel_date;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView Data2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label chosen_time;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label last_seat_label;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label chosen_seat;
        private System.Windows.Forms.Button car_1st;
        private System.Windows.Forms.Button car_2st;
        private System.Windows.Forms.Button cash_button;
        private System.Windows.Forms.Button card_button;
        private System.Windows.Forms.Label price;
    }
}
