using ControleDeEstoque;
using System.Globalization;

class Program
{
    private static void Main(string[] args)
    {
        Produto p = new Produto();
        int operacao;

        Console.WriteLine("Entre com os dados do produto: ");
        Console.Write("Nome: ");
        p.Nome = Console.ReadLine();
        Console.Write("Preço: ");
        p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        Console.Write("Quantidade em estoque: ");
        p.Quantidade = int.Parse(Console.ReadLine());
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