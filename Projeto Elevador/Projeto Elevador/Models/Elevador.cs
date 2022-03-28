using System;

namespace Projeto_Elevador.Models
{
    internal class Elevador
    {

        //metodo para SUBIR de andar
        //caso ainda não esteja no andar maximo(maxandares), ele sobe
        //caso contrário ele gera a mensagem "Você está no último andar."
        public int Subir(int maxandares, int andar)
        {
            
            if (andar < maxandares)
            {
                Console.WriteLine("Elevador Subiu");
                andar = andar + 1;
                Console.WriteLine("Você está no andar {0}", andar);
            }
            else
            {
                Console.WriteLine("Você está no último andar.");
            }

           return andar;
        }


        //metodo para DESCER de andar
        //caso não esteja no terreo, ele desce
        //caso contrário ele gera a mensagem "Você está no térreo."
        public int Descer(int andar)
        {
            if (andar > 0)
            {
                Console.WriteLine("Elevador Desceu");
                andar = andar - 1;
                Console.WriteLine("Você está no andar {0}", andar);
            }
            else
            {
                Console.WriteLine("Você está no térreo.");
            }

            return andar;
        }


        //metodo para ENTRAR pessoas
        //caso ainda não esteja com capacidade maxima de pessoas (maxpessas), ele deixa entrar
        //caso contrário ele gera a mensagem "Quantidade máxima de pessoas atingida."
        public int Entrar(int maxpessoas, int pessoas)
        {

            if (pessoas < maxpessoas)
            {
                Console.WriteLine("Entrou uma pessoa.");
                pessoas = pessoas + 1;
                Console.WriteLine("O elevador possui {0} pessoas", pessoas);
            }
            else
            {
                Console.WriteLine("Quantidade máxima de pessoas atingida.");
            }

            return pessoas;
        }


        //metodo para SAIR pessoas
        //caso não esteja vazio, ele diminiu a quantidade de pessoas
        //caso contrário ele gera a mensagem "Elevador vazio."
        public int Sair(int pessoas)
        {
            if (pessoas > 0)
            {
                Console.WriteLine("Saiu uma pessoa.");
                pessoas = pessoas - 1;
                Console.WriteLine("O elevador possui {0} pessoas", pessoas);
            }
            else
            {
                Console.WriteLine("Elevador vazio.");
            }

            return pessoas;
        }


    }
}
