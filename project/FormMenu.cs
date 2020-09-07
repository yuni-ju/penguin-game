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
    public partial class FormMenu : Form
    {
        //Formlogin formlogin;
        Account ac = new Account();
        public FormMenu(Formlogin formlogin)
        {
            InitializeComponent();
            ac.id = formlogin.loginId();            
            wel_lb.Text = formlogin.loginName() + " 님 반갑습니다^-^";
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            //로그아웃버튼
            Close();            
        }
        //로그인 한사람의 정보 전달위한 함수
        public string logId() { string loginId = ac.id; return loginId; }
        public string logpassword() {string logpassword = ac.password; return logpassword; }
        public string logname() { string logname = ac.name; return logname; }
        public int logbestrnd() { int logbestrnd = ac.bestround; return logbestrnd; }
        public int logbesetscr() { int logbesetscr = ac.bestscore; return logbesetscr; }
        public int logmoney() { int logmoney = ac.money; return logmoney; }
        public int loglevel() { int loglevel = ac.level; return loglevel; }     
        public int loglifetem() { int loglifetem = ac.lifetem; return loglifetem; }
        public int logtimetem() { int logtimetem = ac.timetem; return logtimetem; }

        private void start_btn_Click(object sender, EventArgs e)
        {
            //게임시작버튼
            FormStart formstart = new FormStart(this); 
            formstart.ShowDialog();  
        }
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = gameuser.mdb; Persist Security Info=False";

        private void FormMenu_Load(object sender, EventArgs e)
        {
            wel_lb.BackColor = Color.Transparent;

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open(); //DB열기
            string OleDb = "select * from account where (A_id ='" + ac.id + "')";
            var comm = new OleDbCommand(OleDb, Conn);
            OleDbDataReader myRead = comm.ExecuteReader();
          
            int count = 0;

                while (myRead.Read())
                {
                    var strArray = new String[] { myRead["A_id"].ToString(), myRead["A_password"].ToString(),myRead["A_name"].ToString(),
                        myRead["A_bestround"].ToString(), myRead["A_bestscore"].ToString(), myRead["A_money"].ToString(),
                        myRead["A_level"].ToString(), myRead["A_lifetem"].ToString(), myRead["A_timetem"].ToString() };
                    count++;
                    ac.id = myRead["A_id"].ToString(); //아이디 찾으면 id에 넣기
                    ac.password = myRead["A_password"].ToString(); //그 아이디의 비밀번호 넣기 
              
                    ac.name = myRead["A_name"].ToString();
                    ac.bestround = (int)myRead["A_bestround"];
                    ac.bestscore = (int)myRead["A_bestscore"];
                    ac.money = (int)myRead["A_money"];
                    ac.level = (int) myRead["A_level"];
                    ac.lifetem = (int)myRead["A_lifetem"];
                    ac.timetem = (int)myRead["A_timetem"];
                }
                myRead.Close();
                Conn.Close();
        }

        private void store_btn_Click(object sender, EventArgs e)
        {
            FormShop formShop = new FormShop(this);
            formShop.ShowDialog();
        }

        private void lank_btn_Click(object sender, EventArgs e)
        {
            FormLank formLank = new FormLank();
            formLank.ShowDialog();
        }

        private void my_btn_Click(object sender, EventArgs e)
        {        
            FormMy formMy = new FormMy(this);
            formMy.ShowDialog();

        }

        private void 도움말ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("1. 화면의 방향키에 따라 키보드 방향키 누르기  \n" +
                "2. 아이템 사용은 목숨추가 : A, 시간추가 : S 누르기  ","도움말",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
