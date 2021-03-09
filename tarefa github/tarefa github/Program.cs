using System;
using System.Threading;

namespace tarefa_github
{
    
   
        class Program
        {
        static void Main(string[] args)

        {

            string[] txt = new string[10];

            txt[1] = "A vida é um jogo de cartas";
            txt[2] = "Procuramos lá fora";
            txt[3] = "o que temos aqui dentro";
            txt[4] = "mas depois do jogo...";
            txt[5] = "é a morte que embaralha";
            txt[6] = "Eu realmente não me sinto bem";
            txt[7] = "Mesmo com o que mais preciso do lado";
            txt[8] = "Me sinto sozinho";
            txt[9] = "com todo mundo do lado";
             

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(txt[i]);
                Thread.Sleep(2000);
            }





        }
    }
}
