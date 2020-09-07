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
    public partial class FormShop : Form
    {
        public FormShop(FormMenu formMenu)
        {
            ac.level = formMenu.loglevel();
            ac.money = formMenu.logmoney();
            ac.name = formMenu.logname();
            ac.id = formMenu.logId();
            InitializeComponent();
            ShopTabs();
        }
        Account ac = new Account();
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = gameuser.mdb; Persist Security Info=False";
        public string Itemname() { string Itemname = it.Itemname; return Itemname; }
        public string logId() { string loginId = ac.id; return loginId; }
        Itembuy it = new Itembuy();

        private void ShopTabs()
        {
            this.tabPage1.Text = "게임 아이템";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (ac.level)
            {
                case 1:                   
                    if (ac.money < 5)
                    {
                        MessageBox.Show("코인이 부족합니다.");
                    }
                    else
                    {                                             
                        MessageBox.Show("레벨up!! 축하드립니다!!");
                        ac.level += 1;
                        ac.money -= 5;
                        pictureBox1.Image = penguinpicshop.Images[ac.level - 1];
                       
                        var Conn = new OleDbConnection(StrSQL);
                        Conn.Open();
                        string OleDb = "update account set A_level = '" + ac.level + "', A_money = '" + ac.money + "' where A_id = '" + ac.id + "' ";
                        var commm = new OleDbCommand(OleDb, Conn);
                        int ok = commm.ExecuteNonQuery();
                        Conn.Close();
                        nac_lb.Text = ac.name + "님 보유코인 :  " + ac.money + "개";
                    }
                    break;
                case 2:
                    if (ac.money < 10)
                    {
                        MessageBox.Show("코인이 부족합니다.");
                    }
                    else
                    {                        
                        MessageBox.Show("레벨up!! 축하드립니다!!");
                        ac.money -= 10;
                        ac.level += 1;
                        pictureBox1.Image = penguinpicshop.Images[ac.level - 1];
                       
                        var Conn = new OleDbConnection(StrSQL);
                        Conn.Open();
                        string OleDb = "update account set A_level = '" + ac.level + "', A_money = '" + ac.money + "' where A_id = '" + ac.id + "' ";
                        var commm = new OleDbCommand(OleDb, Conn);
                        int ok = commm.ExecuteNonQuery();
                        Conn.Close();
                        nac_lb.Text = ac.name + "님 보유코인 :  " + ac.money + "개";
                    }
                    break;
                case 3:                  
                    if (ac.money < 15)
                    {
                        MessageBox.Show("코인이 부족합니다.");
                    }
                    else
                    {                       
                        MessageBox.Show("레벨up!! 축하드립니다!!");
                        ac.money -= 15;
                        ac.level += 1;
                        pictureBox1.Image = penguinpicshop.Images[ac.level - 1];
                      
                        var Conn = new OleDbConnection(StrSQL);
                        Conn.Open();
                        string OleDb = "update account set A_level = '" + ac.level + "', A_money = '" + ac.money + "' where A_id = '" + ac.id + "' ";
                        var commm = new OleDbCommand(OleDb, Conn);
                        int ok = commm.ExecuteNonQuery();
                        Conn.Close();
                        nac_lb.Text = ac.name + "님 보유코인 :  " + ac.money + "개";
                    }
                    break;
                case 4:
                    button1.Text = "최고레벨입니다.";
                    MessageBox.Show("최고레벨입니다.");
                    break;
            }            
        }

        private void FormShop_Load(object sender, EventArgs e)
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open(); //DB열기
            string OleDb = "select * from account where (A_id ='" + ac.id + "')";
            var comm = new OleDbCommand(OleDb, Conn);
            OleDbDataReader myRead = comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] { myRead["A_level"].ToString(), myRead["A_money"].ToString() };
                ac.level = (int)myRead["A_level"];
                ac.money = (int)myRead["A_money"];
            }
            myRead.Close();
            Conn.Close();

            pictureBox1.Image = penguinpicshop.Images[ac.level - 1];

            nac_lb.Text = ac.name + "님 보유코인 :  " + ac.money + "개";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        //아이템 한번클릭시 개당 가격정보
        private void listView1_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;

                if (subItem[0].Text == "목숨추가")
                {
                    label1.Text = subItem[0].Text + " 아이템은 3코인 입니다.";
                }
                else if (subItem[0].Text == "시간추가")
                {
                    label1.Text = subItem[0].Text + " 아이템은 4코인 입니다.";
                }
            }
        }
        //아이템 더블클릭시 구매창       
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                ListViewItem.ListViewSubItemCollection subItem = item.SubItems;               
                
                if (subItem[0].Text == "목숨추가")
                {
                    it.Itemname = "목숨추가";
                    FormBuy formBuy = new FormBuy(this);
                    formBuy.ShowDialog();              
                }
                else if (subItem[0].Text == "시간추가")
                {
                    it.Itemname = "시간추가";
                    FormBuy formBuy = new FormBuy(this);
                    formBuy.ShowDialog();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open(); //DB열기
            string OleDb = "select * from account where (A_id ='" + ac.id + "')";
            var comm = new OleDbCommand(OleDb, Conn);
            OleDbDataReader myRead = comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] { myRead["A_level"].ToString(), myRead["A_money"].ToString() };
                ac.level = (int)myRead["A_level"];
                ac.money = (int)myRead["A_money"];
            }
            myRead.Close();
            Conn.Close();
            nac_lb.Text = ac.name + "님 보유코인 :  " + ac.money + "개";

            switch (ac.level)
            {
                case 1:
                    button1.Text = "캐릭터 level up : -5 코인";                    
                    break;
                case 2:
                    button1.Text = "캐릭터 level up : -10 코인";                   
                    break;
                case 3:
                    button1.Text = "캐릭터 level up : -15 코인";                    
                    break;
                case 4:
                    button1.Text = "최고레벨입니다.";                   
                    break;
            }
        }
    }
}
