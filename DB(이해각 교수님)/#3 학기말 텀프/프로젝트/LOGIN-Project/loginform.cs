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

namespace LOGIN
{
    public partial class loginform : Form
    {
        public loginform()
        {
            InitializeComponent();
            this.MinimumSize = new Size(480, 560); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(480, 560);
            this.ActiveControl = panel1; // 포커스 초기화
        }

        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=1234;User ID=student"; //oracle 서버 연결
        public static string Login_ID;
        public static bool isAdmin = false;
        int id_check_clicked = 0;
        int pw_check_clicked = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            this.ActiveControl = panel1;
            id_textbox.ResetText();
            id_textbox.AppendText("\r\n  ID를 입력하세요");
            pw_textbox.ResetText();
            pw_textbox.AppendText("\r\n  비밀번호를 입력하세요");
            pw_check_clicked = 0;
            id_check_clicked = 0;
            id_textbox.ForeColor = Color.LightGray;
            pw_textbox.ForeColor = Color.LightGray;
            pw_textbox.PasswordChar = '\0';
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
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
                pw_textbox.ResetText();
                pw_textbox.ForeColor = Color.Black;
            }
            pw_textbox.PasswordChar = '*';
        }
        private void signup_button_Click(object sender, EventArgs e)
        {
            Form signupform = new signupform();
            this.AddOwnedForm(signupform);
            signupform.Show();
        }




        private void login_button_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
            try
            {
                if (id_textbox.Text.Length < 1)
                {
                    MessageBox.Show("ID를 입력해주세요");
                    return;
                }

                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 회원 where 회원번호 ='" + id_textbox.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과


                if (read.Read() == false) {
                    MessageBox.Show("존재하지 않는 ID입니다. ID를 확인하세요"); //에러 메세지
                    this.ActiveControl = id_textbox;
                }
                else {

                    Login_ID = id_textbox.Text;
                    if(Login_ID == "system") {
                        isAdmin = true;
                    }
                    else
                    {
                        isAdmin = false;
                    }
                    SHA256 hash = new SHA256Managed();
                    byte[] bytes = hash.ComputeHash(Encoding.ASCII.GetBytes(pw_textbox.Text));
                    StringBuilder sb = new StringBuilder();
                    foreach (byte b in bytes)
                    sb.AppendFormat("{0:x2}", b);
                    if (read.GetValue(5).ToString() == sb.ToString())
                    {
                        if (isAdmin == true || read.GetValue(3).ToString() != "")
                        {
                            if(isAdmin == true)
                            {
                                MessageBox.Show("관리자 계정 로그인 성공");
                            }
                            else
                            {
                                MessageBox.Show("로그인 성공");

                            }
                            Form selectform = new selectform();
                            this.AddOwnedForm(selectform);
                            selectform.Show();

                            read.Close();
                            conn.Close();
                        }
                        else
                        {
                            MessageBox.Show("가입 승인되지 않은 계정입니다. 관리자에게 문의하세요");
                        }
                    }
                    else
                    {
                        MessageBox.Show("비밀번호가 다릅니다. 비밀번호를 확인하세요"); //에러 메세지
                        pw_textbox.ResetText();
                        this.ActiveControl = pw_textbox;
                    }
                    



                }

                read.Close();
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message); //에러 메세지 
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

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void findid_button_Click(object sender, EventArgs e)
        {
            Form findidform = new findidform();
            this.AddOwnedForm(findidform);
            findidform.Show();
        }

        private void findpw_button_Click(object sender, EventArgs e)
        {
            Form findpwform = new findpwform();
            this.AddOwnedForm(findpwform);
            findpwform.Show();
        }
    }
}



