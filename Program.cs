using System;

namespace bubleSorte
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Digite 1 para gerar");
            int[] num = new int[10];
            int i, aux, fim;
            Random r = new Random();
            //1 passo
            for(i = 0 ; i <=9 ; i++){
                num [i] = r.Next(50);
                Console.WriteLine(num[i]);
               
            }
            Console.WriteLine("-----------------------");
            // 2 passo
            for(fim = 8; fim >= 0 ; fim--)
            {
                for(i = 0 ; i <=fim ; i++)
                {
                    if(num[i] >= num[i + 1])
                    {
                        aux = num[i];
                        num[i] = num [i + 1];
                        num[i + 1] = aux;
                    }
                }
            }
            //  3 passo
            for(i = 0 ; i <= 9  ; i++)
            {
                Console.WriteLine(num[i]);
            }

        }

    }
}
