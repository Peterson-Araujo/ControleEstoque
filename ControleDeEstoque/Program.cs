using ControleDeEstoque;
using System.Globalization;

class Program
{
    private static void Main(string[] args)
    {
        string nome;
        int operacao, quantidade;
        double preco;

        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        nome = Console.ReadLine();
        Console.Write("Preço: ");
        preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade em estoque: ");
        quantidade = int.Parse(Console.ReadLine());

        Produto p = new Produto(nome, preco, quantidade);
        Console.WriteLine("Dados do produto: " + p);

        Console.Write("Digite a operação que deseja realizar: 1 - Adicionar, 2 - Remover ou 3 - Sair: ");
        operacao = int.Parse(Console.ReadLine());

        while(operacao != 3)
        {
            switch (operacao)
            {
                case 1:
                Console.Write("Digite o número de produtos a ser adicionado ao estoque: ");
                p.AdicionarProdutos(int.Parse(Console.ReadLine()));
                Console.WriteLine("Dados atualizados: " + p);
                break;

                case 2:
                Console.Write("Digite o número de produtos a ser removido do estoque: ");
                p.RemoverProdutos(int.Parse(Console.ReadLine()));
                Console.WriteLine("Dados atualizados: " + p);
                break;
            }

            Console.Write("Digite a operação que deseja realizar: 1 - Adicionar, 2 - Remover ou 3 - Sair: ");
            operacao = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Saindo...");
    }
}