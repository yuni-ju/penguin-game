using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 방향키게임
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        //닫기
        private void close_btn_Click(object sender, EventArgs e) 
        {
            Close();
        }

        //로그인
        private void login_btn_Click(object sender, EventArgs e)
        {
            Formlogin form_login = new Formlogin();
            form_login.ShowDialog(); //로그인 창 띄우기
        }

        //회원가입
        private void join_btn_Click(object sender, EventArgs e) 
        {
            FormJoin formJoin = new FormJoin();
            formJoin.ShowDialog();
        }
    }
}
