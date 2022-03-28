using Intercom.Core;
using Projeto_Elevador.Models;
using System;

namespace Projeto_Elevador
{
    internal class Program
    {
     

        static void Main(string[] args)

        {
       
            Elevador novoSubir = new Elevador();
            Elevador novoDescer = new Elevador();
            Elevador novoEntrar = new Elevador();
            Elevador novoSair = new Elevador();


            //chamada para o elevador continuar funcionando até se escolher para "Encerrar programa"
            bool continuar = true; 


            // inicializar com elevador no terreo e sem pessoas dentro
            int andar = 0;   
            int pessoas = 0;


            //solicitando ao usuario a quantidade de andares no predio e a capacidade do elevador
            Console.WriteLine("Informar quantidade de andares:");
            int maxandares = int.Parse(Console.ReadLine());

            Console.WriteLine("Informar número máximo de pessoas:");
            int maxpessoas = int.Parse(Console.ReadLine());


            //execução do elevador, executar enquanto não for solicitado para "Encerrar programa"
            do
            {
                //Opções para o elevador - subir ou descer de andar, entrar ou sair pessoas
                Console.WriteLine(@"Escolha uma opção:          
                                  1 - Subir
                                  2 - Descer
                                  3 - Entrar
                                  4 - Sair
                                  5 - Encerrar programa");

                string opcaoescolhida = Console.ReadLine();
                Console.Clear();
                
                //para cada uma das escolhas, chama um metodo na classe Elevador
                switch (opcaoescolhida)
                {
                    case "1": andar = novoSubir.Subir(maxandares, andar);break;
                    case "2": andar = novoDescer.Descer(andar);break;
                    case "3": pessoas = novoEntrar.Entrar(maxpessoas, pessoas);break;
                    case "4": pessoas = novoEntrar.Sair(pessoas); break;
                    case "5": continuar = false; break;
                    default: Console.WriteLine("Escolha inválida!"); break;
                }

            }
            while (continuar);


        }

       
    }
}
