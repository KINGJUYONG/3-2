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
    public partial class signupform : Form
    {
        public signupform()
        {
            InitializeComponent();
            this.MinimumSize = new Size(480, 560); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(480, 560);
            this.ActiveControl = panel1; // 포커스 초기화
        }

        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=1234;User ID=student"; //oracle 서버 연결
        
        int id_check_clicked = 0;
        int pw_check_clicked = 0;
        int name_check_clicked = 0;
        int phone_check_clicked = 0;
        int card_check_clicked = 0;
        bool idcheck = false;
        bool confirmed = true;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            this.ActiveControl = panel1;
            pw_textbox.PasswordChar = '\0';
            id_textbox.ResetText();
            id_textbox.AppendText("\r\n  ID를 입력하세요");
            pw_textbox.ResetText();
            pw_textbox.AppendText("\r\n  비밀번호를 입력하세요");
            name_textbox.ResetText();
            name_textbox.AppendText("\r\n  회원이름을 입력하세요");
            phone_textbox.ResetText();
            phone_textbox.AppendText("\r\n  전화번호를 입력하세요");
            card_textbox.ResetText();
            card_textbox.AppendText("\r\n  카드번호를 입력하세요");

            pw_check_clicked = 0;
            id_check_clicked = 0;
            name_check_clicked = 0;
            phone_check_clicked = 0;
            card_check_clicked = 0;
            id_textbox.ForeColor = Color.LightGray;
            pw_textbox.ForeColor = Color.LightGray;
            name_textbox.ForeColor = Color.LightGray;
            phone_textbox.ForeColor = Color.LightGray;
            card_textbox.ForeColor = Color.LightGray;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void id_textbox_Enter(object sender, EventArgs e)
        {
            id_check_clicked++;
            if (id_check_clicked == 1)
            {
                id_textbox.ResetText();
                id_textbox.ForeColor = Color.Black;
            }
        }
        private void pw_textbox_Enter(object sender, EventArgs e)
        {
            pw_check_clicked++;
            if (pw_check_clicked == 1)
            {
                pw_textbox.PasswordChar = '*';
                pw_textbox.ResetText();
                pw_textbox.ForeColor = Color.Black;
            }

        }
        private void name_textbox_Enter(object sender, EventArgs e)
        {
            name_check_clicked++;
            if (name_check_clicked == 1)
            {
                name_textbox.ResetText();
                name_textbox.ForeColor = Color.Black;
            }
        }
        private void phone_textbox_Enter(object sender, EventArgs e)
        {
            phone_check_clicked++;
            if (phone_check_clicked == 1)
            {
                phone_textbox.ResetText();
                phone_textbox.ForeColor = Color.Black;
            }
        }
        private void card_textbox_Enter(object sender, EventArgs e)
        {
            card_check_clicked++;
            if (card_check_clicked == 1)
            {
                card_textbox.ResetText();
                card_textbox.ForeColor = Color.Black;
            }
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

        private void id_submit_enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                conn = new OleDbConnection(connectionString);
                try
                {
                    if (id_textbox.Text.Length < 6)
                    {
                        MessageBox.Show("ID는 6자 이상이어야 합니다. 다시 작성해주세요");
                        idcheck = false;
                        id_textbox.ResetText();
                        id_check_clicked = 0;
                        return;
                    }

                    conn.Open(); //데이터베이스 연결
                    OleDbCommand cmd = new OleDbCommand();
                    cmd.CommandText = "select * from 회원 where 회원번호 ='" + id_textbox.Text + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과


                    if (!(read.Read()))
                    {
                        idcheck = true;
                        MessageBox.Show("사용 가능한 ID입니다"); //에러 메세지
                        name_textbox.ResetText();
                        this.ActiveControl = name_textbox;
                    }
                    else
                    {
                        MessageBox.Show("중복된 ID입니다. 다시 작성해주세요"); //에러 메세지 
                        id_textbox.ResetText();
                        id_textbox.AppendText("\r\n  ID를 입력하세요");
                        id_check_clicked = 0;
                        id_textbox.ForeColor = Color.LightGray;
                    }

                    read.Close();
                    conn.Close();
                }

                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show("Error : " + ex.Message); //에러 메세지 
                }
            }
        }
        private void confirm_button_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
            try
            {
                if (id_textbox.Text.Length < 6)
                {
                    MessageBox.Show("ID는 6자 이상이어야 합니다. 다시 작성해주세요");
                    idcheck = false;
                    this.ActiveControl = id_textbox;
                    return;
                }

                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 회원 where 회원번호 ='" + id_textbox.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과


                if (!(read.Read()))
                {
                    idcheck = true;
                    MessageBox.Show("사용 가능한 ID입니다"); //에러 메세지
                    name_textbox.ResetText();
                    this.ActiveControl = name_textbox;
                }
                else
                {
                    MessageBox.Show("중복된 ID입니다. 다시 작성해주세요"); //에러 메세지 
                    id_textbox.ResetText();
                    id_textbox.AppendText("\r\n  ID를 입력하세요");
                    id_check_clicked = 0;
                    id_textbox.ForeColor = Color.LightGray;
                }

                read.Close();
                conn.Close();
            }

            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show("Error : " + ex.Message); //에러 메세지 
            }

        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            if (!idcheck)
            {
                MessageBox.Show("ID 중복확인을 해주세요");
                return;
            }
            else if (name_check_clicked == 0 || name_textbox.Text.Length < 1)
            {
                MessageBox.Show("이름을 입력해주세요");
                name_textbox.ResetText();
                this.ActiveControl = name_textbox;
                return;
            }
            else if (pw_check_clicked == 0 || pw_textbox.Text.Length < 6)
            {
                MessageBox.Show("비밀번호는 6자 이상이어야 합니다");
                pw_textbox.ResetText();
                this.ActiveControl = pw_textbox;
                return;
            }
            else if (phone_check_clicked == 0 || phone_textbox.Text.Length < 1)
            {
                MessageBox.Show("전화번호를 입력해주세요");
                phone_textbox.ResetText();
                this.ActiveControl = phone_textbox;
                return;
            }
            else if (card_check_clicked == 0 || card_textbox.Text.Length < 1)
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

                    // 암호화 수행
                    SHA256 hash = new SHA256Managed();
                    byte[] bytes = hash.ComputeHash(Encoding.ASCII.GetBytes(pw_textbox.Text));
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in bytes)
                        sb.AppendFormat("{0:x2}", b);
                    // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@아래 수정요
                    cmd.CommandText = "INSERT INTO 회원(회원번호, 회원이름, 휴대전화, 카드번호, 비밀번호) VALUES('" + id_textbox.Text + "','" + name_textbox.Text + "','" + phone_textbox.Text + "','" + card_textbox.Text + "','" + sb.ToString() + "')";

                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    cmd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.
                    MessageBox.Show("가입이 완료되었습니다");
                    conn.Close();
                    this.Close();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}



