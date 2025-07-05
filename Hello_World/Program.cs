
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Security.Cryptography.X509Certificates;

class Utils
{

    public static void responseError()
    {

        Console.WriteLine("\nNão entendi muito bem. A sua resposta deve seguir o padrão: ");
        Console.WriteLine("[ S / Sim / Y / Yes]");
        Console.WriteLine("[ N / Não / Not]\n");
		Console.Write("Tente novamente, mas agora seguindo o padrão: ");

    }

    public static void okMethod()
    {

        Console.WriteLine("Ok.\n");

    }

}

class perfil
{
    public string nome { get; set; }
    public string idade { get; set; }

}

class Program
{

    static void Main(String[] args)
    {
        
        // Estado inicial do programa
        bool terminado = false;

        perfil P = new perfil();

        // Mensagens de boas-vindas
        Console.WriteLine("Bem-vindo(a) ao meu programa!");
        Console.WriteLine("Quero te conhecer melhor, então vou te fazer algumas perguntas.");

        // Uma simples pergunta ao usúario
        Console.Write("Você quer responder as perguntas? [S/N] ");
        string responseAsk = Console.ReadLine().ToLower();

        // Enquanto o programa não for terminado
        while (!terminado)
        {

            if (responseAsk == "s" || responseAsk == "sim" || responseAsk == "y" || responseAsk == "yes")
            {

                // PASS

            } else if (responseAsk == "n" || responseAsk == "nao" || responseAsk == "não" || responseAsk == "not")
            {

                Console.WriteLine("Ok. Você poderá responde-las, se quiser, mais tarde!");
                Environment.Exit(0);

            } else {

                Utils.responseError();
                responseAsk = Console.ReadLine().ToLower();
                continue;

            }

            Console.WriteLine("\nOk. Obrigado por cooperar. Agora vamos para a parte das perguntas... \n");

            Console.Write("Qual é o seu nome? ");
            P.nome = Console.ReadLine();
            Utils.okMethod();

            Console.Write("Quantos anos você tem? ");
            P.idade = Console.ReadLine();
            Utils.okMethod();

            terminado = true;

        }

        Console.WriteLine("Seu perfil: ");
        Console.WriteLine("- Nome: " + P.nome);
        Console.WriteLine("- Idade: " + P.idade);

    }

}
