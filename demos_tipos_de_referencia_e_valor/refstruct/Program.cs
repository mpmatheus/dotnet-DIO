using static System.Console;

Pessoa p1 = new Pessoa();

p1.Nome = "Matheus";
p1.Idade = 26;

p1.EnderecoPessoa = new Endereco()
{
    Logradouro = "rua teste",
    Numero = 300,
    CEP = "000000",
    Cidade = "São Paulo",
};

WriteLine ("FIM");