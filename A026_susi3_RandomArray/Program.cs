using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A026_susi3_RandomArray
{
    class Program
    {
        // 문제: 주사위 2개를 던져서 나오는 숫자의 합을 구한다
        // 100만번 던진다
        // 출력:
        // 2가 나오는 횟수, 3이 나오는 횟수, ... 12가 나오는 횟수 몇번
        // 랜덤함수가 1부터 6까지 나오게 하는 법: r.Next(1,7);0
        static void Main(string[] args)
        {
            double[] sum = new double[11];

            Random r = new Random();

            int Num_sum1 = 0;
            int Num_sum2 = 0;
            double result = 0;

            for (double i = 1; i <= 1000000; i++)
            {
                Num_sum1 =r.Next(1, 7);
                Num_sum2 =r.Next(1, 7);

                result = Num_sum1 + Num_sum2;
                if (result == 2)
                    sum[0]++;
                if (result == 3)
                    sum[1]++;
                if (result == 4)
                    sum[2]++;
                if (result == 5)
                    sum[3]++;
                if (result == 6)
                    sum[4]++;
                if (result == 7)
                    sum[5]++;
                if (result == 8)
                    sum[6]++;
                if (result == 9)
                    sum[7]++;
                if (result == 10)
                    sum[8]++;
                if (result == 11)
                    sum[9]++;
                if (result == 12)
                    sum[10]++;

                Num_sum1 = 0;
                Num_sum2 = 0;
            }

            /*
            //더 쉽게 하는 법 시발
            for (int i = 0; i < 1000000; i++)
                sum[r.Next(1, 7) + r.Next(1, 7)]++;
                */

            for(int i =0;i<=10;i++)
                Console.WriteLine(i+2 + " 나온 횟수: " + sum[i]);
        }
    }
}
