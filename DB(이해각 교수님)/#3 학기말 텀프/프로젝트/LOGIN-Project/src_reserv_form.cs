using System;
using System.IO;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Linq.Expressions;



namespace LOGIN
{
    public partial class src_reserv_form : Form
    {
        public static int todays_num;

        public src_reserv_form()
        {

            this.MinimumSize = new Size(1280, 720); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(1280, 720);
            InitializeComponent();
            try
            {
                StreamReader sr = new StreamReader("D:\\Sample.txt");
                todays_num = int.Parse(sr.ReadLine());
                sr.Close();
            }
            catch
            {
                Console.WriteLine("시퀀스 불러오기 오류");
            }
        }



        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=1234;User ID=student"; //oracle 서버 연결\
        DataSet dt_train, dt_train2;
        string TrainNum;
        int srcnum = 0;
        string srcstr;
        int desnum = 0;
        string desstr;
        string direction = "하행";
        string[] stn = { "서울", "천안", "대전", "대구", "부산" };
        string selected_date;
        bool button1_clicked = false;
        bool button2_clicked = false;
        bool button3_clicked = false;
        bool button4_clicked = false;
        bool button5_clicked = false;
        bool button6_clicked = false;
        int car_clicked = 1;
        string price_of_train = "0";
        string train_grade;
        int src_by;
        int des_by;
        int dir_by;
        int doornot = 1;
        string resr_num;
        string dt;
        int last_seat;
        string howtopay = "card";
        string cardnum;
        int totalprice;









        public void reset_components()
        {
            start_comboBox.ResetText();
            end_comboBox.ResetText();
            sel_date.ResetText();
            last_seat_label.Text = "잔여좌석 : ";
            chosen_time.Text = "선택한 시간 : ";
            chosen_seat.Text = "선택한 좌석 : ";
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;

        }
        public void validation(object sender, EventArgs e, int num)
        {

            int button_clicked = 1;
            conn.Open(); //데이터베이스 연결
            int k = des_by + 1;
            int kk = src_by + 1;

            if (src_by > des_by)
            {

                for (int i = k; i < kk; i++)
                {

                    OleDbCommand verify = new OleDbCommand();
                    verify.CommandText = "select * from 배정좌석 where 열차번호 = '" + TrainNum + "' and 차량번호 =  '" + car_clicked + "' and 좌석번호 = " + num + " and 출발역 = '" + stn[i] + "'and  방향 = '" + direction + "' AND 시간 = TO_DATE('" + selected_date + " " + dt + "', 'YYYY-MM-DD HH24:MI:SS')";
                    verify.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    verify.Connection = conn;
                    OleDbDataReader reader_verify = verify.ExecuteReader(); //select 회원ID from 회원 결과

                    if (reader_verify.Read())
                    {
                        MessageBox.Show("중복된 경로가 존재하여 예약할 수 없습니다.");
                        doornot = 0;
                    }
                    else
                    {
                    }
                }
            }
            else
            {

                for (int i = kk; i < k; i++)
                {

                    OleDbCommand verify = new OleDbCommand();
                    verify.CommandText = "select * from 배정좌석 where 열차번호 = '" + TrainNum + "' and 차량번호 =  '" + car_clicked + "' and 좌석번호 = " + num + " and 출발역 = '" + stn[i] + "'and  방향 = '" + direction + "' AND 시간 = TO_DATE('" + selected_date + " " + dt + "', 'YYYY-MM-DD- HH24:MI:SS')";
                    verify.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    verify.Connection = conn;

                    OleDbDataReader reader_verify = verify.ExecuteReader(); //select 회원ID from 회원 결과
                    if (reader_verify.Read())
                    {
                        MessageBox.Show("중복된 경로가 존재하여 예약할 수 없습니다.");
                        doornot = 0;
                    }
                    else
                    {
                    }
                }
            }
            if (howtopay == "cash")
            {
                cardnum = "현금";
            }
            else if(howtopay == "card")
            {
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select 카드번호 from 회원 where 회원번호 ='" + loginform.Login_ID + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과

                if (!(read.Read()))
                {
                    MessageBox.Show("오류발생");
                }
                else
                {
                    cardnum = read.GetValue(0).ToString();
                }
            }

            if (doornot == 1)
            {

                todays_num++;
                try
                {
                    StreamWriter sw = new StreamWriter("D:\\Sample.txt");
                    sw.WriteLine(todays_num);
                    sw.Close();
                }
                catch
                {
                    Console.WriteLine("시퀀스 쓰기 오류");
                }
                resr_num = TrainNum + DateTime.Now.ToString("yyyyMMdd") + todays_num;
                try
                {

                    OleDbCommand cmd = new OleDbCommand();

                    cmd.CommandText = "INSERT INTO 배정좌석 VALUES('" + srcnum + "', '" + srcstr + "', '" + TrainNum + "', '" + direction + "', TO_DATE('" + selected_date + " " + dt + "', 'YYYY-MM-DD HH24:MI:SS'), '" + car_clicked + "', '" + num + "', '" + loginform.Login_ID + "', '" + resr_num + "', '" + srcstr + "', '" + desstr + "', '" + DateTime.Now.ToString("yyyy-MM-dd") + "', '" + price_of_train + "', '" + cardnum + "')";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;
                    try
                    {
                        cmd.ExecuteNonQuery();
                        MessageBox.Show(num + "번 좌석 예매 성공 !");
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("예약 실패. 다시 시도해주세요. error_code:2");
                        MessageBox.Show("Error : " + ex.Message); //에러 메세지 
                    }
                }
                catch
                {
                    MessageBox.Show("예약 실패. 다시 시도해주세요. error_code:3");
                }


            }
            conn.Close();
            button_visible();

        }


        private void exit_button_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch
            {
                this.Close();
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            reset_components();
        }
        private void reset_button_Click(object sender, EventArgs e)
        {
            reset_components();

        }
        private void search_button_Click(object sender, EventArgs e)
        {
            srcnum = 0;
            desnum = 0;
            desstr = "";
            srcstr = "";
            direction = "하행";
            dt_train = new DataSet("요금표");
            dt_train2 = new DataSet("요금표");
            string desindex;

            conn = new OleDbConnection(connectionString);
            conn.Open(); //데이터베이스 연결
            if(!(start_comboBox.Text.ToString() == "") && !(end_comboBox.Text.ToString() == "") && !(start_comboBox.Text == end_comboBox.Text))
            {

                for (int i = 0; i < 5; i++)
                {
                    if (start_comboBox.Text.ToString() == stn[i])
                    {
                        src_by = i;
                        srcnum = i + 1;
                        srcstr = stn[i];
                    }
                    else if (end_comboBox.Text.ToString() == stn[i])
                    {
                        des_by = i;
                        desnum = i + 1;
                        desstr = stn[i];
                    }
                }
                if (srcnum > desnum)
                {
                    direction = "상행";
                    srcnum = 6 - srcnum;
                    desnum = 6 - desnum;
                }

                

                selected_date = Regex.Replace(sel_date.Text, @"[^0-9]", "");

                OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter("Select * From 운행시간표 where 방향 = '" + direction + "' and (역이름 = '" + srcstr + "') AND (시간 BETWEEN TO_DATE('" + selected_date + "00:00:00', 'YYYYMMDD HH24:MI:SS') AND TO_DATE('" + selected_date + "23:59:59', 'YYYYMMDD HH24:MI:SS')) order by 열차번호", conn);
                m_daDataAdapter.Fill(dt_train);
                Data.DataSource = dt_train.Tables[0];

                OleDbDataAdapter m_daDataAdapter2 = new OleDbDataAdapter("Select * From 운행시간표 where 방향 = '" + direction + "' and (역이름 = '" + desstr + "')AND (시간 BETWEEN TO_DATE('" + selected_date + "00:00:00', 'YYYYMMDD HH24:MI:SS') AND TO_DATE('" + selected_date + "23:59:59', 'YYYYMMDD HH24:MI:SS')) order by 열차번호", conn);
                m_daDataAdapter2.Fill(dt_train2);
                Data2.DataSource = dt_train2.Tables[0];

                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "Select * From 운행시간표 where 방향 = '" + direction + "' and (역이름 = '" + srcstr + "') AND (시간 BETWEEN TO_DATE('" + selected_date + "00:00:00', 'YYYYMMDD HH24:MI:SS') AND TO_DATE('" + selected_date + "23:59:59', 'YYYYMMDD HH24:MI:SS'))";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;
                OleDbDataReader read = cmd.ExecuteReader();
                if (read.Read() == false)
                {
                    MessageBox.Show("연결 실패");
                }
                else
                {

                    OleDbCommand train_gr = new OleDbCommand();
                    train_gr.CommandText = "select 열차등급 from 열차 where 열차번호 = '" + read.GetValue(2).ToString() + "'";
                    train_gr.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    train_gr.Connection = conn;
                    OleDbDataReader train_read = train_gr.ExecuteReader();
                    if (train_read.Read() == false)
                    {                    
                    }
                    else 
                    { 
                        TrainNum = read.GetValue(2).ToString();
                        train_grade = train_read.GetValue(0).ToString();                      
                    }
                }
                conn.Close();
                read.Close();




                conn.Open(); //데이터베이스 연결

                OleDbCommand find_price = new OleDbCommand();
                find_price.CommandText = "select 요금 from 요금표 where 출발역 = '" + srcstr + "' and 도착역 = '" + desstr + "' and 열차등급 = '" + train_grade + "'";
                find_price.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                find_price.Connection = conn;

                OleDbDataReader price = find_price.ExecuteReader(); //select 회원ID from 회원 결과


                if (!(price.Read()))
                {
                }
                else if (price.GetValue(0).ToString() != null)
                {
                    price_of_train = price.GetValue(0).ToString();
                }
                price.Close();



            }
            else if (!(start_comboBox.Text.ToString() == ""))
            {
                OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter("Select * From 운행시간표", conn);
                m_daDataAdapter.Fill(dt_train);
                Data.DataSource = dt_train.Tables[0];
            }
            else // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@ 위 elseif랑 else 개선 필요@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
            {
                OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter("Select * From 운행시간표", conn);
                m_daDataAdapter.Fill(dt_train);
                Data.DataSource = dt_train.Tables[0];
            }

            last_seat = 0;
            if (train_grade == "MG")
            {
                last_seat = 6;
                button5.Visible = true;
                button6.Visible = true;
            }
            else if (train_grade == "SM")
            {
                last_seat = 4;
                button5.Visible = false;
                button6.Visible = true;
            }
            else
            {
                MessageBox.Show("오류 발생 !");
            }

            //last_seat_label.Text = "잔여좌석 : " + last_seat;

            DataGridViewRow chosen = Data.SelectedRows[0];
            string data = chosen.Cells[4].Value.ToString();
            chosen_time.Text = "선택한 시간 : " + data;


            dt = DateTime.ParseExact(data, "yyyy-MM-dd tt h:mm:ss", null, System.Globalization.DateTimeStyles.AssumeLocal).ToString("HH:mm:ss");

            conn.Close();
            button_visible();
        }

        private void confirm_button_Click(object sender, EventArgs e)
        {
            if (!(start_comboBox.Text.ToString() == "") && !(end_comboBox.Text.ToString() == ""))
            {
                int validated1 = 0, validated2 = 0, validated3 = 0, validated4 = 0, validated5 = 0, validated6 = 0;

                for (int i = 0; i < 6; i++)
                {
                    if (button1_clicked == true && validated1 != 1) // @@@@@@@@@@@@@@@@@@@@@@@@ 1번자리 말고도 되게 바꾸기
                    {
                        validation(sender, e, 1);
                        validated1 = 1;
                    }
                    else if (button2_clicked == true && validated2 != 1)
                    {
                        validation(sender, e, 2);
                        validated2 = 1;
                    }
                    else if (button3_clicked == true && validated3 != 1)
                    {
                        validation(sender, e, 3);
                        validated3 = 1;
                    }
                    else if (button4_clicked == true && validated4 != 1)
                    {
                        validation(sender, e, 4);
                        validated4 = 1;
                    }
                    else if (button5_clicked == true && validated5 != 1)
                    {
                        validation(sender, e, 5);
                        validated5 = 1;
                    }
                    else if (button6_clicked == true && validated6 != 1)
                    {
                        validation(sender, e, 6);
                        validated6 = 1;
                    }

                }
                conn.Close();

                button1_clicked = false; button2_clicked = false; button3_clicked = false; button4_clicked = false; button4_clicked = false; button6_clicked = false;
                button1.BackColor = Color.White; button2.BackColor = Color.White; button3.BackColor = Color.White; button4.BackColor = Color.White; button5.BackColor = Color.White; button6.BackColor = Color.White;
            }
        }
        public void get_total_price()
        {
            bool checked01 = false; bool checked02 = false; bool checked03 = false; bool checked04 = false; bool checked05 = false; bool checked06 = false;
            totalprice = 0;
            int priceindex = 0;
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select 요금 from 요금표 where 출발역 ='" + srcstr + "' and 도착역 = '" + desstr + "' and 열차등급 = '" + train_grade  + "'";
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과

            if (!(read.Read()))
            {
                MessageBox.Show("오류발생");
            }
            else
            {
                priceindex = int.Parse(read.GetValue(0).ToString());
                        // @@@@@@@@@@@@@@@@@@@@@@@ 요금 int때매 문제ㅐ발생함 고쳐야해여기
            }
        



            for (int i = 0; i < 6; i++)
            {
                if (button1_clicked && checked01 != true)
                {
                    totalprice += priceindex;
                    checked01 = true;
                }
                else if (button2_clicked && checked02 != true)
                {
                    totalprice += priceindex;
                    checked02 = true;
                }
                else if (button3_clicked && checked03 != true)
                {
                    totalprice += priceindex;
                    checked03 = true;
                }
                else if (button4_clicked && checked04 != true)
                {
                    totalprice += priceindex;
                    checked04 = true;
                }
                else if (button5_clicked && checked05 != true)
                {
                    totalprice += priceindex;
                    checked05 = true;
                }
                else if (button6_clicked && checked06 != true)
                {
                    totalprice += priceindex;
                    checked06 = true;
                }
            }
            price.Text = ("총 금액 : " + totalprice);
            conn.Close();
            set_chosen_seat();
        }

        public void set_chosen_seat()
        {
            bool validated1 = false; bool validated2 = false; bool validated3 = false; bool validated4 = false; bool validated5 = false; bool validated6 = false;
            chosen_seat.Text = "선택된 좌석 : ";
            for (int i = 0; i < 6; i++)
            {
                if (button1.Visible == true && button1.BackColor == Color.Gray && validated1 != true) // @@@@@@@@@@@@@@@@@@@@@@@@ 1번자리 말고도 되게 바꾸기
                {
                    chosen_seat.Text = chosen_seat.Text + "1번 ";
                    validated1 = true;
                }
                else if (button2.Visible == true && button2.BackColor == Color.Gray && validated2 != true)
                {
                    chosen_seat.Text = chosen_seat.Text + "2번 ";
                    validated2 = true;
                }
                else if (button3.Visible == true && button3.BackColor == Color.Gray && validated3 != true)
                {
                    chosen_seat.Text = chosen_seat.Text + "3번 ";
                    validated3 = true;
                }
                else if (button4.Visible == true && button4.BackColor == Color.Gray && validated4 != true)
                {
                    chosen_seat.Text = chosen_seat.Text + "4번 ";
                    validated4 = true;
                }
                else if (button5.Visible == true && button5.BackColor == Color.Gray && validated5 != true)
                {
                    chosen_seat.Text = chosen_seat.Text + "5번 ";
                    validated5 = true;
                }
                else if (button6.Visible == true && button6.BackColor == Color.Gray && validated6 != true)
                {
                    chosen_seat.Text = chosen_seat.Text + "6번 ";
                    validated6 = true;
                }

            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (!button1_clicked)
            {
                button1_clicked = true;
                button1.BackColor = Color.Gray;
                chosen_seat.Text = (chosen_seat.Text + "1번 ");
            }
            else
            {
                button1_clicked = false;
                button1.BackColor = Color.White;
            }
            get_total_price();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (!button2_clicked)
            {
                button2_clicked = true;
                button2.BackColor = Color.Gray;
                chosen_seat.Text = (chosen_seat.Text + "2번 ");
            }
            else
            {
                button2_clicked = false;
                button2.BackColor = Color.White;
            }
            get_total_price();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (!button3_clicked)
            {

                button3_clicked = true;
                button3.BackColor = Color.Gray;
                chosen_seat.Text = (chosen_seat.Text + "3번 ");
            }
            else
            {
                button3_clicked = false;
                button3.BackColor = Color.White;
            }
            get_total_price();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            if (!button4_clicked)
            {
                button4_clicked = true;
                button4.BackColor = Color.Gray;
                chosen_seat.Text = (chosen_seat.Text + "4번 ");
            }
            else
            {
                button4_clicked = false;
                button4.BackColor = Color.White;
            }
            get_total_price();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            if (!button5_clicked)
            {

                button5_clicked = true;
                button5.BackColor = Color.Gray;
                chosen_seat.Text = (chosen_seat.Text + "5번 ");
            }
            else
            {
                button5_clicked = false;
                button5.BackColor = Color.White;
            }
            get_total_price();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (!button6_clicked)
            {
                button6_clicked = true;
                button6.BackColor = Color.Gray;
                chosen_seat.Text = (chosen_seat.Text + "6번 ");
            }
            else
            {
                button6_clicked = false;
                button6.BackColor = Color.White;
            }
            get_total_price();
        }
        private void car_1st_Click(object sender, EventArgs e)
        {
            car_clicked = 1;
            car_1st.BackColor = Color.Gray;
            car_2st.BackColor = Color.White;
            button5.Visible = false;
            button6.Visible = false;
            button_visible();
        }

        private void car_2st_Click(object sender, EventArgs e)
        {
            car_clicked = 2;
            car_2st.BackColor = Color.Gray;
            car_1st.BackColor = Color.White;
            button_visible();
        }
        private void card_button_Click(object sender, EventArgs e)
        {
            howtopay = "card";
            card_button.BackColor = Color.Transparent;
            cash_button.BackColor = Color.White;
        }
        private void cash_button_Click(object sender, EventArgs e)
        {
            howtopay = "cash";
            card_button.BackColor = Color.White;
            cash_button.BackColor = Color.Transparent;
        }



        public int count_visible()
        {
            bool howvisi1 = false; bool howvisi2 = false; bool howvisi3 = false; bool howvisi4 = false; bool howvisi5 = false; bool howvisi6 = false;
            int howmuch = 0;
            for (int asas = 0; asas < 6; asas++)
            {
                if (button1.Visible == true && howvisi1 == false) 
                {
                    howmuch++;
                    howvisi1 = true;
                }
                else if (button2.Visible == true && howvisi2 == false)
                {
                    howmuch++;
                    howvisi2 = true;
                }
                else if (button3.Visible == true && howvisi3 == false)
                {
                    howmuch++;
                    howvisi3 = true;
                }
                else if (button4.Visible == true && howvisi4 == false)
                {
                    howmuch++;
                    howvisi4 = true;
                }
                else if (button5.Visible == true && howvisi5 == false)
                {
                    howmuch++;
                    howvisi5 = true;
                }
                else if (button6.Visible == true && howvisi6 == false)
                {
                    howmuch++;
                    howvisi6 = true;
                }
            }
            return howmuch;
        }


        public void button_visible()
        {
            last_seat = 4;
            if(train_grade == "MG")
            {
                button5.Visible = true;
                button6.Visible = true;
                last_seat = 6;
            }
            else
            {
                button5.Visible = false;
                button6.Visible = false;
                last_seat = 4;
            }
            button1.Visible = true; button2.Visible = true; button3.Visible = true; button4.Visible = true;
            bool seat_chk1 = false; bool seat_chk2 = false; bool seat_chk3 = false; bool seat_chk4 = false; bool seat_chk5 = false; bool seat_chk6 = false;
            int countind = 0;


            int forrooplast = last_seat;
            for (int i = 1; i < forrooplast + 1; i++)
            {
                try
                {
                    conn.Open(); //데이터베이스 연결
                }
                catch{ }
                int k = des_by;
                int kk = src_by;

                if (src_by > des_by)
                {
                    for (int s = k ; s < kk; s++)
                    {
                        OleDbCommand verify = new OleDbCommand();
                        verify.CommandText = "select * from 배정좌석 where 열차번호 = '" + TrainNum + "' and 차량번호 =  '" + car_clicked + "' and 좌석번호 = " + i + " and 도착역 = '" + stn[s] + "'and  방향 = '" + direction + "' AND (시간 BETWEEN TO_DATE('" + selected_date + "00:00:00', 'YYYYMMDD HH24:MI:SS') AND TO_DATE('" + selected_date + "23:59:59', 'YYYYMMDD HH24:MI:SS'))";
                        verify.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        verify.Connection = conn;
                        OleDbDataReader reader_verify = verify.ExecuteReader(); //select 회원ID from 회원 결과

                        if (reader_verify.Read())
                        {
                            if (i == 1)
                            {
                                button1.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 2)
                            {
                                button2.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 3)
                            {
                                button3.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 4)
                            {
                                button4.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 5)
                            {
                                button5.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 6)
                            {
                                button6.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                        }
                        else
                        {
                        }
                    }
                    for (int s = k + 1; s < kk + 1; s++)
                    {
                        OleDbCommand verify = new OleDbCommand();
                        verify.CommandText = "select * from 배정좌석 where 열차번호 = '" + TrainNum + "' and 차량번호 =  '" + car_clicked + "' and 좌석번호 = " + i + " and 출발역 = '" + stn[s] + "'and  방향 = '" + direction + "' AND (시간 BETWEEN TO_DATE('" + selected_date + "00:00:00', 'YYYYMMDD HH24:MI:SS') AND TO_DATE('" + selected_date + "23:59:59', 'YYYYMMDD HH24:MI:SS'))";
                        verify.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        verify.Connection = conn;
                        OleDbDataReader reader_verify = verify.ExecuteReader(); //select 회원ID from 회원 결과

                        if (reader_verify.Read())
                        {
                            if (i == 1)
                            {
                                button1.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 2)
                            {
                                button2.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 3)
                            {
                                button3.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 4)
                            {
                                button4.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 5)
                            {
                                button5.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 6)
                            {
                                button6.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                        }
                        else
                        {
                        }
                    }
                }
                else
                {       // 하행 천안 -> 대전 -> 대구   
                        // kk 출발지 k 도착지
                    for (int s = kk; s < k; s++)
                    {
                        OleDbCommand verify = new OleDbCommand();
                        verify.CommandText = "select * from 배정좌석 where 열차번호 = '" + TrainNum + "' and 차량번호 =  '" + car_clicked + "' and 좌석번호 = " + i + " and 출발역 = '" + stn[s] + "'and  방향 = '" + direction + "' AND (시간 BETWEEN TO_DATE('" + selected_date + "00:00:00', 'YYYYMMDD HH24:MI:SS') AND TO_DATE('" + selected_date + "23:59:59', 'YYYYMMDD HH24:MI:SS'))";
                        verify.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        verify.Connection = conn;
                        OleDbDataReader reader_verify = verify.ExecuteReader(); //select 회원ID from 회원 결과

                        if (reader_verify.Read())
                        {
                            if (i == 1)
                            {
                                button1.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 2)
                            {
                                button2.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 3)
                            {
                                button3.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 4)
                            {
                                button4.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 5)
                            {
                                button5.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 6)
                            {
                                button6.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                        }
                        else
                        {
                        }
                    }
                    for (int s = kk + 1; s < k + 1; s++)
                    {
                        OleDbCommand verify = new OleDbCommand();
                        verify.CommandText = "select * from 배정좌석 where 열차번호 = '" + TrainNum + "' and 차량번호 =  '" + car_clicked + "' and 좌석번호 = " + i + " and 도착역 = '" + stn[s] + "'and  방향 = '" + direction + "' AND (시간 BETWEEN TO_DATE('" + selected_date + "00:00:00', 'YYYYMMDD HH24:MI:SS') AND TO_DATE('" + selected_date + "23:59:59', 'YYYYMMDD HH24:MI:SS'))";
                        verify.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        verify.Connection = conn;
                        OleDbDataReader reader_verify = verify.ExecuteReader(); //select 회원ID from 회원 결과

                        if (reader_verify.Read())
                        {
                            if (i == 1)
                            {
                                button1.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 2)
                            {
                                button2.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 3)
                            {
                                button3.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 4)
                            {
                                button4.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 5)
                            {
                                button5.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                            else if (i == 6)
                            {
                                button6.Visible = false;
                                countind++;
                                last_seat = last_seat - 1;
                            }
                        }
                        else
                        {
                        }
                    }
                }

                try {
                    conn.Close();
                }
                catch { }

            }

            last_seat_label.Text = ("잔여좌석 : " + count_visible().ToString());
        }








        private void data_Enter(object sender, EventArgs e)
        {

        }

        private void serviceform_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int rows = Data.CurrentCellAddress.Y;
            Data2.CurrentCell = Data2.Rows[rows].Cells[0];
        }

        private void Data_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                button_visible();
            }
            catch { }
        }
    }
}
