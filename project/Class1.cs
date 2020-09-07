using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace 방향키게임
{
    class loginExpt : Exception //로그인 예외처리
    {
        public loginExpt() { } 
        public loginExpt(string message) { }
    }
    class Account //로그인 정보 관련 클래스 
    {
        public string id { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public int bestround { get; set; }
        public int bestscore { get; set; }
        public int money { get; set; }
        public int level { get; set; }
        public int lifetem { get; set; }
        public int timetem { get; set; }
    }
    class Stage //게임 관련 클래스 
    {
        public int[] ran = new int[14];
        public int[] key = new int[14];
        public int Score { get; set; }
        public int Life { get; set; }
        public int Round = 0;
        public int round_count = 3; //방향키 몇개인지
        public int Ai = 0, x = 0, y = 0, t = 10, stop = 0, count = 0;
      
    }
    class Itembuy //아이템 관련 클래스
    {
        public string Itemname { get; set; }
        public int Itemmoney { get; set; }
        public int countitem { get; set; }
        public int totalcoin { get; set; }
        public int itemindex = 0;
        public int moneycount = 0;
    }
    class Lank //랭킹 관련 클래스
    {
        public int[] arr = new int[50];
        public int[] arr2 = new int[50];
    }

}
