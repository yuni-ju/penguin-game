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

namespace 방향키게임
{
    public partial class Formlogin : Form
    {
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = gameuser.mdb; Persist Security Info=False";

        Account ac = new Account();
        public Formlogin()
        {
            InitializeComponent();
        }

        //아이디 정보 다른폼으로 보내기
        public string loginName(){  string loginName = ac.name;return loginName;}
        public string loginId() { string loginId = ac.id; return loginId; }

        //로그인 버튼 누를 시
        private void button1_Click(object sender, EventArgs e)
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open(); //DB열기
            string OleDb = "select * from account where (A_id ='" + this.id_txt.Text + "')";
            var comm = new OleDbCommand(OleDb, Conn);
            OleDbDataReader myRead = comm.ExecuteReader();
            int loginok = 0, idok = 0;
            int count = 0;  
            try
            {
                while (myRead.Read())
                {
                    var strArray = new String[] { myRead["A_id"].ToString(), myRead["A_password"].ToString(),myRead["A_name"].ToString() };
                    count++;
                    ac.id = myRead["A_id"].ToString(); //아이디 찾으면 id에 넣기
                    ac.password = myRead["A_password"].ToString(); //그 아이디의 비밀번호 넣기 
                    ac.name = myRead["A_name"].ToString();
                }               
                myRead.Close();
                Conn.Close();
                if (count == 0) { throw new loginExpt(); }
            } 
            catch (loginExpt)
            {              
                    MessageBox.Show("존재하지 않는 아이디 입니다.");
                    id_txt.Focus();
                    loginok = -1;
                    idok = -1;
            }
            if (ac.password != pass_txt.Text.ToString()&&idok!=-1) {
                MessageBox.Show("비밀번호를 다시 입력해주세요.");
                pass_txt.Focus();
                loginok = -2;
            }
            if (loginok == 0)
            {
                //로그인 성공 시 메뉴화면띄우고 로그인 창 닫기
                MessageBox.Show(ac.id + "님 로그인");
                this.Hide();
                FormMenu form_menu = new FormMenu(this);               
                form_menu.ShowDialog();              
            }
        }
    }
}
