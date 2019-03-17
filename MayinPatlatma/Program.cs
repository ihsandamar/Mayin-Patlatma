using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinPatlatma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(140,35);
            OyunAlani alan = new OyunAlani();
            TemizlemeAraci arac = new TemizlemeAraci();
            Mayin mayin = new Mayin();

            ConsoleKeyInfo basilan;
            arac.ciz();
            mayin.uret();
            //mayin.ciz(); // kontrol için ilk baştaki mayınları gözteren kod
            alan.oyunIlkBilgi();
            do
            {
                alan.ciz();
                basilan = Console.ReadKey();
                arac.hareketEttir(basilan);
                arac.ciz();
                
                
                if(alan.hakVarMi() == true)
                { 
                    if (basilan.Key == ConsoleKey.Spacebar)
                    {
                        if (alan.mayinVarMi(mayin) == true)
                        { 
                            Console.Beep();
                        }
                        else
                        {
                            alan.kalanHak--;
                            
                        }

                    }
                }
                else
                {
                    alan.sonMesaji();
                }
                mayin.ciz();
                alan.bilgiYazdir();
            } while (basilan.Key != ConsoleKey.Escape);
        }
    }
}
