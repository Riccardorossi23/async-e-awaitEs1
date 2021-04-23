using System;
using System.Threading;
using System.Threading.Tasks;

namespace async_e_await
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] array = new int[100];
            RiempiArray(ref array);
            Console.WriteLine("Inserisci il numero: ");
            int n = int.Parse(Console.ReadLine());
            bool result = RicercaNumeroAsync(3, array).Result;
            Console.WriteLine(result);
            Console.ReadLine();
        }
         
         public static async Task<bool> RicercaNumeroAsync(int n, int[] array)
          {
            bool trovato = false;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    if (n == array[i])
                    {
                        trovato = true;
                    }


                }


            });
            return trovato;
        }
      
        static void RiempiArray(ref int[] array)
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                array[i] = r.Next(0, 100);

            }

        }

    }
}
