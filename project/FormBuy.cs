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
    public partial class FormBuy : Form
    {
        public FormBuy(FormShop formShop)
        {
            it.Itemname = formShop.Itemname();
            ac.id = formShop.logId();
            InitializeComponent();
        }

        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = gameuser.mdb; Persist Security Info=False";
        Itembuy it = new Itembuy();
        Account ac = new Account();
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormBuy_Load(object sender, EventArgs e)
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open(); //DB열기
            string OleDb = "select * from account where (A_id ='" + ac.id + "')";
            var comm = new OleDbCommand(OleDb, Conn);
            OleDbDataReader myRead = comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] { myRead["A_money"].ToString(), myRead["A_lifetem"].ToString(), myRead["A_timetem"].ToString() };
                ac.money = (int)myRead["A_money"];
                ac.lifetem = (int)myRead["A_lifetem"];
                ac.timetem = (int)myRead["A_timetem"];               
            }    
            myRead.Close();
            Conn.Close();            
            label1.Text = it.Itemname + " 아이템 구매";
            if(it.Itemname == "목숨추가")
            {
                it.itemindex = 1;
                it.Itemmoney = 3;
            }
            else if (it.Itemname == "시간추가")
            {
                it.itemindex = 2;
                it.Itemmoney = 4;
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            it.countitem = (int)numericUpDown1.Value;            
            it.totalcoin = (it.Itemmoney * it.countitem);
            label4.Text = it.totalcoin.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (it.itemindex) {
                case 1:
                    if (ac.money < it.totalcoin)
                    {
                        MessageBox.Show("코인이 부족합니다.");
                    }
                    else
                    {
                        if (it.countitem != 0)
                        {
                            ac.money -= it.totalcoin;
                            ac.lifetem += it.countitem;
                            MessageBox.Show("목숨추가 아이템 " + it.countitem + "개 구매완료!!");
                        }                             
                    }                 
                    break;
                case 2:
                    if (ac.money < it.totalcoin)
                    {
                        MessageBox.Show("코인이 부족합니다.");
                    }
                    else
                    {
                        if (it.countitem != 0)
                        {
                            ac.money -= it.totalcoin;
                            ac.timetem += it.countitem;
                            MessageBox.Show("시간추가 아이템 " + it.countitem + "개 구매완료!!");
                        }
                    }
                    break;   
             }

            var Conn = new OleDbConnection(StrSQL);
            Conn.Open();
            string OleDb = "update account set A_lifetem = '" + ac.lifetem + "', A_timetem = '" + ac.timetem + "', A_money = '" + ac.money + "' where A_id = '" + ac.id + "' ";
            var commm = new OleDbCommand(OleDb, Conn);
            int ok = commm.ExecuteNonQuery();
            Conn.Close();

        }
    }
}
