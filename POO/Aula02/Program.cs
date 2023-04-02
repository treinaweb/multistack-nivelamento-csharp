var joao = new Diarista("João da Silva", "(11) 99877-7777", "Av Paulista, 1220");

Console.WriteLine($"Nome: {joao.Nome}");
Console.WriteLine($"Telefone: {joao.Telefone}");
Console.WriteLine($"Endereço: {joao.Endereco}");
joao.Atender("Cleyson Lima");

var maria = new Diarista("Maria da Silva", "(11) 99877-7771", "Av Paulista, 1221");

Console.WriteLine($"Nome: {maria.Nome}");
Console.WriteLine($"Telefone: {maria.Telefone}");
Console.WriteLine($"Endereço: {maria.Endereco}");
maria.Atender("Elton Fonseca");

var luis = new Diarista("Luis da Silva");

Console.WriteLine($"Nome: {luis.Nome}");
Console.WriteLine($"Telefone: {luis.Telefone}");
Console.WriteLine($"Endereço: {luis.Endereco}");
luis.Atender("Elton Fonseca");

var lucas = new Diarista
{
    Nome = "Lucas da Silva",
    Telefone = "(11) 99877-7772",
    Endereco = "Av. Paulista, 1222"
};

Console.WriteLine($"Nome: {lucas.Nome}");
Console.WriteLine($"Telefone: {lucas.Telefone}");
Console.WriteLine($"Endereço: {lucas.Endereco}");
lucas.Atender("Elton Fonseca");

class Diarista
{
    public string? Nome;

    public string? Telefone;

    public string? Endereco;

    public Diarista() {}

    public Diarista(string nome)
    {
        Nome = nome;
    }

    public Diarista(string nome, string telefone, string endereco)
    {
        Nome = nome;
        Telefone = telefone;
        Endereco = endereco;
    }

    public void Atender(string nomeCliente)
    {
        Console.WriteLine($"{Nome} atendeu {nomeCliente}");
    }
}