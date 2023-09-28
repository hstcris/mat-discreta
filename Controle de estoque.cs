using System;
using System.Collections.Generic;

class Program
{
    static List<Livro> estoque = new List<Livro>();

    static void Main(string[] args)
    {
        ExibirMenu();
    }

    static void ExibirMenu() //abre o menu
    {
        Console.WriteLine("CONTROLE DE ESTOQUE\n[1] Novo \n[2] Listar Produtos \n[3] Remover Produtos \n[4] Entrada Estoque \n[5] Saída Estoque \n[0] Sair");
        int escolha = int.Parse(Console.ReadLine());

        switch (escolha)
        {
            case 1:
                AdicionarProduto();
                break;
            case 2:
                ListarProdutos();
                break;
            case 3:
                RemoverProduto();
                break;
            case 4:
                EntradaEstoque();
                break;
            case 5:
                SaidaEstoque();
                break;
            case 0:
                Console.WriteLine("Saindo do programa...");
                return;
            default:
                Console.WriteLine("Escolha inválida. Tente novamente.");
                break;
        }

        ExibirMenu(); // Chama o menu novamente
    }

    static void AdicionarProduto()
    { // lendo os valores que vão para as variaveis 
        Console.Write("Digite o nome do livro: ");
        string nome = Console.ReadLine();
      
        Console.WriteLine("Digite o valor: ");
        float valor = float.Parse(Console.ReadLine());
        Console.Write("Digite o nome do autor: ");
        string autor = Console.ReadLine();
        Console.Write("Digite a editora: ");
        string editora = Console.ReadLine();
        Console.Write("Digite o genero: ");
        string genero = Console.ReadLine();
      

        Livro produto = new Livro(nome, 0, valor, autor, editora, genero);
        estoque.Add(produto);

        Console.WriteLine("Produto adicionado com sucesso!");
    }

    static void ListarProdutos() // o que está dentro da lista
    {
        Console.WriteLine("Produtos em estoque:");
        // int indice = 1;
        foreach (Livro produto in estoque)
        {
            Console.WriteLine($"{produto.Nome} - Quantidade: {produto.Quantidade}");
        }
    }

    static void RemoverProduto()
    {
        Console.Write("Digite o nome do produto a ser removido: ");
        string nome = Console.ReadLine();

        Livro produtoRemover = estoque.Find(p => p.Nome == nome);
        if (produtoRemover != null)
        {
            estoque.Remove(produtoRemover);
            Console.WriteLine("Produto removido com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    static void EntradaEstoque()
    {
        Console.Write("Digite o nome do produto para entrada de estoque: ");
        string nome = Console.ReadLine();

        Livro produtoEntrada = estoque.Find(p => p.Nome == nome);
        if (produtoEntrada != null)
        {
            Console.Write("Digite a quantidade a ser adicionada ao estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            produtoEntrada.Quantidade += quantidade;
            Console.WriteLine("Entrada de estoque registrada com sucesso!");
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }

    static void SaidaEstoque()
    {
        Console.Write("Digite o nome do produto para saída de estoque: ");
        string nome = Console.ReadLine();

        Livro produtoSaida = estoque.Find(p => p.Nome == nome);
        if (produtoSaida != null)
        {
            Console.Write("Digite a quantidade a ser retirada do estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            if (quantidade <= produtoSaida.Quantidade)
            {
                produtoSaida.Quantidade -= quantidade;
                Console.WriteLine("Saída de estoque registrada com sucesso!");
            }
            else
            {
                Console.WriteLine("Quantidade insuficiente em estoque.");
            }
        }
        else
        {
            Console.WriteLine("Produto não encontrado.");
        }
    }
}

class Livro 
{
    public string Nome { get; set; }
    public int Quantidade { get; set; }
    public float Valor {get; set; }
    public string Autor {get; set; }
    public string Editora {get; set;}
    public string Genero {get; set;}
    public Livro(string nome, int quantidade, float valor, string autor, string editora, string genero)
    {
        Nome = nome;
        Valor = valor;
        Autor = autor;
        Editora = editora;
        Genero = genero;
        Quantidade = quantidade;
    }
}
