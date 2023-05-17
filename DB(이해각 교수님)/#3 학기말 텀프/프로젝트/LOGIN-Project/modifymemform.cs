using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;

namespace LOGIN
{
    public partial class modifymemform : Form
    {
        string connectionString = "Provider=MSDAORA;Password=1234;User ID=student"; //oracle 서버 연결
        public modifymemform()
        {
            InitializeComponent();
            this.MinimumSize = new Size(480, 560); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(480, 560);
            this.ActiveControl = panel1; // 포커스 초기화
            conn = new OleDbConnection(connectionString);
            get_info();
        }

        OleDbConnection conn;
        
        int id_check_clicked = 0;
        int name_check_clicked = 0;
        int phone_check_clicked = 0;
        int card_check_clicked = 0;
        string[] Information = new string[20];


        public void get_info()
        {
            conn.Open(); //데이터베이스 연결
            OleDbCommand cmd = new OleDbCommand();
            cmd.CommandText = "select * from 회원 where 회원번호 ='" + loginform.Login_ID + "'";
            cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
            cmd.Connection = conn;

            OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과

            if (!(read.Read()))
            {
            }
            else
            {
                for(int i = 0;i < 6; i++) 
                {
                    Information[i] = read.GetValue(i).ToString();
                }
                id_textbox.Text = Information[0];
                name_textbox.Text = Information[1];
                phone_textbox.Text = Information[2];
                card_textbox.Text = Information[4];
                id_textbox.ForeColor = Color.LightGray;
                name_textbox.ForeColor = Color.LightGray;
                phone_textbox.ForeColor = Color.LightGray;
                card_textbox.ForeColor = Color.LightGray;
            }
            conn.Close();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            this.ActiveControl = panel1;
            id_textbox.Text = Information[0];
            name_textbox.Text = Information[1];
            phone_textbox.Text = Information[2];
            card_textbox.Text = Information[4];

            id_check_clicked = 0;
            name_check_clicked = 0;
            phone_check_clicked = 0;
            card_check_clicked = 0;

            id_textbox.ForeColor = Color.LightGray;
            name_textbox.ForeColor = Color.LightGray;
            phone_textbox.ForeColor = Color.LightGray;
            card_textbox.ForeColor = Color.LightGray;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
     
        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }
        private void card_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || e.KeyChar == Convert.ToChar(Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            if (id_textbox.Text.Length < 6)
            {
                MessageBox.Show("이름을 입력해주세요");
                name_textbox.ResetText();
                this.ActiveControl = name_textbox;
                return;
            }
            else if (name_textbox.Text.Length < 1)
            {
                MessageBox.Show("이름을 입력해주세요");
                name_textbox.ResetText();
                this.ActiveControl = name_textbox;
                return;
            }
            else if (phone_textbox.Text.Length < 1)
            {
                MessageBox.Show("전화번호를 입력해주세요");
                phone_textbox.ResetText();
                this.ActiveControl = phone_textbox;
                return;
            }
            else if (card_textbox.Text.Length < 1)
            {
                MessageBox.Show("카드번호를 입력해주세요");
                card_textbox.ResetText();
                this.ActiveControl = card_textbox;
                return;
            }
            else
            {
                conn = new OleDbConnection(connectionString);
                try
                {
                    conn.Open(); //데이터베이스 연결
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "update 회원 set 회원번호 = '" + id_textbox.Text + "', 회원이름 = '" + name_textbox.Text + "', 휴대전화 = '" + phone_textbox.Text + "', 카드번호 = '" + card_textbox.Text + "' where 회원번호 = '" + id_textbox.Text + "'";

                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                    MessageBox.Show("회원정보 수정 완료");

                    conn.Close();

                    get_info();
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
                    }
                }
                conn.Close();
            }
            
        }











        private void id_textbox_Enter(object sender, EventArgs e)
        {
            id_check_clicked++;
            if (id_check_clicked == 1)
            {
                id_textbox.ForeColor = Color.Black;
            }
        }
        private void name_textbox_Enter(object sender, EventArgs e)
        {
            name_check_clicked++;
            if (name_check_clicked == 1)
            {
                name_textbox.ForeColor = Color.Black;
            }
        }
        private void phone_textbox_Enter(object sender, EventArgs e)
        {
            phone_check_clicked++;
            if (phone_check_clicked == 1)
            {
                phone_textbox.ForeColor = Color.Black;
            }
        }
        private void card_textbox_Enter(object sender, EventArgs e)
        {
            card_check_clicked++;
            if (card_check_clicked == 1)
            {
                card_textbox.ForeColor = Color.Black;
            }
        }







        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void withdraw_button_Click(object sender, EventArgs e)
        {
            var confirmResult = MessageBox.Show("탈퇴한 후에는 되돌릴 수 없습니다. 탈퇴하시겠습니까 ?",
            "회원탈퇴 완료", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                try { 
                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "delete from 회원 where 회원번호 = '" + id_textbox.Text + "'";

                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                MessageBox.Show("회원 탈퇴 완료");

                conn.Close();
                this.Close();
                }
                catch
                {
                    MessageBox.Show("예약된 좌석이 존재합니다. 예약을 취소한 후 다시 시도하세요.");
                }
            }
            else
            {
            }
        }
    }
}



