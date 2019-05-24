using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A020_Omok
{
    class Revive
    {
        //4가지 정보
        //X, Y, 색깔(STONE), 수순
        //private int x;
        //private int y;
        //private STONE color;
        //private int Seq;

        //public void SetX(int x)
        //{
        //    this.x = x;
        //}

        //public int GetX()
        //{
        //    return x;
        //}

        // 속성으로 정의(앞글자는 대문자)
        public int X { get; set; }
        public int Y { get; set; }
        public STONE Stone { get; set; }
        public int Seq { get; set; }

        // 생성자: public, 리턴 타입 없고,
        // Class와 같은 이름인 메서드
        public Revive(int x, int y, STONE st, int seq)
        {
            x = x;
            y = y;
            Stone = st;
            seq = seq;
        }
        public Revive()
        {
            X = 0;
            Y = 0;
            Stone = STONE.none;
            Seq = 0;
        }
    }
}