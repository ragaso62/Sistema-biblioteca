int escolha = 0;

List<Livros> livros = new();
livros.Add(new Livros
{
    Nome = "pika",
    Preco = 12.00,
    Alugel = 13,
    Codigo = 1,
    quantidade = 5,
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
}
