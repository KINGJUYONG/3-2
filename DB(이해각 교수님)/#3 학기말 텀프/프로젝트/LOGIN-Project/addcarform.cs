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
    public partial class addcarform : Form
    {

        public addcarform()
        {

            this.MinimumSize = new Size(1280, 720); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(1280, 720);
            InitializeComponent();
            reset_data();
        }
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=1234;User ID=student"; //oracle 서버 연결
        string train_grade, train_dir, addtrainnum, schedule_date;
        int train_num;

        public void reset_data()
        {
            conn = new OleDbConnection(connectionString);
            conn.Open();


            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select coalesce(max(to_number(열차번호)), 0) as max_num from 열차";
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = conn;
            OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과
            if (!(read.Read()))
            {
            }
            else
            {
                string train_ind = read.GetValue(0).ToString();
                train_num = Convert.ToInt32(train_ind) + 1;
                trainnum_label.Text = "삽입할 열차 번호 : " + train_num.ToString();
            }
            read.Close();

            DataSet dt_train = new DataSet("열차");
            OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter("SELECT * FROM 열차 ORDER BY coalesce(to_number(열차번호), 0)", conn);
            m_daDataAdapter.Fill(dt_train);
            Data.DataSource = dt_train.Tables[0];

            DataSet dt_train2 = new DataSet("등급");
            OleDbDataAdapter m_daDataAdapter2 = new OleDbDataAdapter("SELECT * FROM 운행시간표 ORDER BY 시간", conn);
            m_daDataAdapter2.Fill(dt_train2);
            Data2.DataSource = dt_train2.Tables[0];
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
            reset_data();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void approve_button_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "INSERT INTO 열차 VALUES('" + train_num + "', '" + train_grade + "')";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                MessageBox.Show(train_num + " 열차 추가 완료");

                try
                {
                    int nomean = 0;
                    if(train_grade == "SM")
                    {
                        nomean = 4;
                    }
                    else if (train_grade == "MG")
                    {
                        nomean = 6;
                    }

                    for (int i = 1; i < 3; i++)
                    {
                        for (int k = 1; k < nomean + 1; k++)
                        {
                            OleDbCommand addseat = new OleDbCommand();

                            addseat.CommandText = "INSERT INTO 열차좌석 VALUES('" + train_num + "', '" + i + "', '" + k + "')";
                            addseat.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                            addseat.Connection = conn;

                            addseat.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                        }
                    }
                    MessageBox.Show(train_num + "호 열차의 좌석도 자동 생성되었습니다.");

                }
                catch
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
            finally
            {
                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                    reset_data();
                }
            }
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            //  addtrainnum   train_dir     schedule_date
            schedule_date = train_date.Value.ToString("yyyy/MM/dd");
            string[] stn = { "서울", "천안", "대전", "대구", "부산" };
            string[] times = { "13:00:00", "14:00:00", "15:00:00", "16:00:00", "17:00:00" };
            conn = new OleDbConnection(connectionString);
            conn.Open();
            if (train_dir == "하행")
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        int seq = i + 1;
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "insert into 운행시간표 values(" + seq + ",'" + stn[i] + "', " + addtrainnum + ", '하행', TO_DATE('" + schedule_date + " " + times[i] + "', 'YYYY-MM-DD HH24:MI:SS'))";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;

                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                    }
                    finally
                    {
                         reset_data();
                    }
                }
                MessageBox.Show(schedule_date + "의 " + train_dir + " 배차가 완료되었습니다.");
            }
            else
            {
                for (int i = 0; i < 5; i++)
                {
                    try
                    {
                        int seq = i + 1;
                        OleDbCommand cmd = new OleDbCommand();
                        cmd.CommandText = "insert into 운행시간표 values(" + seq + ",'" + stn[4-i] + "', " + addtrainnum + ", '상행', TO_DATE('" + schedule_date + " " + times[i] + "', 'YYYY-MM-DD HH24:MI:SS'))";
                        cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                        cmd.Connection = conn;

                        cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message); //에러 메세지 
                    }
                    finally
                    {
                        reset_data();
                    }
                }
                MessageBox.Show(schedule_date + "의 " + train_dir + " 배차가 완료되었습니다.");
            }
            conn.Close();
        }
        private void mg_button_Click(object sender, EventArgs e)
        {
            train_grade = "MG";
            train_gr.Text = "열차 등급 : 무궁화호";
        }

        private void sm_button_Click(object sender, EventArgs e)
        {
            train_grade = "SM";
            train_gr.Text = "열차 등급 : 새마을호";
        }

        private void Data2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void train_date_ValueChanged(object sender, EventArgs e)
        {
            date_label.Text = "선택한 날짜 : " + train_date.Value.ToString("yyyy/MM/dd");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Data_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow chosen = Data.SelectedRows[0];
            addtrainnum = chosen.Cells[0].Value.ToString();
            trnum_label.Text = "선택한 열차 번호 : " + addtrainnum;
        }
        private void down_button_Click(object sender, EventArgs e)
        {
            train_dir = "하행";
            trdir_label.Text = "열차방향 : 하행";
        }
        private void up_button_Click(object sender, EventArgs e)
        {
            train_dir = "상행";
            trdir_label.Text = "열차방향 : 상행";
        }
    }
}

