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
        
        int id_check_clicked = 0;
        int pw_check_clicked = 0;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //InitializeComponent();
            id_textbox.ResetText();
            id_textbox.AppendText("\r\n  ID를 입력하세요");
            pw_textbox.ResetText();
            pw_textbox.AppendText("\r\n  비밀번호를 입력하세요");
            pw_check_clicked = 0;
            id_check_clicked = 0;
            id_textbox.ForeColor = Color.LightGray;
            pw_textbox.ForeColor = Color.LightGray;
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
        private void signup_button_Click(object sender, EventArgs e)
        {
            Form signupform = new Form1();
            this.AddOwnedForm(signupform);
            signupform.Show();
        }




        private void login_button_Click(object sender, EventArgs e)
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

        private void label3_Click(object sender, EventArgs e)
        {

        }


    }
}



