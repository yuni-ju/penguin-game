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
    public partial class FormMy : Form
    {
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = gameuser.mdb; Persist Security Info=False";

        public FormMy(FormMenu formMenu)
        {
            ac.id = formMenu.logId();
            ac.level = formMenu.loglevel();
         
            InitializeComponent();
        }
        Account ac = new Account();
        private void FormMy_Load(object sender, EventArgs e)
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open(); //DB열기
            string OleDb = "select * from account where (A_id ='" + ac.id + "')";
            var comm = new OleDbCommand(OleDb, Conn);
            OleDbDataReader myRead = comm.ExecuteReader();          

            while (myRead.Read())
            {
                var strArray = new String[] {myRead["A_name"].ToString(),myRead["A_bestround"].ToString(),
                    myRead["A_bestscore"].ToString(), myRead["A_money"].ToString(),
                    myRead["A_level"].ToString(), myRead["A_lifetem"].ToString(), myRead["A_timetem"].ToString() };              
                ac.name = myRead["A_name"].ToString();
                ac.bestround= (int)myRead["A_bestround"];
                ac.bestscore = (int)myRead["A_bestscore"];
                ac.money = (int)myRead["A_money"];
                ac.level = (int)myRead["A_level"];
                ac.lifetem = (int)myRead["A_lifetem"];
                ac.timetem = (int)myRead["A_timetem"];
            }
            myRead.Close();
            Conn.Close();

            name_lb.Text = ac.name + " 님의 마이페이지";
            br_lb.Text = "최고라운드 :  " + ac.bestround + " 라운드";
            bs_lb.Text = "최고점수 : " + ac.bestscore + " 점";
            hvcoin_lb.Text = "보유코인 :  " + ac.money + " 개";
            life_lb.Text = "x " + ac.lifetem;
            time_lb.Text = "x " + ac.timetem;
            lv_lb.Text = "현재 캐릭터 레벨 : " + ac.level;
            pictureBox3.Image = penguinpicmy.Images[ac.level - 1];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
