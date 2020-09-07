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
    public partial class FormJoin : Form
    {
        public FormJoin()
        {
            InitializeComponent();
        }
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = gameuser.mdb; Persist Security Info=False";

        private void can_btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            int joinok = 0, count = 0;

            //아이디 중복확인하기
            var Connid = new OleDbConnection(StrSQL); 
            Connid.Open(); 
            string OleDbid = "select * from account where (A_id ='" + this.jid_txt.Text + "')";
            var commid = new OleDbCommand(OleDbid, Connid);
            OleDbDataReader myRead = commid.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] { myRead["A_id"].ToString()};
                count++;
            }
            myRead.Close();
            Connid.Close();

            //회원가입 조건 검사
            if (count != 0) { MessageBox.Show("이미 존재하는 아이디 입니다."); joinok = -1; }    
            else if (jpas_txt.Text != jpasc_txt.Text) { MessageBox.Show("비밀번호가 일치하지 않습니다."); joinok = -1; }
            else if (jid_txt.Text == "" || jpas_txt.Text == "" || jpasc_txt.Text == "" || jname_txt.Text == "") { MessageBox.Show("입력하지 않은 항목이 있습니다."); joinok = -1; }

            //회원가입 조건 만족 시 회원정보 저장 
            if (joinok == 0) 
            {
                int level = 1;
                var Connj = new OleDbConnection(StrSQL);
                Connj.Open();
                string OleDb = "insert into account (A_id, A_password,A_name, A_level)" +
                    " values('" + this.jid_txt.Text + "','" + this.jpas_txt.Text + "','" + this.jname_txt.Text + "','" + level + "')";
                var comm = new OleDbCommand(OleDb, Connj);
                int save = comm.ExecuteNonQuery();
                Connj.Close();

                if (save == 1)
                {
                    MessageBox.Show("가입완료");
                    empty();
                    this.Close();
                }
            }
        }
        private void empty()
        {
            this.jid_txt.Clear();
            this.jname_txt.Clear();
            this.jpas_txt.Clear();
            this.jpasc_txt.Clear();
        }
    }
}
