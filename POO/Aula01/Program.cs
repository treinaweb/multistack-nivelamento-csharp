var joao = new Diarista();
joao.Nome = "João da Silva";
joao.Telefone = "(11) 99877-7777";
joao.Endereco = "Av Paulista, 1220";

Console.WriteLine($"Nome: {joao.Nome}");
Console.WriteLine($"Telefone: {joao.Telefone}");
Console.WriteLine($"Endereço: {joao.Endereco}");
joao.Atender("Cleyson Lima");

var maria = new Diarista();
maria.Nome = "Maria da Silva";
maria.Telefone = "(11) 99877-7771";
maria.Endereco = "Av Paulista, 1221";

Console.WriteLine($"Nome: {maria.Nome}");
Console.WriteLine($"Telefone: {maria.Telefone}");
Console.WriteLine($"Endereço: {maria.Endereco}");
maria.Atender("Elton Fonseca");

class Diarista
{
    public string? Nome;

    public string? Telefone;

    public string? Endereco;

    public void Atender(string nomeCliente)
    {
        Console.WriteLine($"{Nome} atendeu {nomeCliente}");
    }
}