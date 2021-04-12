using System;

namespace rybareniProgramko
{
    class Program
    {
        static void Main(string[] args)
        {

        }
    }

    class Rybnicek
    {
        public int[,] vytvoreniRybnicku(int rozmerX, int rozmerY, int pocetRyb)
        {
            int[,] mistniRybnik = new int[rozmerX, rozmerY];

            naplneniRybniku(ref mistniRybnik, pocetRyb);

            return mistniRybnik;
        }

        private void naplneniRybniku(ref int[,] rybnik, int pocetRyb)
        {
            
            int x = 0;
            int y = 0;
            int pocitadlo = 0;
            do
            {
                Random rnd = new Random();
                int pravdepodobnost = rnd.Next(0, 2);
                if (x < rybnik.GetLength(0))
                {
                    rybnik[y, x] = pravdepodobnost;
                    pocitadlo += pravdepodobnost;
                    x++;
                }
                else if (x == rybnik.GetLength(0)-1 && y == rybnik.GetUpperBound(0)-1)
                {
                    x = 0;
                    y = 0;
                }
                else
                {
                    y++;
                    x = 0;
                }


            }
            while (pocitadlo <= pocetRyb);
        }

        private void hledaniVhodnehoLoviste(int velikostX, int velikostY, int[,] rybnik)
        {
            int[,] velikostLoviste = new int[velikostX, velikostY];
        }
    }
}

