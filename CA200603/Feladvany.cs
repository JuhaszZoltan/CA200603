using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200603
{
    class Feladvany
    {
        public string Kezdo { get; private set; }
        public int Meret { get; private set; }

        public int Kitoltottseg
        {
            get
            {
                int dbNemNulla = 0;

                foreach (var c in Kezdo)
                {
                    if (c != '0') dbNemNulla++;
                }

                return (int)(((float)dbNemNulla / Kezdo.Length) * 100);
            }
        }

        public Feladvany(string sor)
        {
            Kezdo = sor;
            Meret = (int)(Math.Sqrt(sor.Length));
        }

        public void Kirajzol()
        {
            for (int i = 0; i < Kezdo.Length; i++)
            {
                if (Kezdo[i] == '0')
                {
                    Console.Write(".");
                }
                else
                {
                    Console.Write(Kezdo[i]);
                }
                if (i % Meret == Meret - 1)
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
