var diarista = new Diarista("João da Silva", "(11) 99877-7777", "Av Paulista, 1220", "123");
Console.WriteLine($"Nome: {diarista.Nome}");
Console.WriteLine($"Telefone: {diarista.Telefone}");
Console.WriteLine($"Endereço: {diarista.Endereco}");
Console.WriteLine($"Chave Pix: {diarista.ChavePix}");
diarista.Atender("Cleyson Lima");

var cliente = new Cliente("Maria da Silva", "(11) 99877-7771", "Av. Paulista, 1221");
Console.WriteLine($"Nome: {cliente.Nome}");
Console.WriteLine($"Telefone: {cliente.Telefone}");
Console.WriteLine($"Endereço: {cliente.Endereco}");
Console.WriteLine($"Saldo: {cliente.Saldo}");

class Pessoa
{
    public string? Nome;

    public string? Telefone;

    public string? Endereco;

    public Pessoa(string? nome, string? telefone, string? endereco)
    {
        Nome = nome;
        Telefone = telefone;
        Endereco = endereco;
    }
}

class Diarista : Pessoa
{
    public string? ChavePix;

    public Diarista() : base(null, null, null)
    {}

    public Diarista(string nome) : base(nome, null, null)
    {}

    public Diarista(string nome, string telefone, string endereco, string chavePix)
        : base(nome, telefone, endereco)
    {
        ChavePix = chavePix;
    }

    public void Atender(string nomeCliente)
    {
        Console.WriteLine($"{Nome} atendeu {nomeCliente}");
    }
}

class Cliente : Pessoa
{
    public decimal Saldo;

    public Cliente(string nome, string telefone, string endereco)
        : base(nome, telefone, endereco)
    {
        Saldo = 0;
    }
}