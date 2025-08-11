class Pessoa
{

    // Atribtos
    protected string? Nome;
    protected int Idade;

    //Método para apresentar os dados
    protected void ApresentarPessoa()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Idade: {Idade}");
    }
}