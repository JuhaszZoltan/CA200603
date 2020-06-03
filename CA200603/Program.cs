using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CA200603
{
    class Program
    {
        static List<Feladvany> _feladvanyok;
        static int _input;
        static List<int> _indexek;
        static int _kivIndex;
        static Random _rnd = new Random();
        static void Main()
        {
            F03();
            F04();
            F05();
            F06();
            F07();
            F08();
            Console.ReadKey();
        }

        private static void F08()
        {
            var sw = new StreamWriter($@"..\..\res\sudoku{_input}.txt", false, Encoding.UTF8);

            for (int i = 0; i < _indexek.Count; i++)
            {
                sw.WriteLine(_feladvanyok[_indexek[i]].Kezdo);
            }
            sw.Close();
        }

        private static void F07()
        {
            Console.Write("7. feladat: ");
            Console.WriteLine("A feladvány kirajzolva:");
            _feladvanyok[_kivIndex].Kirajzol();
        }

        private static void F06()
        {
            Console.Write("6. feladat: ");
            Console.WriteLine($"feladvány kitöltöttsége: {_feladvanyok[_kivIndex].Kitoltottseg}%");
        }

        private static void F05()
        {
            Console.Write("5. feladat: ");
            Console.WriteLine("A kiválasztott feladvány:");
            _kivIndex = _indexek[_rnd.Next(_indexek.Count)];
            Console.WriteLine(_feladvanyok[_kivIndex].Kezdo);
        }

        private static void F04()
        {
            do
            {
                Console.Write("4. feladat: ");
                Console.Write("kérem a feladvány méretét [4..9]: ");
                _input = int.Parse(Console.ReadLine());
            } while (_input > 9 || _input < 4);


            _indexek = new List<int>();

            for (int i = 0; i < _feladvanyok.Count; i++)
            {
                if (_feladvanyok[i].Meret == _input)
                    _indexek.Add(i);
            }

                
            Console.WriteLine($"{_input}x{_input} méretű feladványból {_indexek.Count} darab van tárolva");
        }

        private static void F03()
        {
            _feladvanyok = new List<Feladvany>();
            var sr = new StreamReader(@"..\..\res\feladvanyok.txt");
            while (!sr.EndOfStream)
                _feladvanyok.Add(new Feladvany(sr.ReadLine()));
            sr.Close();

            Console.Write("3. feladat: ");
            Console.WriteLine($"Beolvasva {_feladvanyok.Count} feladvány");
        }
    }
}
