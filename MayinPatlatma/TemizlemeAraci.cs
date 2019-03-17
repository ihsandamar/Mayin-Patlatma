using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinPatlatma
{
    class TemizlemeAraci
    {
        public static int X=1;
        public static int Y=1;
        public char karakter = 'A';

        public void ciz()
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            Console.Write(karakter);
        }
        public void hareketEttir(ConsoleKeyInfo basilan)
        {
            if (basilan.Key == ConsoleKey.UpArrow)
                Y--;
            else if (basilan.Key == ConsoleKey.DownArrow)
                Y++;
            else if (basilan.Key == ConsoleKey.LeftArrow)
                X--;
            else if (basilan.Key == ConsoleKey.RightArrow)
                X++;

            if (X == OyunAlani.en+1)
                X = 1;
            if (X == 0)
                X = OyunAlani.en;
            if (Y == OyunAlani.boy+1)
                Y = 1;
            if (Y == 0)
                Y = OyunAlani.boy;
        }
    }
}
