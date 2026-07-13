public class Livros
{
    private double _preco;
    private double _alugel;
    public string Nome {  get; set; }
    public int Codigo { get; set; }
    public int quantidade
    {
        get
        {
            return quantidade;
        }
        set
        {
            if(value <= 0)
            {
                Console.WriteLine("Valor negativo não aceitado");
            }
        }
    }
    public double Preco
    {
        get
        {
            return _preco;
        }
        set
        {
            if (value <= 0 || value > 10000)
            {
                Console.WriteLine("o valor escrito é maior que 10000 ou menor que 0, por favor insira um valor valido");
            }
        }
    }
    public double Alugel
    {
        get
        {
            return _alugel;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("O valor do aluguel não aceita valores negativos, por favor insira um valor valido");
            }
            else if(value > 100)
            {
                Console.WriteLine("O valor do aluguel esta muito auto, por favor insira um valor abaixo de 100");
            }
        }
    }
    public void descontoLivro(int valor)
    {
       double desconto = Preco * valor / 100;
        Preco -= desconto;
    }
    public void aumentarPreco(int valor)
    {
        Preco += valor;
    }
    public void reduzirPreco(int valor)
    {
        Preco -= valor;
    }

    public void AlterarEstoque(int valor)
    {
        quantidade = valor;
    }
}