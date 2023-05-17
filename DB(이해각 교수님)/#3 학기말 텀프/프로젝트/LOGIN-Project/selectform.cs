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
    public partial class selectform : Form
    {
        public selectform()
        {
            InitializeComponent();
            this.MinimumSize = new Size(480, 560); // 최소 / 최대 창 사이즈를 같게하여 창크기 고정
            this.MaximumSize = new Size(480, 560);
            this.ActiveControl = panel1; // 포커스 초기화
            if (loginform.isAdmin != true)
            {
                addcar.Visible = false;
                addgrad.Visible = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.ActiveControl = panel1;
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void rsrv_Click(object sender, EventArgs e)
        {
            Form src_reserv_form = new src_reserv_form();
            this.AddOwnedForm(src_reserv_form);
            src_reserv_form.Show();
        }

        private void lkup_Click(object sender, EventArgs e)
        {
            Form lookupform = new lookupform();
            this.AddOwnedForm(lookupform);
            lookupform.Show();
        }

        private void addcar_Click(object sender, EventArgs e)
        {
            Form addcarform = new addcarform();
            this.AddOwnedForm(addcarform);
            addcarform.Show();
        }

        private void addgrad_Click(object sender, EventArgs e)
        {
            Form gradeform = new gradeform();
            this.AddOwnedForm(gradeform);
            gradeform.Show();
        }

        private void modmem_button_Click(object sender, EventArgs e)
        {
            Form modifymemform = new modifymemform();
            this.AddOwnedForm(modifymemform);
            modifymemform.Show();
        }
    }
}



