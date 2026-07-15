public class Livros
{
    private double _preco;
    private double _alugel;
    private int _quantidade;
    public string Nome {  get; set; }
    public int Codigo { get; set; }
    public int Quantidade
    {
        get
        {
            return _quantidade;
        }
        set
        {
            if(value <= 0)
            {
                Console.WriteLine("Valor negativo não aceitado");
            }
            else
            {
                _quantidade = value;
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
            else
            {
               _preco = value;
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
            else
            {
                _alugel = value;
            }
        }
    }
    public void descontoLivro(int valor)
    {
        Preco = Preco - (Preco * valor / 100.0);
    }
    public void aumentarPreco(double valor)
    {
        Preco += valor;
    }
    public void reduzirPreco(double valor)
    {
        Preco -= valor;
    }

    public void AlterarEstoque(int valor)
    {
        Quantidade = valor;
    }
}