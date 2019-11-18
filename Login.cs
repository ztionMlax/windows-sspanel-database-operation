using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace SSPanel
{
    public partial class Login : Form
    {
        DBHelper db = new DBHelper();
        public Login()
        {
            InitializeComponent();

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }
        public void SetValues() {
            Helper.add = this.txtip.Text.Trim();
            Helper.use = this.txtroot.Text.Trim();
            Helper.pwd = this.txtpass.Text.Trim();
        }
      
        private void Btnlogin_Click(object sender, EventArgs e)
        {
                this.SetValues();
                string sql = $"select user_name from user where id=1";
                this.lbtw.Visible=true;
            if (db.ExeScalar(sql).ToString() == null)
            {
                MessageBox.Show("登录失败,请重试", "提示", MessageBoxButtons.OK);
            }
            else {
                this.lbtw.Text = "登陆成功";
                MessageBox.Show("登录成功,", "提示", MessageBoxButtons.OK);
            }
            this.lbtw.Hide();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.txtPwd.Enabled = false;
            this.txtsql.Enabled = false;
            this.txtUser.Enabled = false;
            this.ptbhover.Hide();
            this.lbtw.Hide();
        }

        private void Btnexit_Click(object sender, EventArgs e)
        {
            //DialogResult res = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.YesNo);
            //if (res == DialogResult.Yes)
            //    this.Close();
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        //private void PictureBox3_Click(object sender, EventArgs e)
        //{
        //    DialogResult res = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.YesNo);
        //    if (res == DialogResult.Yes)
        //        this.Close();
        //}

        private void TxtPwd_TextChanged(object sender, EventArgs e)
        {

        }

        private void Panel1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("QAQ","QAQ");
        }

        private void PictureBox4_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("确定退出吗？", "提示", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
                this.Close();
        }

        private void PictureBox4_MouseHover(object sender, EventArgs e)
        {
            //this.pictureBox4.Image=
        }

        private void PictureBox4_MouseHover_1(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = this.ilall.Images[0];
        }

        private void PictureBox4_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox4.BackgroundImage = this.ilall.Images[1];
        }

        private void PictureBox4_MouseMove(object sender, MouseEventArgs e)
        {
            this.pictureBox4.BackgroundImage = this.ilall.Images[0];
        }
        //
        private void Btnlogin_MouseHover(object sender, EventArgs e)
        {
            //this.ptbhover.Visible = true;
        }

        private void Btnlogin_MouseLeave(object sender, EventArgs e)
        {
            //this.ptbhover.Hide();
        }

        private void Btnlogin_MouseMove(object sender, MouseEventArgs e)
        {
            //this.ptbhover.Visible = true;
        }

        private void Ptbhover_Click(object sender, EventArgs e)
        {
            this.Btnlogin_Click(sender,e);
        }
    }
}
