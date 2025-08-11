class Colaborador : Pessoa
{
    // Atributos
    private string? _cargo;
    private double _salario;

    //Método para apresentar os dados
    public Colaborador(string nome, int idade, string cargo, double salario)
    {
        Nome = nome;
        Idade = idade;
        _cargo = cargo;
        _salario = salario;

        ApresentarPessoa();
        ApresentarColaborador();

    }
    private void ApresentarColaborador()
    {
        Console.WriteLine($"Cargo: {_cargo}");
        Console.WriteLine($"salario: {_salario}");
    }
}