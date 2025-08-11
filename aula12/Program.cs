// CRiando objetos
Pessoa obj1 = new();
obj1.Nome = "Miguel";
obj1.Idade = 19;

obj1.Apresentação();

string retorno = obj1.VerificarIdade();
Console.WriteLine(retorno);
