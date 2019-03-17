using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinPatlatma
{
    class OyunAlani
    {
        public static int en = 30;
        public static int boy = 30;
        public int skor = 0;
        public  int kalanHak = 10;

        public void ciz()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < en+2; i++)
            {
                Console.Write("*");
                
            }
            for (int j = 1; j < boy+1; j++)
            {
                Console.SetCursorPosition(0, j);
                Console.Write("*");
            }
            for (int j = 1; j < boy + 1; j++)
            {
                Console.SetCursorPosition(en+1, j);
                Console.Write("*");
            }
            Console.SetCursorPosition(0, boy+1);
            for (int i = 0; i < en+2; i++)
            {
                Console.Write("*");
            }
        }
        
        public void bilgiYazdir()
        {
            Console.SetCursorPosition(1, 32);
            Console.WriteLine("Skor:" + skor);
            Console.WriteLine("Kalan Hak:" + kalanHak);
        }

        public bool hakVarMi()
        {
            if (kalanHak > 0)
                return true;
            else
                return false;
        }

        public bool mayinVarMi(Mayin mayin)
        {
            bool sonuc = false;
            for(int i=0;i<Mayin.mayinSayisi;i++)
            {
                if(((TemizlemeAraci.X==mayin.X[i])&&(TemizlemeAraci.Y == mayin.Y[i]))&& ((TemizlemeAraci.X != mayin.patlayanX[i]) && (TemizlemeAraci.Y != mayin.patlayanY[i])))
                {
                    Console.SetCursorPosition(35, 2);
                    
                    mayin.patlayanX[i] = mayin.X[i];
                    mayin.patlayanY[i] = mayin.Y[i];
                    sonuc = true;
                    skor++;
                }
                
                
            }
            return sonuc;
        }

        public void sonMesaji()
        {
            Console.SetCursorPosition(35, 6);
            Console.WriteLine("GAME OVER!   SKORUNUZ: "+skor);
        }

        public void oyunIlkBilgi()
        {
            Console.SetCursorPosition(42, 2);
            Console.WriteLine("MAYIN PATLATMA OYUNU");
            Console.SetCursorPosition(39, 6);
            Console.WriteLine("Yanlış Yapma Hakkınız:" + kalanHak);
            Console.SetCursorPosition(39, 7);
            Console.WriteLine("Oyundaki Mayin Sayisi:" + Mayin.mayinSayisi);
            Console.SetCursorPosition(39, 8);
            Console.WriteLine("Aracı (A) Hareket Ettirmek için Yön Tuşları");
            Console.SetCursorPosition(39, 9);
            Console.WriteLine("Mayın Tespiti için Space Tuşu" );
            Console.SetCursorPosition(39, 10);
            Console.WriteLine("Çıkmak için ESC");
        }

    }
}
