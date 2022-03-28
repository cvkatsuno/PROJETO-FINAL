Projeto Final - Elevador

    1- É solicitado ao usuário que coloque as informações sobre a quantidade de andares do prédio e a capacidade máxima do elevador.

       Console.WriteLine("Informar quantidade de andares:");
       int maxandares = int.Parse(Console.ReadLine());

       Console.WriteLine("Informar número máximo de pessoas:");
       int maxpessoas = int.Parse(Console.ReadLine());

    2-Após é mostrado as opção do elevador: se quer subir de andar, descer de andar, entrar uma pessoa ou sair uma pessoa. Aqui também foi adicionada um item caso queira parar o programa.
        
       Console.WriteLine(@"Escolha uma opção:          
                                  1 - Subir
                                  2 - Descer
                                  3 - Entrar
                                  4 - Sair
                                  5 - Encerrar programa");

    3- É solicitado a escolha da ação que deseja, entre as 5 acima citadas.

       string opcaoescolhida = Console.ReadLine();
       Console.Clear();

    
    4- Foi utilizado um recurso que foi chamado de "continuar" para a função rodar sem parar até for selecionado o item "5- Encerrar prograda".

        bool continuar = true; //inicia-se com continuar = true.

        case "5": continuar = false; break;  //caso escolha-se o item 5, o continuar vira false

        while (continuar) ;    //dessa forma, quando virar false, ele para o programa neste while


    5- Para as primeiras opções, 1 a 4, o programa chama a um metodo na classe Elevador.

        switch (opcaoescolhida)
        {
            case "1": andar = novoSubir.Subir(maxandares, andar); break;
            case "2": andar = novoDescer.Descer(andar); break;
            case "3": pessoas = novoEntrar.Entrar(maxpessoas, pessoas); break;
            case "4": pessoas = novoEntrar.Sair(pessoas); break;
            case "5": continuar = false; break;
            default: Console.WriteLine("Escolha inválida!"); break;
        }


    6- Caso a escolha seja a numero 1, significa que quer subir de andar. 
        
    É primeiro verificado se já está no último andar, caso não esteja, ele incrementa um andar e devolve o novo andar em que se encontra.
    Caso contrário, ele informa que você já está no último andar.

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

    7- Caso a escolha seja a numero 2, significa que quer descer de andar. 
        
    É primeiro verificado se já está no térreo, caso não esteja, ele desce um andar e devolve o novo andar em que se encontra.
    Caso contrário, ele informa que você já está no térreo.

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

    8 - Caso a escolha seja a numero 3, significa que uma pessoa quer entrar no elevador. 
        
    É primeiro verificado se o elevador já está cheio, caso não esteja, ele aceita a nova pessoa e devolve o novo numero de pessoas dentro do elevador.
    Caso contrário, ele informa que não pode entrar mais ninguém.

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

    9 - Caso a escolha seja a numero 4, significa que uma pessoa quer desça no elevador. 
        
    É primeiro verificado se o elevador já está vazio, caso não esteja, ele aceita a saída da pessoa e devolve o novo numero de pessoas dentro do elevador.
    Caso contrário, ele informa que o elevador está vazio.

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

    10- O elevador sempre inicializa vazio e no térreo.

        int andar = 0;
        int pessoas = 0;