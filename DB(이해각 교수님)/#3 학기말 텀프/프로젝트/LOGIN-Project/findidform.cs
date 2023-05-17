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
    public partial class findidform : Form
    {
        public findidform()
        {
            InitializeComponent();
            this.MinimumSize = new Size(480, 560); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(480, 560);
            this.ActiveControl = panel1; // 포커스 초기화
        }

        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=1234;User ID=student"; //oracle 서버 연결
        
        int name_check_clicked = 0;
        int phone_check_clicked = 0;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            this.ActiveControl = panel1;
            name_textbox.ResetText();
            name_textbox.AppendText("\r\n  회원이름을 입력하세요");
            phone_textbox.ResetText();
            phone_textbox.AppendText("\r\n  전화번호를 입력하세요");

            name_check_clicked = 0;
            phone_check_clicked = 0;
            name_textbox.ForeColor = Color.LightGray;
            phone_textbox.ForeColor = Color.LightGray;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
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
        private void submit_button_Click(object sender, EventArgs e)
        {
            if (name_check_clicked == 0 || name_textbox.Text.Length < 1)
            {
                MessageBox.Show("가입시 등록한 이름을 입력해주세요");
                name_textbox.ResetText();
                this.ActiveControl = name_textbox;
                return;
            }
            else if (phone_check_clicked == 0 || phone_textbox.Text.Length < 1)
            {
                MessageBox.Show("전화번호를 입력해주세요");
                phone_textbox.ResetText();
                this.ActiveControl = phone_textbox;
                return;
            }
            else
            {
                conn = new OleDbConnection(connectionString);
                try
                {
                    conn.Open(); //데이터베이스 연결
                    OleDbCommand cmd = new OleDbCommand();

                    cmd.CommandText = "select 회원번호 from 회원 where 회원이름 = '" + name_textbox.Text + "' and 휴대전화 = '" + phone_textbox.Text + "'";
                    cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                    cmd.Connection = conn;

                    OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과

                    if(!(read.Read())) {
                        MessageBox.Show("일치하는 회원정보가 없습니다. 다시 입력해주세요");
                    }
                    else
                    {
                        MessageBox.Show("회원님의 아이디는 " + read.GetValue(0).ToString() + "입니다.");
                        this.Close();
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



