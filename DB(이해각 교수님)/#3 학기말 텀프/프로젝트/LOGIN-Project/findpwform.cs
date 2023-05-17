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
    public partial class findpwform : Form
    {
        public findpwform()
        {
            InitializeComponent();
            this.MinimumSize = new Size(480, 560); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(480, 560);
            this.ActiveControl = panel1; // 포커스 초기화
            label1.Visible = true; label5.Visible = true; label3.Visible = true;
            id_textbox.Visible = true; phone_textbox.Visible = true; name_textbox.Visible = true;

            label2.Visible = false; label4.Visible = false; new_pw.Visible = false; vf_pw.Visible = false;
        }

        OleDbConnection conn;
        string connectionString = "Provider=MSDAORA;Password=1234;User ID=student"; //oracle 서버 연결
        


        int id_check_clicked = 0;
        int new_pw_check_clicked = 0;
        int vf_pw_check_clicked = 0;
        int name_check_clicked = 0;
        int phone_check_clicked = 0;
        int card_check_clicked = 0;
        bool idcheck = false;
        bool confirmed = true;
        bool changed = false;


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label1.Visible = true; label5.Visible = true; label3.Visible = true;
            id_textbox.Visible = true; phone_textbox.Visible = true; name_textbox.Visible = true;

            label2.Visible = false; label4.Visible = false; new_pw.Visible = false; vf_pw.Visible = false;
            //InitializeComponent();
            this.ActiveControl = panel1;
            //pw_textbox.PasswordChar = '\0';
            id_textbox.ResetText();
            id_textbox.AppendText("\r\n  ID를 입력하세요");
            //pw_textbox.ResetText();
            //pw_textbox.AppendText("\r\n  비밀번호를 입력하세요");
            name_textbox.ResetText();
            name_textbox.AppendText("\r\n  회원이름을 입력하세요");
            phone_textbox.ResetText();
            phone_textbox.AppendText("\r\n  전화번호를 입력하세요");
            //card_textbox.ResetText();
            //card_textbox.AppendText("\r\n  카드번호를 입력하세요");

            new_pw_check_clicked = 0;
            id_check_clicked = 0;
            name_check_clicked = 0;
            phone_check_clicked = 0;
            vf_pw_check_clicked = 0;
            id_textbox.ForeColor = Color.LightGray;
            //pw_textbox.ForeColor = Color.LightGray;
            name_textbox.ForeColor = Color.LightGray;
            phone_textbox.ForeColor = Color.LightGray;
            //card_textbox.ForeColor = Color.LightGray;
            new_pw.ForeColor = Color.LightGray;
            vf_pw.ForeColor = Color.LightGray;
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
        private void new_pw_Enter(object sender, EventArgs e)
        {
            new_pw_check_clicked++;
            if (new_pw_check_clicked == 1)
            {
                new_pw.PasswordChar = '*';
                new_pw.ResetText();
                new_pw.ForeColor = Color.Black;
            }

        }
        private void vf_pw_Enter(object sender, EventArgs e)
        {
            vf_pw_check_clicked++;
            if (vf_pw_check_clicked == 1)
            {
                vf_pw.PasswordChar = '*';
                vf_pw.ResetText();
                vf_pw.ForeColor = Color.Black;
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
            try {
                conn = new OleDbConnection(connectionString);
                conn.Open();
                OleDbCommand cmd = new OleDbCommand();
                cmd.CommandText = "select * from 회원 where 회원번호 ='" + id_textbox.Text + "' and 회원이름 = '" + name_textbox.Text + "' and 휴대전화 = '" + phone_textbox.Text + "'";
                cmd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                cmd.Connection = conn;

                OleDbDataReader read = cmd.ExecuteReader(); //select 회원ID from 회원 결과

                if (!(read.Read()))
                {
                    MessageBox.Show("존재하지 않는 계정입니다. 다시 입력해주세요"); //에러 메세지
                    this.ActiveControl = id_textbox;
                }
                else
                {
                    if (changed == false)
                    {
                        MessageBox.Show("새로 사용할 비밀번호를 입력해주세요");
                        label1.Visible = false; label5.Visible = false; label3.Visible = false;
                        id_textbox.Visible = false; phone_textbox.Visible = false; name_textbox.Visible = false;

                        label2.Visible = true; label4.Visible = true; new_pw.Visible = true; vf_pw.Visible = true;

                        changed = true;
                    }
                    else
                    {
                        try
                        {
                            if (new_pw_check_clicked == 0 || new_pw.Text.Length < 6)
                            {
                                MessageBox.Show("비밀번호는 6자 이상입니다. 다시 작성해주세요");
                                new_pw.ResetText();
                                this.ActiveControl = new_pw;
                                return;
                            }
                            else if (vf_pw_check_clicked == 0 || (vf_pw.Text != new_pw.Text))
                            {
                                MessageBox.Show("비밀번호 확인이 일치하지 않습니다 .다시 작성해주세요");
                                vf_pw.ResetText();
                                this.ActiveControl = vf_pw;
                                return;
                            }
                            else
                            {
                                try
                                {
                                    OleDbCommand upd = new OleDbCommand();

                                    // 암호화 수행
                                    SHA256 hash = new SHA256Managed();
                                    byte[] bytes = hash.ComputeHash(Encoding.ASCII.GetBytes(new_pw.Text));
                                    StringBuilder sb = new StringBuilder();
                                    foreach (byte b in bytes)
                                        sb.AppendFormat("{0:x2}", b);
                                    // @@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@아래 수정요
                                    upd.CommandText = "UPDATE 회원 SET 비밀번호 = '" + sb.ToString() + "' WHERE 회원번호 = '" + id_textbox.Text + "' AND 회원이름 = '" + name_textbox.Text + "' and 휴대전화 = '" + phone_textbox.Text + "'";

                                    upd.CommandType = CommandType.Text; //검색명령을 쿼리 형태로
                                    upd.Connection = conn;

                                    upd.ExecuteNonQuery(); //쿼리문을 실행하고 영향받는 행의 수를 반환.

                                    MessageBox.Show("비밀번호 변경 완료");
                                    this.Close();


                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Error: " + ex.Message); //에러 메세지 

                                }
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
                    }
                }
            }
            catch
            {
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



