using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lotto_Daniel
{
    class LottoNumber
    {
        int[] lottozahl = new int[49];
        int[] ziehung = new int[7];
        List<int> temp = new List<int>();
        Random zufallszahl = new Random();

        public string getLottoNumbers6Aus49()
        {
            string numbers;


            for (int y = 1; y < 50; y++)
            {
                lottozahl[y - 1] = y;
            }



            int i = 0;
            while (i < 7)
            {
                int index = zufallszahl.Next(1, 50);
                if (!temp.Exists(x => x == index))
                {
                    temp.Add(index);
                    ziehung[i] = index;
                    i++;
                }
            }

            numbers = ziehung[0].ToString() + "  " + ziehung[1].ToString() + "  " + ziehung[2].ToString() + "  " + ziehung[3].ToString() + "  " + ziehung[4].ToString() + "  " + ziehung[5].ToString() + "  Superzahl: " + ziehung[6].ToString();


            return numbers;


        }
    }
}
