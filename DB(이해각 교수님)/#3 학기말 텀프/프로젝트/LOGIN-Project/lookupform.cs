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
    public partial class lookupform : Form
    {

        public lookupform()
        {

            this.MinimumSize = new Size(1280, 720); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(1280, 720);
            InitializeComponent();
            reset_data();
            label1.Text = loginform.Login_ID + " 고객님의 예매 내역입니다.";
        }
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=1234;User ID=student"; //oracle 서버 연결


        public void reset_data()
        {
            conn = new OleDbConnection(connectionString);
            conn.Open();
            DataSet dt_train = new DataSet("등급");
            OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter("Select * From 배정좌석 WHERE 회원번호 = '" + loginform.Login_ID + "'", conn);
            m_daDataAdapter.Fill(dt_train);
            Data.DataSource = dt_train.Tables[0];
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

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void approve_button_Click(object sender, EventArgs e)
        {
            DataGridViewRow chosen = Data.SelectedRows[0];
            string[] Information = new string[20];

            for (int i = 0; i < 14; i++)
            {
                Information[i] = chosen.Cells[i].Value.ToString();
            }

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from 배정좌석 where 방향 = '" + Information[3] + "' and 차량번호 = '" + Information[5] + "' and 좌석번호 = '" + Information[6] + "' and 회원번호 = '" + loginform.Login_ID + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                MessageBox.Show(Information[8] + " 예매 취소 완료");
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
            DataGridViewRow chosen = Data.SelectedRows[0];
            string[] Information = new string[20];

            for (int i = 0; i < 14; i++)
            {
                Information[i] = chosen.Cells[i].Value.ToString();
            }

            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from 배정좌석 where 방향 = '" + Information[3] + "' and 차량번호 = '" + Information[5] + "' and 좌석번호 = '" + Information[6] + "' and 회원번호 = '" + loginform.Login_ID + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                if (conn != null)
                {
                    conn.Close(); //데이터베이스 연결 해제
                    reset_data();
                }
                // 사용자의 수정사항대로 다시 삽입, 실패하면 롤백해야함(information을 살려놓고 실패시 다시 insert 하던가 해야함)

                MessageBox.Show("대체할 예매일자를 선택하세요");

                Form src_reserv_form = new src_reserv_form();
                this.AddOwnedForm(src_reserv_form);
                src_reserv_form.Show();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }

        }
    }
}