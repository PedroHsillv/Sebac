
class Program

{

    //inicio declaraçao de armas e personagens
    static Arma GuardaChuva = new Arma("Guarda-Chuva", 10);
    static Arma MagiaNegra = new Arma("Magia Negra", 35);
    static Arma PacketTracer = new Arma("Packet Tracer", 20);
    static Arma Mao = new Arma("Mão", 5);
    static Arma Mouse = new Arma("Mouse", 10);
    static Arma Multimetro = new Arma("Multimetro Arcano", 20);
    static Arma ChatGpt = new Arma("Chat GPT ", 99);
    static Arma RelogioDoTempo = new Arma("Relógio do Tempo", 25);
    static Arma Robloc = new Arma("Roblox", 45);


    static Personagem Heroi = new Personagem("Herói", 100, 15, 5, Mao);
    static Personagem Hugo = new Personagem("Hugo", 200, 12, 0, MagiaNegra);
    static Personagem Thiago = new Personagem("Thiago", 80, 12, 0, PacketTracer);
    static Personagem Michael = new Personagem("Michael", 80, 12, 0, RelogioDoTempo);
    static Personagem Giba = new Personagem("Giba", 80, 12, 0, Multimetro);
    static Personagem AlunoCorrompido = new Personagem("Aluno Corrompido", 30, 10, 0, Mao);
    static Personagem Zelador = new Personagem("Zelador", 50, 15, 0, Mao);
    static Personagem Seguranca = new Personagem("Segurança", 50, 15, 0, Mao);


    class Item
    {
        public string Nome { get; set; }
        public int Dano { get; set; }

        public Item(string nome, int dano)
        {
            Nome = nome;
            Dano = dano;
        }
    }
    class Arma
    {
        public string Nome { get; set; }
        public int Dano { get; set; }

        public Arma(string nome, int dano)
        {
            Nome = nome;
            Dano = dano;
        }
    }





    static void MostrarTexto(string texto, int delayMilliseconds)
    {
        for (int i = 0; i < texto.Length; i++)
        {
            Console.Write(texto[i]);
            Thread.Sleep(delayMilliseconds);
        }
        Console.WriteLine();
    }

    static void MostrarTextoComParteVermelha(string textoAntesVermelho, string textoVermelho, string textoDepoisVermelho, int delayMilliseconds)
    {
        Console.Write(textoAntesVermelho);
        Console.ForegroundColor = ConsoleColor.Red;

        for (int i = 0; i < textoVermelho.Length; i++)
        {
            Console.Write(textoVermelho[i]);
            Thread.Sleep(delayMilliseconds);
        }

        Console.ResetColor();
        Console.Write(textoDepoisVermelho);
        Console.Write('\n');
    }

    static void MostrarTextoComParteAmarela(string textoAntesAmarelo, string textoAmarelo, string textoDepoisAmarelo, int delayMilliseconds)
    {
        Console.Write(textoAntesAmarelo);
        Console.ForegroundColor = ConsoleColor.Yellow;

        for (int i = 0; i < textoAmarelo.Length; i++)
        {
            Console.Write(textoAmarelo[i]);
            Thread.Sleep(delayMilliseconds);
        }

        Console.ResetColor();
        Console.Write(textoDepoisAmarelo);
        Console.Write('\n');
    }
    static void MostrarTextoVerde(string textoVerde, int delayMilliseconds)
    {
        Console.ForegroundColor = ConsoleColor.Green;

        for (int i = 0; i < textoVerde.Length; i++)
        {
            Console.Write(textoVerde[i]);
            Thread.Sleep(delayMilliseconds);
        }

        Console.ResetColor();
    }

    static void MostrarStatusHeroi(Personagem heroi)
    {
        Console.WriteLine("Status do Herói:");
        Console.WriteLine($"Nome: {heroi.Nome}");
        Console.WriteLine($"Vida: {heroi.Vida}");
        Console.WriteLine($"Arma Equipada: {heroi.ArmaEquipada.Nome}");
        Console.WriteLine("----------------------------------\n");
    }

    static void Falas(Personagem alvo)
    {
        Random teste = new Random();
        int fala = teste.Next(0, 4);
        if (alvo == Hugo)
        {

            string[] falahugo = new string[]
            {
                    " Você usou o GPT seu MERDA?! ",
                    " Me mostra como você fez isso ",
                    " ahan, me explica essa variável aqui ",
                    " GPT? HAHAHA não ovo esse nome há anos... "
            };

            MostrarTextoComParteVermelha("-", Hugo.Nome, falahugo[fala], 30);
        }
        if (alvo == Giba)
        {
            string[] falagiba = new string[]
            {
                    " shhhh grita baixo ",
                    " de acordo com a fifa o corinthians tem 2 mundiais ",
                    " de acordo com a fifa o corinthians tem 2 mundiais ",
                    " MAAAAAS de acordo com a fifa o corinthians tem 2 mundiais "
            };


            MostrarTextoComParteVermelha("-", Giba.Nome, falagiba[fala], 30);
        }
        if (alvo == Thiago)
        {
            string[] falathigas = new string[]
            {
                    " a atividade ja ta la na publica ",
                    " rapaziada o packet tracer ja ta la ",
                    " hoje é dia de calcular IP e fazer binario ",
                    " proxima aula eu explico isso ai (não explicou) "
            };


            MostrarTextoComParteVermelha("-", Thiago.Nome, falathigas[fala], 30);
        }
        if (alvo == Michael)
        {
            string[] falamichael = new string[]
            {
                    " USA LINUX CARA ",
                    " agora ceis clica aqui, depois aqui ó e agora aqui e depois aqui ó ",
                    " NÃO FALA DO MEU SKYRIM ",
                    " silencio galera do fundão "
            };


            MostrarTextoComParteVermelha("-", Michael.Nome, falamichael[fala], 30);
        }
        if (alvo == AlunoCorrompido)
        {

            string[] falaalunoc = new string[]
            {
                    " REDES DE NOVO NAAAAAAAAAAAO!! ",
                    " PACKET TRACER DE NOVO NAO AAAAAAA ",
                    " NINGUEM SABE OQUE PASSA NA CABEÇA DO PALHAÇO ",
                    " hoje é.... hoje é redes "
            };

            MostrarTextoComParteVermelha("-", AlunoCorrompido.Nome, falaalunoc[fala], 30);
        }
        if (alvo == Zelador)
        {

            string[] falazelador = new string[]
            {
                    " VOU PEGA QUEM TA RABISCANDO! ",
                    " ACABEI DE LIMPAR AQUI!!! ",
                    " VOU TE PASSAR O RODO! ",
                    " VOCÊ ESQUECEU ALGO? "
            };

            MostrarTextoComParteVermelha("-", Zelador.Nome, falazelador[fala], 30);
        }
        if (alvo == Seguranca)
        {

            string[] falaseguranca = new string[]
            {
                    " PARA DE PULAR CATRACA  ",
                    " PARADO. ",
                    " NÃO PODE IR PRO JARDIM ",
                    " CUIDADO "
            };

            MostrarTextoComParteVermelha("-", Seguranca.Nome, falaseguranca[fala], 30);
        }
    }

    static void Main(string[] args)
    {
        Lobby(Heroi, GuardaChuva, AlunoCorrompido, Mouse);
    }




    class Personagem
    {
        static void MostrarTexto(string texto, int delayMilliseconds)
        {
            for (int i = 0; i < texto.Length; i++)
            {
                Console.Write(texto[i]);
                Thread.Sleep(delayMilliseconds);
            }
            Console.WriteLine();
        }

        public string Nome { get; set; }
        public int Vida { get; set; }
        public int Dano { get; set; }
        public int QtdChaves { get; set; }
        public Arma ArmaEquipada { get; set; }

        public Personagem(string nome, int vida, int dano, int qtdchaves, Arma arma)
        {
            Nome = nome;
            Vida = vida;
            Dano = dano;
            QtdChaves = qtdchaves;
            ArmaEquipada = arma;
        }

        public void Atacar(Personagem alvo)
        {
            int danoTotal = ArmaEquipada.Dano;
            int chanceCritico = 15;
            Random random = new Random();
            int numeroAleatorio = random.Next(0, 100);

            if (numeroAleatorio < chanceCritico)
            {


                danoTotal *= 2;
                MostrarTextoComParteVermelha($"\n{Nome} atacou {alvo.Nome} com {ArmaEquipada.Nome} causando {danoTotal} de dano ", "CRÍTICO! \n", "", 10);
            }
            else
            {
                // Ataque normal
                MostrarTexto($"\n{Nome} atacou {alvo.Nome} com {ArmaEquipada.Nome} causando {danoTotal} de dano!\n", 10);
            }

            alvo.ReceberDano(danoTotal);
        }

        public void Atacar2(Personagem alvo)
        {
            int danoTotal = Dano;
            MostrarTexto($"\n{Nome} atacou {alvo.Nome} causando {danoTotal} de dano!\n", 10);
            alvo.ReceberDano(danoTotal);
        }
        public void ReceberDano(int quantidade)
        {

            Vida -= quantidade;
            if (Vida <= 0)
            {
                string escolha;
                Vida = 0;
                Console.ForegroundColor = ConsoleColor.Red;
                MostrarTexto($"{Nome} foi derrotado!", 20);
                Console.ResetColor();
                escolha = Console.ReadLine();
                if (Heroi.Vida <= 0)
                {
                    while (escolha.ToLower() != "sim" || escolha.ToLower() != "nao")
                    {

                        Console.WriteLine("Você morreu, deseja recomeçar a sala ?");
                        escolha = Console.ReadLine();
                        if (escolha.ToLower() == "sim")
                        {
                            Heroi.Vida = 100;
                            ReiniciarSalaAtual();
                        }
                        else if (escolha.ToLower() == "nao")
                        {
                            Console.WriteLine("Você decidiu sair do jogo.");
                            Environment.Exit(0);
                        }
                        else
                        {
                            MostrarTextoComParteVermelha("", "Opção Inválida!", "", 30);
                        }
                    }
                }
            }
            else
            {
                MostrarTexto($"{Nome} recebeu {quantidade} de dano. Vida restante: {Vida}\n", 20);
            }
        }

        static void ReiniciarSalaAtual()
        {
            switch (salaAtual)
            {
                case "lobby":
                    Lobby(Heroi, Heroi.ArmaEquipada, AlunoCorrompido, Mouse);
                    break;
                case "Sala1":
                    Sala1(Heroi);
                    break;
                case "Sala2":
                    Sala2(Heroi);
                    break;

                case "Sala3":
                    Sala3(Heroi);
                    break;

                case "Sala4":
                    Sala4(Heroi);
                    break;

                case "Sala5":
                    Sala5(Heroi);
                    break;

                case "Sala6":
                    Sala6(Heroi);
                    break;

                case "Sala7":
                    Sala7(Heroi);
                    break;

                case "Sala8":
                    Sala8(Heroi);
                    break;

                case "Sala9":
                    Sala9(Heroi);
                    break;

                case "Sala10":
                    Sala10(Heroi);
                    break;

                case "Sala11":
                    Sala11(Heroi);
                    break;

                case "Sala12":
                    Sala12(Heroi);
                    break;

                case "SalaHugo":
                    SalaHugo(Heroi);
                    break;
                // Adicione os casos para outras salas aqui
                default:
                    Console.WriteLine("Sala não encontrada. Voltando para o Lobby.");
                    Lobby(Heroi, Heroi.ArmaEquipada, AlunoCorrompido, Mouse);
                    break;
            }
        }

    }
    static string salaAtual;






    //inicio salas

    static void Lobby(Personagem heroi, Arma GuardaChuva, Personagem AlunoCorrompido, Arma mouse)
    {
        Console.Title = "SEBAC";
        salaAtual = "Lobby";
        Console.Clear();
        MostrarTexto("Salão Principal\n", 50);



        MostrarTexto("Você encontrou 2 portas, em qual deseja entrar?\nESQUERDA OU DIREITA\n", 50);
        string escolha;

        escolha = Console.ReadLine();
        if (escolha.ToLower() == "esquerda")
        {
            Console.Clear();
            MostrarTexto("Sala Assombrada\n", 100);
            MostrarTexto("Você encontrou um baú, para abrir vai precisar gastar uma chave, deseja abrir?", 50);
            Console.Write("\n-");
            escolha = Console.ReadLine();
            if (escolha.ToLower() == "sim")
            {
                MostrarTextoComParteAmarela("Você abriu o baú e encontrou um ", GuardaChuva.Nome, " seu dano é de " + GuardaChuva.Dano, 20);
                MostrarTexto("Deseja equipar?", 20);

                escolha = Console.ReadLine();
                if (escolha.ToLower() == "sim")
                {
                    heroi.ArmaEquipada = GuardaChuva;
                }
                else
                {
                    MostrarTexto("Péssima Escolha...", 50);
                }
            }
            Sala1(heroi);
        }
        else if (escolha.ToLower() == "direita")
        {
            Console.Clear();
            MostrarTexto(" Estacionamento Dos Fantasmas\n ", 100);
            MostrarTexto("Você encontrou um baú, para abrir vai precisar gastar uma chave, deseja abrir?", 50);
            Console.Write("\n-");
            escolha = Console.ReadLine();
            if (escolha.ToLower() == "sim")
            {
                MostrarTextoComParteAmarela("Você abriu o baú e encontrou um ", mouse.Nome, " seu dano é de " + mouse.Dano, 20);
                MostrarTexto("Deseja equipar?", 20);

                escolha = Console.ReadLine();
                if (escolha.ToLower() == "sim")
                {
                    heroi.ArmaEquipada = mouse;
                }
                else
                {
                    MostrarTexto("Péssima Escolha", 50);
                }
            }
            Sala2(heroi);
        }
        else
        {
            MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            Lobby(Heroi, GuardaChuva, AlunoCorrompido, mouse);

        }
    }
    //Sala Batalha 
    static void Sala1(Personagem heroi)
    {

        salaAtual = "Sala1";
        Console.Clear();
        AlunoCorrompido.Vida = 30;
        MostrarTexto("Sala Assombrada\n", 50);
        MostrarTextoComParteVermelha("Você encontrou um ", "Aluno Corrompido", " CUIDADO!", 15);
        while (AlunoCorrompido.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Aluno Corrompido: \n");

            string input = Console.ReadLine();

            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(AlunoCorrompido);
            }
            if (AlunoCorrompido.Vida > 0)
            {
                Falas(AlunoCorrompido);
                AlunoCorrompido.Atacar2(heroi);
            }
        }
        MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);

        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "direita" || escolha.ToLower() != "esquerda")
        {

            if (escolha.ToLower() == "esquerda")
            {
                Sala3(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "direita")
            {
                Sala4(heroi);
                Console.Clear();
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTexto("Sala Assombrada\n", 50);
            MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);

            escolha = Console.ReadLine();
            Console.Clear();
        }
    }

    static void Sala2(Personagem heroi)
    {
        salaAtual = "Sala2";
        AlunoCorrompido.Vida = 30;
        Console.Clear();
        MostrarTexto("Estacionamento Dos Fantasmas\n", 50);
        MostrarTextoComParteVermelha("Você encontrou um ", "Aluno Corrompido", " CUIDADO!", 15);
        while (AlunoCorrompido.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Aluno Corrompido: \n");

            string input = Console.ReadLine();

            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(AlunoCorrompido);
            }
            if (AlunoCorrompido.Vida > 0)
            {
                Falas(AlunoCorrompido);
                AlunoCorrompido.Atacar(heroi);
            }
        }
        MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 25);


        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "direita" || escolha.ToLower() != "esquerda")
        {

            if (escolha.ToLower() == "esquerda")
            {
                Sala4(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "direita")
            {
                Sala5(heroi);
                Console.Clear();
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTexto("Estacionamento Dos Fantasmas\n", 50);
            MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);

            escolha = Console.ReadLine();
            Console.Clear();
        }
    }
    //Sala Bau
    static void Sala3(Personagem heroi)
    {
        salaAtual = "Sala3";
        string escolha;
        Console.Clear();
        MostrarTexto("Refeitorio Abandonado\n", 50);
        MostrarTexto("Você encontrou um Baú, vai precisar usar uma chave para abrir o Baú, deseja abrir?", 20);
        escolha = Console.ReadLine();

        if (escolha.ToLower() == "sim")
        {
            MostrarTextoComParteAmarela("Você encontrou um(a) ", RelogioDoTempo.Nome, " seu dano é de " + RelogioDoTempo.Dano, 50);
            MostrarTexto("Deseja equipar?", 20);

            escolha = Console.ReadLine();
            if (escolha.ToLower() == "sim")
            {
                heroi.ArmaEquipada = RelogioDoTempo;
            }
            else
            {
                MostrarTexto("Péssima Escolha", 50);
            }
        }
        MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);
        escolha = Console.ReadLine();

        while (escolha.ToLower() != "direita" || escolha.ToLower() != "esquerda")
        {

            if (escolha.ToLower() == "esquerda")
            {
                Sala6(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "direita")
            {
                Sala7(heroi);
                Console.Clear();
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTexto("Refeitorio Abandonado\n", 50);
            MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);

            escolha = Console.ReadLine();
            Console.Clear();
        }
    }

    static void Sala4(Personagem heroi)
    {
        salaAtual = "Sala4";
        Console.Clear();
        AlunoCorrompido.Vida = 30;
        MostrarTexto("Corredor Dos Enigmas Enigmaticos\n", 50);
        MostrarTextoComParteVermelha("Você encontrou um ", "Aluno Corrompido", " CUIDADO!", 15);
        while (AlunoCorrompido.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Aluno Corrompido: \n");
            string input = Console.ReadLine();

            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(AlunoCorrompido);
            }
            if (AlunoCorrompido.Vida > 0)
            {
                Falas(AlunoCorrompido);
                AlunoCorrompido.Atacar(heroi);
            }
        }
        MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 25);


        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "direita" || escolha.ToLower() != "esquerda")
        {

            if (escolha.ToLower() == "esquerda")
            {
                Sala7(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "direita")
            {
                Sala8(heroi);
                Console.Clear();
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTexto("Corredor Dos Enigmas Enigmaticos\n", 50);
            MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);

            escolha = Console.ReadLine();
            Console.Clear();
        }
    }
    static void Sala5(Personagem heroi)
    {
        salaAtual = "Sala5";
        string escolha;
        Console.Clear();
        MostrarTexto("Jardim Do Esquecimento\n", 50);
        MostrarTexto("Você encontrou um Baú, vai precisar usar uma chave para abrir o Baú, deseja abrir?", 20);

        escolha = Console.ReadLine();
        if (escolha.ToLower() == "sim")
        {
            MostrarTextoComParteAmarela("Você encontrou um(a) ", Multimetro.Nome, " seu dano é de " + Multimetro.Dano, 50);
            MostrarTexto("Deseja equipar?", 20);
            escolha = Console.ReadLine();

            if (escolha.ToLower() == "sim")
            {
                heroi.ArmaEquipada = Multimetro;
            }
            else
            {
                MostrarTexto("Péssima Escolha", 50);
            }
        }
        MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);
        escolha = Console.ReadLine();

        while (escolha.ToLower() != "direita" || escolha.ToLower() != "esquerda")
        {

            if (escolha.ToLower() == "esquerda")
            {
                Sala8(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "direita")
            {
                Sala9(heroi);
                Console.Clear();
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTexto("Jardim Do Esquecimento\n", 50);
            MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);
            escolha = Console.ReadLine();

            Console.Clear();
        }
    }

    static void Sala6(Personagem heroi)
    {
        salaAtual = "Sala6";
        Console.Clear();
        MostrarTexto("Auditorio Da Sombras\n", 50);
        MostrarTextoComParteVermelha("Você encontrou um ", "Segurança", " CUIDADO!", 15);
        while (Seguranca.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Segurança: \n");
            string input = Console.ReadLine();

            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(Seguranca);
            }
            if (Seguranca.Vida > 0)
            {
                Falas(Seguranca);
                Seguranca.Atacar2(heroi);
            }
        }
        MostrarTexto("Você encontrou uma porta a sua direita\nDeseja seguir?", 1);


        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "sim" || escolha.ToLower() != "nao")
        {

            if (escolha.ToLower() == "sim")
            {
                Sala10(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "nao")
            {
                MostrarTexto("Você acha melhor voltar pra casa, foi uma jornada digna.....", 100);
                Console.Read();
                Environment.Exit(0);
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTexto("Auditorio Das Sombras\n", 50);
            MostrarTexto("Você encontrou uma porta a sua direita\nDeseja seguir?", 10);
            escolha = Console.ReadLine();
            Console.Clear();
        }
    }

    static void Sala7(Personagem heroi)
    {
        salaAtual = "Sala7";
        Console.Clear();
        MostrarTexto("Salão Das Projeções Sombrias\n", 50);
        MostrarTextoComParteVermelha("Você encontrou um ", "Zelador", " CUIDADO!", 15);
        while (Zelador.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Zelador: \n");
            string input = Console.ReadLine();

            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(Zelador);
            }
            if (Zelador.Vida > 0)
            {
                Falas(Zelador);
                Zelador.Atacar2(heroi);
            }
        }
        string escolha2;
        MostrarTexto("Você encontrou um Baú, vai precisar usar uma chave para abrir o Baú, deseja abrir?", 20);
        escolha2 = Console.ReadLine();

        if (escolha2.ToLower() == "sim")
        {
            MostrarTextoComParteAmarela("Você encontrou um(a) ", Robloc.Nome, " seu dano é de " + Robloc.Dano, 50);
            MostrarTexto("Deseja equipar?", 20);

            escolha2 = Console.ReadLine();
            if (escolha2.ToLower() == "sim")
            {
                heroi.ArmaEquipada = Robloc;
            }
            else
            {
                MostrarTexto("Péssima Escolha", 50);
            }
        }
        MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);


        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "direita" || escolha.ToLower() != "esquerda")
        {

            if (escolha.ToLower() == "esquerda")
            {
                Sala10(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "direita")
            {
                Sala11(heroi);
                Console.Clear();
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTexto("Salão Das Projeções Sombrias\n", 50);
            MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);
            escolha = Console.ReadLine();

            Console.Clear();
        }
    }
    static void Sala8(Personagem heroi)
    {
        salaAtual = "Sala8";
        Console.Clear();
        MostrarTexto("Laboratorio Das Poções Sombrias\n", 50);
        MostrarTextoComParteVermelha("Você encontrou um ", "Segurança", " CUIDADO!", 15);
        while (Seguranca.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Segurança: \n");
            string input = Console.ReadLine();


            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(Seguranca);
            }
            if (Seguranca.Vida > 0)
            {
                Falas(Seguranca);
                Seguranca.Atacar2(heroi);
            }
        }
        string escolha2;
        MostrarTexto("Você encontrou um Baú, vai precisar usar uma chave para abrir o Baú, deseja abrir?", 20);
        escolha2 = Console.ReadLine();

        if (escolha2.ToLower() == "sim")
        {
            MostrarTextoComParteAmarela("Você encontrou um(a) ", Robloc.Nome, " seu dano é de " + Robloc.Dano, 50);
            MostrarTexto("Deseja equipar?", 20);
            escolha2 = Console.ReadLine();
            if (escolha2.ToLower() == "sim")
            {
                heroi.ArmaEquipada = Robloc;
            }
            else
            {
                MostrarTexto("Péssima Escolha", 50);
            }
        }
        MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);


        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "direita" || escolha.ToLower() != "esquerda")
        {

            if (escolha.ToLower() == "esquerda")
            {
                Sala11(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "direita")
            {
                Sala12(heroi);
                Console.Clear();
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTexto("Laboratorio Das Poções Sombrias\n", 50);
            MostrarTexto("Você encontrou mais duas portas\nDeseja ir para esquerda ou direita?", 1);

            escolha = Console.ReadLine();
            Console.Clear();
        }
    }

    static void Sala9(Personagem heroi)
    {
        salaAtual = "Sala9";
        Console.Clear();
        MostrarTexto("Biblioteca Dos Livros Esquecidos\n", 50);
        MostrarTextoComParteVermelha("Você encontrou um ", "Zelador", " CUIDADO!", 15);
        while (Zelador.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Zelador: \n");
            string input = Console.ReadLine();


            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(Zelador);
            }
            if (Zelador.Vida > 0)
            {
                Falas(Zelador);
                Zelador.Atacar2(heroi);
            }
        }
        MostrarTexto("Você encontrou uma porta a sua esquerda\nDeseja seguir?", 1);


        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "sim" || escolha.ToLower() != "nao")
        {

            if (escolha.ToLower() == "sim")
            {
                Sala12(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "nao")
            {
                MostrarTexto("Você acha melhor voltar pra casa, foi uma jornada digna.....", 100);
                Console.Read();
                Environment.Exit(0);
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTexto("Biblioteca Dos Livros Esquecidos\n", 50);
            MostrarTexto("Você encontrou uma porta a sua direita\nDeseja seguir?", 10);

            escolha = Console.ReadLine();
            Console.Clear();
        }
    }
    //inicio batalha dos bosses 
    static void Sala10(Personagem heroi)
    {
        Giba.Vida = 80;
        salaAtual = "Sala10";
        Console.Clear();
        MostrarTextoComParteVermelha("Salão do Boss: ", "Giba", "\n", 100);
        MostrarTextoComParteVermelha("Você encontrou ", "Giba", " CUIDADO!", 15);
        while (Giba.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Giba: \n");
            string input = Console.ReadLine();


            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(Giba);
            }
            if (Giba.Vida > 0)
            {
                Falas(Giba);
                Giba.Atacar2(heroi);
            }
        }
        string escolha2;
        MostrarTexto("Você encontrou um Baú, vai precisar usar uma chave para abrir o Baú, deseja abrir?", 20);
        escolha2 = Console.ReadLine();

        if (escolha2.ToLower() == "sim")
        {
            MostrarTextoComParteAmarela("Você encontrou um(a) ", ChatGpt.Nome, " seu dano é de " + ChatGpt.Dano, 50);
            MostrarTexto("Deseja equipar?", 20);

            escolha2 = Console.ReadLine();
            if (escolha2.ToLower() == "sim")
            {
                heroi.ArmaEquipada = ChatGpt;
            }
            else
            {
                MostrarTexto("Péssima Escolha", 50);
            }
        }
        MostrarTexto("Você encontrou uma porta a sua direita\nDeseja seguir?", 1);


        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "sim" || escolha.ToLower() != "nao")
        {

            if (escolha.ToLower() == "sim")
            {
                SalaHugo(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "nao")
            {
                MostrarTexto("Você acha melhor voltar pra casa, foi uma jornada digna.....", 100);
                Console.Read();
                Environment.Exit(0);
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTextoComParteVermelha("Salão do Boss: ", "Giba", "\n", 100);
            MostrarTexto("Você encontrou uma porta a sua direita\nDeseja seguir?", 10);

            escolha = Console.ReadLine();
            Console.Clear();
        }
    }
    static void Sala11(Personagem heroi)
    {
        Michael.Vida = 80;
        salaAtual = "Sala11";
        Console.Clear();
        MostrarTextoComParteVermelha("Salão do Boss: ", "Michael", "\n", 100);
        MostrarTextoComParteVermelha("Você encontrou ", "Michael", " CUIDADO!", 15);
        while (Michael.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Michael: \n");

            string input = Console.ReadLine();

            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(Michael);
            }
            if (Michael.Vida > 0)
            {
                Falas(Michael);
                Michael.Atacar2(heroi);
            }
        }
        string escolha2;
        MostrarTexto("Você encontrou um Baú, vai precisar usar uma chave para abrir o Baú, deseja abrir?", 20);
        escolha2 = Console.ReadLine();

        if (escolha2.ToLower() == "sim")
        {
            MostrarTextoComParteAmarela("Você encontrou um(a) ", ChatGpt.Nome, " seu dano é de " + ChatGpt.Dano, 50);
            MostrarTexto("Deseja equipar?", 20);

            escolha2 = Console.ReadLine();
            if (escolha2.ToLower() == "sim")
            {
                heroi.ArmaEquipada = ChatGpt;
            }
            else
            {
                MostrarTexto("Péssima Escolha", 50);
            }
        }
        MostrarTexto("Você encontrou uma porta a sua frente\nDeseja seguir?", 1);


        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "sim" || escolha.ToLower() != "nao")
        {

            if (escolha.ToLower() == "sim")
            {
                SalaHugo(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "nao")
            {
                MostrarTexto("Você acha melhor voltar pra casa, foi uma jornada digna.....", 100);
                Console.Read();
                Environment.Exit(0);
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTextoComParteVermelha("Salão do Boss: ", "Michael", "\n", 100);
            MostrarTexto("Você encontrou uma porta a sua direita\nDeseja seguir?", 10);

            escolha = Console.ReadLine();
            Console.Clear();
        }
    }

    static void Sala12(Personagem heroi)
    {
        Thiago.Vida = 80;
        salaAtual = "Sala12";
        Console.Clear();
        MostrarTextoComParteVermelha("Salão do Boss: ", "Thiago", "\n", 100);
        MostrarTextoComParteVermelha("Você encontrou ", "Thiago", " CUIDADO!", 15);
        while (Thiago.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Thiago: \n");

            string input = Console.ReadLine();

            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(Thiago);
            }
            if (Thiago.Vida > 0)
            {
                Falas(Thiago);
                Thiago.Atacar2(heroi);
            }
        }
        string escolha2;
        MostrarTexto("Você encontrou um Baú, vai precisar usar uma chave para abrir o Baú, deseja abrir?", 20);
        escolha2 = Console.ReadLine();

        if (escolha2.ToLower() == "sim")
        {
            MostrarTextoComParteAmarela("Você encontrou um(a) ", ChatGpt.Nome, " seu dano é de " + ChatGpt.Dano, 50);
            MostrarTexto("Deseja equipar?", 20);

            escolha2 = Console.ReadLine();
            if (escolha2.ToLower() == "sim")
            {
                heroi.ArmaEquipada = ChatGpt;
            }
            else
            {
                MostrarTexto("Péssima Escolha", 50);
            }
        }
        MostrarTexto("Você encontrou uma porta a sua frente\nDeseja seguir?", 1);


        string escolha;
        escolha = Console.ReadLine();
        while (escolha.ToLower() != "sim" || escolha.ToLower() != "nao")
        {

            if (escolha.ToLower() == "sim")
            {
                SalaHugo(heroi);
                Console.Clear();
            }
            else if (escolha.ToLower() == "nao")
            {
                MostrarTexto("Você acha melhor voltar pra casa, foi uma jornada digna.....", 100);
                Console.Read();
                Environment.Exit(0);
            }
            else
            {
                MostrarTextoComParteVermelha("", "LUGAR ERRADO...", "", 200);
            }
            MostrarTextoComParteVermelha("Salão do Boss: ", "Thiago", "\n", 100);
            MostrarTexto("Você encontrou uma porta a sua direita\nDeseja seguir?", 10);

            escolha = Console.ReadLine();
            Console.Clear();
        }
    }
    static void SalaHugo(Personagem heroi)
    {
        Hugo.Vida = 200;
        salaAtual = "SalaHugo";
        Console.Clear();
        MostrarTextoComParteVermelha("Salão do Boss: ", "Hugo", "\n", 100);
        MostrarTextoComParteVermelha("Você encontrou ", "Hugo", " CUIDADO!", 15);
        while (Hugo.Vida > 0)
        {
            Console.WriteLine("Digite 'atacar' para atacar o Hugo: \n");

            string input = Console.ReadLine();

            if (input.ToLower() == "atacar")
            {
                heroi.Atacar(Hugo);
            }

            if (Hugo.Vida > 0)
            {
                Falas(Hugo);
                Hugo.Atacar2(heroi);
            }
        }
        MostrarTextoVerde("E assim o heroi chega ao fim de sua jornada....", 200);
        Console.ReadLine();
        Environment.Exit(0);
    }

}

































































































//Bolsonaro, o povo não quer saber de cartucho de carabina...o povo quer GOZAAAAR



//Lula, o povo não quer saber de gozar...o povo quer cartucho de carabina hahahaha pow pow