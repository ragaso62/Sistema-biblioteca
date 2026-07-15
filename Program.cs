int escolha = 0;

List<Livros> livros = new();
livros.Add(new Livros
{
    Nome = "pika",
    Preco = 12.00,
    Alugel = 13,
    Codigo = 1,
    Quantidade = 5,
});
livros.Add(new Livros
{
    Nome = "pika2"
});

Console.WriteLine("=== BEM VINDO AO SISTEMA BIBLIOTECA ===");
Console.WriteLine("o que deseja fazer hoje?\n1 - aumentar desconto\n2 - aumentar preço de um livro\n3 - diminuir preço de um livro\n4 - alterar estoque\n5 -listar livros\n 0 - sair");
escolha = int.Parse(Console.ReadLine());

if(escolha == 0)
{
    
}
else if (escolha == 1)
{
    Console.WriteLine("qual livro deseja dar desconto?");
    foreach (Livros livro  in livros)
    {
        Console.WriteLine($"{livro.Codigo} - {livro.Nome}");
    }
    int escolha2 = int.Parse(Console.ReadLine());
    Livros encontrar = livros.Find(l => l.Codigo == escolha2);
    if (encontrar != null)
    {
        Console.WriteLine($"livro encontrado {encontrar.Nome}");
        Console.WriteLine("qual desconto deseja aplicar?");
        int desconto = int.Parse(Console.ReadLine());
        encontrar.descontoLivro(desconto);
        Console.WriteLine($"O livro agora tem {desconto}% de desconto e estar com o valor R${encontrar.Preco}");
    }
    else
    {
        Console.WriteLine("livro não encontrado");
    }
}else if (escolha == 2)
{
    Console.WriteLine("qual livro deseja aumentar o preço?");
    foreach (Livros livro in livros)
    {
        Console.WriteLine($"{livro.Codigo} - {livro.Nome}");
    }
    int escolha2 = int.Parse(Console.ReadLine());
    Livros encontrar = livros.Find(l => l.Codigo == escolha2);
    if (encontrar != null)
    {
        Console.WriteLine($"livro encontrado {encontrar.Nome}");
        Console.WriteLine("qual o valor desejado para esse livro?");
        double valor = double.Parse(Console.ReadLine());
        encontrar.aumentarPreco(valor);
        Console.WriteLine($"O {encontrar.Nome} agora tem o valor de R${encontrar.Preco}");
    }
}else if (escolha == 3)
{
    Console.WriteLine("qual livro deseja diminuir o preço?");
    foreach (Livros livro in livros)
    {
        Console.WriteLine($"{livro.Codigo} - {livro.Nome}");
    }
    int escolha2 = int.Parse(Console.ReadLine());
    Livros encontrar = livros.Find(l => l.Codigo == escolha2);
    if (encontrar != null)
    {
        Console.WriteLine($"livro encontrado {encontrar.Nome}");
        Console.WriteLine($"Quanto deseja diminuir do preço desse livro? ({encontrar.Preco})");
        double reduzir = double.Parse(Console.ReadLine());
        encontrar.reduzirPreco(reduzir);
        Console.WriteLine($"O {encontrar.Nome} agora tem o valor de R${encontrar.Preco}");
    }
}else if (escolha == 4)
{
    Console.WriteLine("qual livro deseja alterar o estoque?");
    foreach (Livros livro in livros)
    {
        Console.WriteLine($"{livro.Codigo} - {livro.Nome}");
    }
    int escolha2 = int.Parse(Console.ReadLine());
    Livros encontrar = livros.Find(l => l.Codigo == escolha2);
    if (encontrar != null)
    {
        Console.WriteLine($"livro encontrado {encontrar.Nome}");
        Console.WriteLine("quantos livros deseja adicionar ao estoque?");
        int valor = int.Parse(Console.ReadLine());
        encontrar.aumentarEstoque(valor);
        Console.WriteLine($"O {encontrar.Nome} agora tem {encontrar.Quantidade} unidades em estoque");
    }
}else if (escolha == 5)
{
    Console.WriteLine("=== LISTA DE LIVROS ===");
    foreach (Livros livro in livros)
    {
        Console.WriteLine($"Nome: {livro.Nome} | Preço: {livro.Preco} | Aluguel: {livro.Alugel} | Estoque: {livro.Quantidade}");
    }
    Console.WriteLine("deseja comprar algum livro? (s/n)");
    string resposta = Console.ReadLine();
    if (resposta == "s" ||  resposta  == "S" || resposta == "sim")
    {
        Console.WriteLine("qual livro deseja comprar?");
        foreach (Livros livro in livros)
        {
            Console.WriteLine($"{livro.Codigo} - {livro.Nome}");
        }
        int escolha2 = int.Parse(Console.ReadLine());
        Livros encontrar = livros.Find(l => l.Codigo == escolha2);
        if (encontrar != null)
        {
            Console.WriteLine($"livro encontrado {encontrar.Nome}");
            Console.WriteLine("quantos livros deseja comprar?");
            int valor = int.Parse(Console.ReadLine());
            encontrar.reduzirEstoque(valor);
            Console.WriteLine($"O {encontrar.Nome} agora tem {encontrar.Quantidade} unidades em estoque");
        }
    }else if (resposta == "n" || resposta == "N" || resposta == "não")
    {
        Console.WriteLine("ok, obrigado por visitar nossa biblioteca");
    }
}