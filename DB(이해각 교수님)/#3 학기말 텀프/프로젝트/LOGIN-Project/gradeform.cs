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
    public partial class gradeform : Form
    {

        public gradeform()
        {

            this.MinimumSize = new Size(1280, 720); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(1280, 720);
            InitializeComponent();
            reset_data();
        }
        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=1234;User ID=student"; //oracle 서버 연결


        public void reset_data()
        {
            conn = new OleDbConnection(connectionString);
            conn.Open();
            DataSet dt_train = new DataSet("등급");
            OleDbDataAdapter m_daDataAdapter = new OleDbDataAdapter("Select 회원번호, 회원이름, 휴대전화, 카드번호, 등급 From 회원 WHERE 등급 IS NULL and not 회원이름 = '관리자'", conn);
            m_daDataAdapter.Fill(dt_train);
            Data.DataSource = dt_train.Tables[0];


            DataSet dt_train2 = new DataSet("등급");
            OleDbDataAdapter m_daDataAdapter2 = new OleDbDataAdapter("Select 회원번호, 회원이름, 휴대전화, 카드번호, 등급 From 회원 WHERE 등급 = '가입승인'", conn);
            m_daDataAdapter2.Fill(dt_train2);
            Data2.DataSource = dt_train2.Tables[0];
            conn.Close();

            DataSet dt_train3 = new DataSet("등급");
            OleDbDataAdapter m_daDataAdapter3 = new OleDbDataAdapter("Select 회원번호, 회원이름, 휴대전화, 카드번호, 등급 From 회원 where (등급 is not null) and (not 등급 = '가입승인')", conn);
            m_daDataAdapter3.Fill(dt_train3);
            Data3.DataSource = dt_train3.Tables[0];
            conn.Close();

            assign_combo.Text = "";
            assign_combo2.Text = "";
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
            string approve_id = chosen.Cells[0].Value.ToString();


            conn = new OleDbConnection(connectionString);
            try
            {
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "update 회원 set 등급 = '" + "가입승인" + "' where 회원번호 = '" + approve_id + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                MessageBox.Show(approve_id + " 가입 승인 완료");
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

        private void assign_button_Click(object sender, EventArgs e)
        {
            if (assign_combo.Text != "")
            {
                DataGridViewRow chosen = Data2.SelectedRows[0];
                string approve_id = chosen.Cells[0].Value.ToString();


                conn = new OleDbConnection(connectionString);
                try
                {
                    conn.Open(); //데이터베이스 연결
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "update 회원 set 등급 = '" + assign_combo.Text + "' where 회원번호 = '" + approve_id + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                    MessageBox.Show(approve_id + "회원 " + assign_combo.Text + " 등급 배정 완료");
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
            else
            {
                MessageBox.Show("등급을 지정하세요");
            }
        }

        private void modify_button_Click(object sender, EventArgs e)
        {
            if (assign_combo2.Text != "")
            {
                DataGridViewRow chosen = Data3.SelectedRows[0];
                string approve_id = chosen.Cells[0].Value.ToString();


                conn = new OleDbConnection(connectionString);
                try
                {
                    conn.Open(); //데이터베이스 연결
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "update 회원 set 등급 = '" + assign_combo2.Text + "' where 회원번호 = '" + approve_id + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                    MessageBox.Show(approve_id + "회원 " + assign_combo2.Text + " 등급 배정 완료");
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
            else
            {
                MessageBox.Show("등급을 지정하세요");
            }
        }
    }
}