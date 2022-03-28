Projeto Final - Elevador

    1- � solicitado ao usu�rio que coloque as informa��es sobre a quantidade de andares do pr�dio e a capacidade m�xima do elevador.

       Console.WriteLine("Informar quantidade de andares:");
       int maxandares = int.Parse(Console.ReadLine());

       Console.WriteLine("Informar n�mero m�ximo de pessoas:");
       int maxpessoas = int.Parse(Console.ReadLine());

    2-Ap�s � mostrado as op��o do elevador: se quer subir de andar, descer de andar, entrar uma pessoa ou sair uma pessoa. Aqui tamb�m foi adicionada um item caso queira parar o programa.
        
       Console.WriteLine(@"Escolha uma op��o:          
                                  1 - Subir
                                  2 - Descer
                                  3 - Entrar
                                  4 - Sair
                                  5 - Encerrar programa");

    3- � solicitado a escolha da a��o que deseja, entre as 5 acima citadas.

       string opcaoescolhida = Console.ReadLine();
       Console.Clear();

    
    4- Foi utilizado um recurso que foi chamado de "continuar" para a fun��o rodar sem parar at� for selecionado o item "5- Encerrar prograda".

        bool continuar = true; //inicia-se com continuar = true.

        case "5": continuar = false; break;  //caso escolha-se o item 5, o continuar vira false

        while (continuar) ;    //dessa forma, quando virar false, ele para o programa neste while


    5- Para as primeiras op��es, 1 a 4, o programa chama a um metodo na classe Elevador.

        switch (opcaoescolhida)
        {
            case "1": andar = novoSubir.Subir(maxandares, andar); break;
            case "2": andar = novoDescer.Descer(andar); break;
            case "3": pessoas = novoEntrar.Entrar(maxpessoas, pessoas); break;
            case "4": pessoas = novoEntrar.Sair(pessoas); break;
            case "5": continuar = false; break;
            default: Console.WriteLine("Escolha inv�lida!"); break;
        }


    6- Caso a escolha seja a numero 1, significa que quer subir de andar. 
        
    � primeiro verificado se j� est� no �ltimo andar, caso n�o esteja, ele incrementa um andar e devolve o novo andar em que se encontra.
    Caso contr�rio, ele informa que voc� j� est� no �ltimo andar.

        public int Subir(int maxandares, int andar)
        {

            if (andar < maxandares)
            {
                Console.WriteLine("Elevador Subiu");
                andar = andar + 1;
                Console.WriteLine("Voc� est� no andar {0}", andar);
            }
            else
            {
                Console.WriteLine("Voc� est� no �ltimo andar.");
            }

            return andar;
        }

    7- Caso a escolha seja a numero 2, significa que quer descer de andar. 
        
    � primeiro verificado se j� est� no t�rreo, caso n�o esteja, ele desce um andar e devolve o novo andar em que se encontra.
    Caso contr�rio, ele informa que voc� j� est� no t�rreo.

        public int Descer(int andar)
        {
            if (andar > 0)
            {
                Console.WriteLine("Elevador Desceu");
                andar = andar - 1;
                Console.WriteLine("Voc� est� no andar {0}", andar);
            }
            else
            {
                Console.WriteLine("Voc� est� no t�rreo.");
            }

            return andar;
        }

    8 - Caso a escolha seja a numero 3, significa que uma pessoa quer entrar no elevador. 
        
    � primeiro verificado se o elevador j� est� cheio, caso n�o esteja, ele aceita a nova pessoa e devolve o novo numero de pessoas dentro do elevador.
    Caso contr�rio, ele informa que n�o pode entrar mais ningu�m.

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
                Console.WriteLine("Quantidade m�xima de pessoas atingida.");
            }

            return pessoas;
        }

    9 - Caso a escolha seja a numero 4, significa que uma pessoa quer des�a no elevador. 
        
    � primeiro verificado se o elevador j� est� vazio, caso n�o esteja, ele aceita a sa�da da pessoa e devolve o novo numero de pessoas dentro do elevador.
    Caso contr�rio, ele informa que o elevador est� vazio.

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

    10- O elevador sempre inicializa vazio e no t�rreo.

        int andar = 0;
        int pessoas = 0;