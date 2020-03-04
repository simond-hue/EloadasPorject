using System;

namespace EloadasPorject
{
    public class Eloadas
    {
        private bool[,] foglalasok;

        public Eloadas(int sor, int hely)
        {
            if(sor <= 0 || hely <= 0)
            {
                throw new ArgumentException("Rossz paraméter");
            }
            this.Foglalasok = new bool[sor, hely];
        }
        public bool Lefoglal()
        {
            bool foglalt = true;
            for(int i = 0; i < foglalasok.GetLength(0); i++)
            {
                for(int j = 0; j < foglalasok.GetLength(1); j++)
                {
                    if(foglalasok[i,j] == false && foglalt)
                    {
                        foglalt = false;
                        foglalasok[i, j] = true;
                        break;
                    }
                    if (!foglalt) break;
                }
            }
            return !foglalt ? true : false;
        }
      
        public int SzabadHelyek { get {
                int count = 0;
                foreach (var item in this.Foglalasok)
                {
                    if(item == false)
                    {
                        count++;
                    }
                }
                return count;
            } }

        public bool[,] Foglalasok { get => foglalasok; set => foglalasok = value; }

        public bool Teli()
        {
            return this.SzabadHelyek == 0 ? true : false;
        }

        public bool Foglalt(int sorSzam, int helySzam)
        {
            if (sorSzam < 1 || helySzam < 1)
                throw new ArgumentException("Rossz paraméter");
            return this.Foglalasok[sorSzam - 1, helySzam - 1];
        }


    }
}
