using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayinPatlatma
{
    class Mayin
    {
        
        public static int mayinSayisi = 5;
        public  int[] X = new int[mayinSayisi];
        public  int[] Y = new int[mayinSayisi];
        public int[] patlayanX = new int[mayinSayisi];
        public int[] patlayanY = new int[mayinSayisi];
        

        Random rastgele = new Random();

        public void uret()
        {
            X[0] = rastgele.Next(1, OyunAlani.en);
            Y[0] = rastgele.Next(1, OyunAlani.boy);
            for (int i = 1; i < mayinSayisi; i++)
            {
                tekrar:
                X[i] = rastgele.Next(1, OyunAlani.en);
                Y[i] = rastgele.Next(1, OyunAlani.boy);
                for(int j=0;j<i;j++)
                {
                    if ((Math.Abs(X[j] - X[i]) > 2) || (Math.Abs(Y[j] - Y[i]) > 2))
                    {
                        //Bir mantık hatası yüzünden böyle yapmak zorunda kaldım
                    }
                    else
                    {
                        goto tekrar;
                    }
                }
                
            }
        }

        public void ciz()
        {

            for (int i = 0; i < mayinSayisi; i++)
            {
                Console.SetCursorPosition(patlayanX[i], patlayanY[i]);
                Console.Write("O");
            }
        }

    }
}
