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
    public partial class FormStart : Form
    {       
        public FormStart(FormMenu formMenu)
        {
            InitializeComponent();
            KeyPreview = true; 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            ac.id = formMenu.logId();
            ac.bestround = formMenu.logbestrnd();
            ac.bestscore = formMenu.logbesetscr();
            ac.level = formMenu.loglevel();
            ac.lifetem = formMenu.loglifetem();
            ac.timetem = formMenu.logtimetem();
        }
        Account ac = new Account();
 

        Stage stg = new Stage();
        Bitmap b1 = new Bitmap("방향키1.png");
        Bitmap b2 = new Bitmap("방향키2.png");
        Bitmap b3 = new Bitmap("방향키3.png");
        Bitmap b4 = new Bitmap("방향키4.png");
        Bitmap hb1 = new Bitmap("흑방향키1.png");
        Bitmap hb2 = new Bitmap("흑방향키2.png");
        Bitmap hb3 = new Bitmap("흑방향키3.png");
        Bitmap hb4 = new Bitmap("흑방향키4.png");
        Bitmap life = new Bitmap("하트.png");

        private string StrSQL = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source = gameuser.mdb; Persist Security Info=False";

        public void Rand(int y)
        {
            Random r = new Random();
            Graphics g = flowLayoutPanel1.CreateGraphics();
            int j = 230;
            j = j - (stg.round_count * 13);
            for (int i = 0; i < stg.round_count; i++)
            {
                    j -= 10; //화살표 개수 달라져도 가운데 정렬되도록 x축 값 조정
                    r.Next();
                    y = r.Next(1, 4);
                    stg.ran[i] = y;
                    //흑백 화살표 (눌러야 되는 화살표)
                    if (y == 1) {  g.DrawImage(hb1, (i * 40)+j, 10);  }
                    else if (y == 2) {  g.DrawImage(hb2, (i * 40)+j, 10);  }
                    else if (y == 3) { g.DrawImage(hb3, (i * 40)+j, 13);  }
                    else if (y == 4) {  g.DrawImage(hb4, (i * 40)+j, 13); ; }              
            }
        }
        public void Cor(int[] ran, int Ai, int x)
        {

            int success = 1; Graphics g = flowLayoutPanel1.CreateGraphics();
            int j = 230;
            //맞았을 경우 컬러 화살표 띄운다)
            if (ran[stg.Ai] == x)
            {
                j = j - (stg.round_count * 13);

                for (int i = 0; i < 1; i++)
                {
                    j = j - (10 * (stg.Ai + 1));
                    if (x == 1) { g.DrawImage(b1, (stg.Ai * 40) + j, 10); }
                    else if (x == 2) { g.DrawImage(b2, (stg.Ai * 40) + j, 10); }
                    else if (x == 3) { g.DrawImage(b3, (stg.Ai * 40) + j, 13); }
                    else if (x == 4) { g.DrawImage(b4, (stg.Ai * 40) + j, 13); ; }
                }
                stg.Ai++; stg.Score += 1 * (stg.Round + 1);
                Score_lb.Text = "Score  " + (stg.Score);
            }
            //틀렸을 경우
            else if (ran[stg.Ai] != x )
            {               
                    success = 0;
                    stg.Life = stg.Life - 1;
                    flowLayoutPanel2.Refresh();
                    Graphics g1 = flowLayoutPanel2.CreateGraphics();

                    for (int i = 0; i < stg.Life; i++)
                    {
                        g1.DrawImage(life, 1 + (i * 30), 1);
                    }
                    if (stg.Life == 0)
                    {
                        stg.stop += 1;
                        Stop();
                    }
                
            }
            //단계 성공 시
            if (stg.Ai == (stg.round_count) && success == 1)
            {
                stg.Ai = 0;
                stg.Round += 1;
                Stage_lb.Text = "Stage  " + (stg.Round + 1);
                if (stg.Round % 3 == 0)
                {
                    //13개면 그만 더하기 (화살표가 panel크기 벗어나지 않도록 하기위해!)
                    if (stg.round_count != 13)
                    {
                        stg.round_count += 1;
                    }
                }
                flowLayoutPanel1.Refresh();
                Rand(stg.y);
            }
        }

        private void FormStart_KeyDown(object sender, KeyEventArgs e) //키보드 누를 때의 값과 랜덤 방향키 값 동일하게 한다 
        {                                                              //**다른키 누를때 안되게 예외처리하기
            if (e.KeyCode == Keys.Up) { stg.x = 1; }                
            else if (e.KeyCode == Keys.Down) { stg.x = 2; }
            else if (e.KeyCode == Keys.Left) { stg.x = 3; }
            else if (e.KeyCode == Keys.Right) { stg.x = 4; }
            else if (e.KeyCode == Keys.A) { stg.x = 0; if (ac.lifetem > 0) {ac.lifetem -= 1; stg.Life += 1; label4.Text = "x " + ac.lifetem; } }
            else if (e.KeyCode == Keys.S) { stg.x = 0; if (ac.timetem > 0) { ac.timetem -= 1; stg.t += 10; label3.Text = "x " + ac.timetem; } }
            else if (e.KeyCode == Keys.Alt) { stg.x = 0; } 
            else { stg.x = 0; }
            if (1 <= stg.x && stg.x <= 4)
            {
                Cor(stg.ran, stg.Ai, stg.x);
            }
        }

        private void FormStart_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.Transparent;
            panel1.Parent = pictureBox1;
            life_lb.BackColor = Color.Transparent;
            life_lb.Parent = pictureBox1;       
            Timer_lb.BackColor = Color.Transparent;
            Timer_lb.Parent = pictureBox1;
            Time_lb.BackColor = Color.Transparent;
            Time_lb.Parent = pictureBox1;
            Time_lb.Text = stg.t.ToString();
            Stage_lb.BackColor = Color.Transparent;
            Stage_lb.Parent = pictureBox1;
            Stage_lb.Text = "Stage  " + (stg.Round + 1);
            Score_lb.BackColor = Color.Transparent;
            Score_lb.Parent = pictureBox1;
            stg.Score = 0;
            Score_lb.Text = "Score  " + (stg.Score);
            flowLayoutPanel2.BackColor = Color.Transparent;
            flowLayoutPanel2.Parent = pictureBox1;
            //db레벨불러오기  
            var Conn = new OleDbConnection(StrSQL);
            Conn.Open(); //DB열기
            string OleDb = "select * from account where (A_id ='" + ac.id + "')";
            var comm = new OleDbCommand(OleDb, Conn);
            OleDbDataReader myRead = comm.ExecuteReader();
            while (myRead.Read())
            {
                var strArray = new String[] {myRead["A_level"].ToString(),myRead["A_lifetem"].ToString(), myRead["A_timetem"].ToString() };            
                ac.level = (int)myRead["A_level"];
                ac.lifetem = (int)myRead["A_lifetem"];
                ac.timetem = (int)myRead["A_timetem"];
            }
            myRead.Close();
            Conn.Close();
            label4.Text = "x " + ac.lifetem;
            label3.Text = "x " + ac.timetem;
            pg_pic.Image = penguinpicstart.Images[ac.level-1];
            
        }

        int p = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {           
            Time_lb.Text = stg.t.ToString();
            if (stg.t == 10)   
            {
                //시작시 그림뜨도록한다. (폼 로드시 이거 넣으니까 그림이 안뜸)
                if (stg.count == 0)
                {
                    stg.Life = 3;
                Graphics g1 = flowLayoutPanel2.CreateGraphics();
                for (int i = 0; i < stg.Life; i++) //하트 계속 업데이트 해주기 (아이템쓰면 바로 하트 추가해야된다)
                {                  
                    g1.DrawImage(life, 1+(i*30), 1);
                }                
                    Rand(stg.y); //먼저 랜덤 숫자 뜨게한다 . 버튼을 누르면 옳은지 확인후 새로운 숫자 띄운다. 아니면 새로운 숫자 안띄움  
                    stg.count++; //시간 더했다가 다시 그시간으로 돌아왔을때 다시 실행 안되도록 한다. 
                }
            }
            if (stg.t != 0)
            {
                flowLayoutPanel2.Refresh();
                Graphics g1 = flowLayoutPanel2.CreateGraphics();
                for (int i = 0; i < stg.Life; i++)
                {
                    g1.DrawImage(life, 1 + (i * 30), 1);
                }
                if (stg.Life == 0) //목숨 0이면 끝남
                {
                    stg.stop += 1;
                    Stop();
                }
                if (ac.level == 4)  //레벨 4 펭귄 움직이게 하기
                {
                    if (p == 0)
                    {
                        pg_pic.Image = penguinpicstart.Images[ac.level - 1];
                        p++;
                    }
                    else if (p == 1)
                    {
                        pg_pic.Image = penguinpicstart.Images[ac.level ];
                        p--;
                    }
                    
                }
                stg.t--; 
            }
            else if (stg.t == 0) //시간 0이면 끝남
            {
                stg.stop += 1;
                Stop();
            }
         }
        public void Stop()
        {
            if (stg.stop == 1) //tick 때문에 메세지박스 한번만 띄우기 위해 stop을 따로 두었습니다.
            {   //db열어서 돈 값 가져오고 더하기
                var Connm = new OleDbConnection(StrSQL);
                Connm.Open(); //DB열기
                string OleDbm = "select * from account where (A_id ='" + ac.id + "')";
                var comm = new OleDbCommand(OleDbm, Connm);
                OleDbDataReader myRead = comm.ExecuteReader();
                while (myRead.Read())
                {
                    var strArray = new String[] {myRead["A_money"].ToString() };
                    ac.money = (int)myRead["A_money"];
                }
                myRead.Close();
                Connm.Close();

                ac.money += (int)(stg.Score / 10);
                MessageBox.Show("최종 점수 : " + stg.Score + "점");

               // MessageBox.Show(ac.bestscore + stg.Score.ToString() + ac.bestround + stg.Round);
                if(ac.bestscore < stg.Score) { ac.bestscore = stg.Score; }
                if(ac.bestround < stg.Round) { ac.bestround = stg.Round; }               
                var Conn = new OleDbConnection(StrSQL);
                Conn.Open();
                string OleDb = "update account set A_money = '" + ac.money + "',A_bestround = '" + ac.bestround + "'" +
                    ",A_bestscore = '" + ac.bestscore + "',A_lifetem = '" + ac.lifetem + "',A_timetem = '" + ac.timetem + "' where A_id = '" + ac.id + "' ";
                var commm = new OleDbCommand(OleDb, Conn);
                int ok = commm.ExecuteNonQuery();
                Conn.Close();
                this.Hide();
            }
        }
    }           
}
