List<Livros> livros = new();
livros.Add(new Livros
{
    Nome = "pika",
    Preco = 12.00,
    Alugel = 13,
    Codigo = 1,
    quantidade = 5,
});

Console.WriteLine("");
foreach (Livros livro  in livros)
{
    Console.WriteLine(livro.Nome);
}