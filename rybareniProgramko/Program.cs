using System;

namespace rybareniProgramko
{
    class Program
    {
        static void Main(string[] args)
        {
            Rybnicek rybnik = new Rybnicek();
            int [,] tu = rybnik.vytvoreniRybnicku(1000, 1000, 10000);
            rybnik.vhodneLoviste(30,30, tu);
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
                int ryba = rnd.Next(0, 2);
                if (x < rybnik.GetLength(0))
                {
                    rybnik[x, y] = ryba;
                    pocitadlo += ryba;
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

        public void vhodneLoviste(int velikostX, int velikostY, int[,] rybnik)
        {
            
            int poziceX = 0;
            int poziceY = 0;
            int soucetRyb = 0;
            int mezikrok;
            int vysledneRyby = 0;
            int poleX = rybnik.GetLength(0);
            int poleY = rybnik.GetLength(1);
            if (poleX < velikostX || poleY < velikostY)
                Console.WriteLine("CHYBA");
            for (int celkoveX = 0; celkoveX < poleX - velikostX; celkoveX++)
            {
                for (int celkoveY = 0; celkoveY < poleY - velikostY; celkoveY++)
                {
                    for (int x = 0; x < velikostX; x++)
                    {
                        for (int y = 0; y < velikostY; y++)
                        {
                            if (rybnik[x + celkoveX, y + celkoveY] == 1)
                                soucetRyb++;
                        }
                    }
                    mezikrok = soucetRyb;
                    soucetRyb = 0;
                    if (mezikrok > vysledneRyby)
                    {
                        vysledneRyby = mezikrok;
                        poziceX = celkoveX;
                        poziceY = celkoveY;
                    }
                }
            }
            Console.WriteLine($"Idealni loviste se nacahazi v {poziceX} a {poziceY}, obsahuje {vysledneRyby} ryb a ma rozmery {velikostX} {velikostY}");
        }
        
    }
}

