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
    public partial class FormLank : Form
    {
        public FormLank()
        {
            InitializeComponent();
        }
        
        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = gameuser.mdb; Persist Security Info=False";
       // public int[] arr = new int [50];
       // public int[] arr2 = new int[50];
        

        private void FormLank_Load(object sender, EventArgs e)
        {            
            Score_sort();
        }
        
    private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        public void Score_sort()
        {
            int count = 0; Lank sc = new Lank();
            //점수 다불러오고 그값에 해당하는 열 순서대로 출력
            int i = 0, temp;
            this.lvList.Items.Clear();
            var Conn1 = new OleDbConnection(StrSQL);
            Conn1.Open();
            var Comm1 = new OleDbCommand("Select * From account", Conn1);
            var myRead1 = Comm1.ExecuteReader();

            while (myRead1.Read())
            {
                var strArray = new string[] { myRead1["A_bestscore"].ToString() };
                sc.arr[i] = int.Parse(strArray[0].ToString());
                //label2.Text += i.ToString();
                i++; count++;
            }
            //모든 정보 받아와서 저장  
            myRead1.Close();
            Conn1.Close();

            //점수만 뽑아서 정렬
            for (int j = 0; j < sc.arr.Length; j++)
            {
                for (int k = 0; k < sc.arr.Length - 1; k++)
                {
                    if (sc.arr[k] < sc.arr[k + 1])
                    {
                        temp = sc.arr[k];
                        sc.arr[k] = sc.arr[k + 1];
                        sc.arr[k + 1] = temp;
                    }
                }
            }
            int z = 0;
            for(int x= 0; x< sc.arr.Length-1; x++) //중복값 빼고저장
            {               
                if (sc.arr[x] != sc.arr[x+1])
                {
                    sc.arr2[z] = sc.arr[x];
                    z++;
                }                
            }
            

            //점수에 해당하는 열 찾아서 리스트에 넣기
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open(); //DB열기

            for (int y = 0; y < z+1; y++) {
                    string OleDb = "select * from account where (A_bestscore =" + sc.arr2[y] + ")";
                    var comm = new OleDbCommand(OleDb, Conn);
                    OleDbDataReader myRead = comm.ExecuteReader();
                    while (myRead.Read())
                    {
                        var strArray = new String[] { myRead["A_name"].ToString(), myRead["A_level"].ToString(),
                            myRead["A_bestround"].ToString(), myRead["A_bestscore"].ToString() };
                        var lvt = new ListViewItem(strArray);

                        this.lvList.Items.Add(lvt);
                    }
                    myRead.Close();                
            }               
                Conn.Close();          
        }
        public void Level_sort()
        {
            int count = 0; Lank lv = new Lank();
            //단계 다불러오고 그값에 해당하는 열 순서대로 출력
            int i = 0, temp;
            this.lvList.Items.Clear();
            var Conn1 = new OleDbConnection(StrSQL);
            Conn1.Open();
            var Comm1 = new OleDbCommand("Select * From account", Conn1);
            var myRead1 = Comm1.ExecuteReader();

            while (myRead1.Read())
            {
                var strArray = new string[] { myRead1["A_level"].ToString() };
                lv.arr[i] = int.Parse(strArray[0].ToString());
                //label2.Text += i.ToString();
                i++; count++;
            }
            //모든 정보 받아와서 저장  
            myRead1.Close();
            Conn1.Close();

            //단계만 뽑아서 정렬
            for (int j = 0; j < lv.arr.Length; j++)
            {
                for (int k = 0; k < lv.arr.Length - 1; k++)
                {
                    if (lv.arr[k] < lv.arr[k + 1])
                    {
                        temp = lv.arr[k];
                        lv.arr[k] = lv.arr[k + 1];
                        lv.arr[k + 1] = temp;
                    }
                }
            }
            int z = 0;//중복제거
            for (int x = 0; x < lv.arr.Length - 1; x++)
            {
                if (lv.arr[x] != lv.arr[x + 1])
                {
                    lv.arr2[z] = lv.arr[x];
                    z++;
                }
            }    

            //점수에 해당하는 열 찾아서 리스트에 넣기
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open(); //DB열기

            for (int y = 0; y < z+1 ; y++)
            {
                string OleDb = "select * from account where (A_level =" + lv.arr2[y] + ")";
                var comm = new OleDbCommand(OleDb, Conn);
                OleDbDataReader myRead = comm.ExecuteReader();
                while (myRead.Read())
                {
                    var strArray = new String[] { myRead["A_name"].ToString(), myRead["A_level"].ToString(), myRead["A_bestround"].ToString(), myRead["A_bestscore"].ToString() };
                    var lvt = new ListViewItem(strArray);

                    this.lvList.Items.Add(lvt);
                }
                myRead.Close();
            }
            Conn.Close();
        }

        private void sco_rdi_CheckedChanged(object sender, EventArgs e) //라디오버튼에 변화생길 시
        {
           if (sco_rdi.Checked == true) { Score_sort(); }//점수정렬
           else if(lv_rdi.Checked == true) { Level_sort(); } //레벨정렬
        }

    }
}
