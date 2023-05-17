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
    public partial class Form1 : Form
    {
        public Form1()
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
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
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
        
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            id_check_clicked++;
            if (id_check_clicked == 1)
            {
                id_textbox.ResetText();
                id_textbox.ForeColor = Color.Black;
            }
        }
        private void pw_textbox_TextChanged(object sender, EventArgs e)
        {
            pw_check_clicked++;
            if (pw_check_clicked == 1)
            {
                pw_textbox.ResetText();
                pw_textbox.ForeColor = Color.Black;
            }

        }
        private void name_textbox_TextChanged(object sender, EventArgs e)
        {
            name_check_clicked++;
            if (name_check_clicked == 1)
            {
                name_textbox.ResetText();
                name_textbox.ForeColor = Color.Black;
            }
        }
        private void phone_textbox_TextChanged(object sender, EventArgs e)
        {
            phone_check_clicked++;
            if (phone_check_clicked == 1)
            {
                phone_textbox.ResetText();
                phone_textbox.ForeColor = Color.Black;
            }
        }
        private void card_textbox_TextChanged(object sender, EventArgs e)
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
        private void button1_Click(object sender, EventArgs e)
        {
            conn = new OleDbConnection(connectionString);
            try
            {
                if (id_textbox.Text.Length < 3)
                {
                    MessageBox.Show("ID는 3자 이상이어야 합니다");
                    idcheck = false;
                    return;
                }

                conn.Open(); //데이터베이스 연결
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 회원 where member_id ='" + id_textbox.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과

                if (!(read.Read()))
                {
                    idcheck = true;
                    MessageBox.Show("사용가능한 ID입니다"); //에러 메세지 
                }
                else
                {
                    MessageBox.Show("중복 ID입니다"); //에러 메세지 
                }

                read.Close();
                conn.Close();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message); //에러 메세지 
            }
        }
        private void submit_button_Click(object sender, EventArgs e)
        {
            

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



