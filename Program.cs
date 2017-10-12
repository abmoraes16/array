using System;
using System.IO;

namespace array
{
    class Program
    {
        static string[] perguntas = File.ReadAllLines("perguntas.txt");
        static string[] respostas = new string[perguntas.Length];
        static StreamWriter sw = new StreamWriter("respostas.csv",true);
        static int continua;
        
        static void Main(string[] args)
        {
            do{
                for(int i=0; i<perguntas.Length;i++){
                    Console.WriteLine(perguntas[i]);
                    sw.Write(Console.ReadLine()+";");
                }
            
            

                
                
                sw.WriteLine();


                Console.WriteLine("Deseja continuar? Digita 1 para Sim, 2 para Não");
                continua = int.Parse(Console.ReadLine());

            }while(continua==1);
                sw.Close();

/*
            int[] idades = new int[5];

            //armazenando valores manualmente
            idades[0] = 1;
            idades[1] = 22;
            idades[2] = 23;
            idades[3] = 24;
            idades[4] = 25;

            //armazenando valores pelo for
            for(int i=0; i<5;i++){
                idades[i]=int.Parse(Console.ReadLine());
            }


            //exibindo valores pelo for
            for(int i=0; i<idades.Length;i++){
                Console.WriteLine(idades[i]);
            }

            //exibindo valores pelo foreach
            foreach(int idade in idades){
                Console.WriteLine(idade);
            }

 */


        }
    }
}
