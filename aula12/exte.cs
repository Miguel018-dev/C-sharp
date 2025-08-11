class Pessoa
{
    public string? Nome;
    public int Idade;
    // Método de apresentação

    public void Apresentação()
    {
        Console.WriteLine($"Olá, meu nome é {Nome}");
    }
    // Método de retorno
    public string VerificarIdade()
    {
        return Idade >= 18 ? "Maior de idade" : "Menor de idade";
    }
}
