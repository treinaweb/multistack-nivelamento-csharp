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

var atendimento = new Atendimento(cliente, diarista, 6);
Console.WriteLine(atendimento.Cliente.Nome);
Console.WriteLine(atendimento.Diarista.Nome);
Console.WriteLine(atendimento.Horas);

atendimento.Horas = 2;
Console.WriteLine(atendimento.Horas);

// var pessoa = new Pessoa("Nome teste", "telefone teste", "endereco teste");
// Console.WriteLine(pessoa.Nome);

abstract class Pessoa
{
    public string? Nome { get; set; }

    public string? Telefone { get; set; }

    public string? Endereco { get; set; }

    public Pessoa(string? nome, string? telefone, string? endereco)
    {
        Nome = nome;
        Telefone = telefone;
        Endereco = endereco;
    }
}

class Diarista : Pessoa
{
    public string? ChavePix { get; set; }

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
    public decimal Saldo { get; set; }

    public Cliente(string nome, string telefone, string endereco)
        : base(nome, telefone, endereco)
    {
        Saldo = 0;
    }
}

class Atendimento
{

    public Diarista Diarista { get; }

    public Cliente Cliente { get; }

    private int _horas;
    public int Horas
    {
        get
        {
            return _horas;
        }
        set
        {
            _horas = value;
            validarHoras();
        }
    }

    public Atendimento(Cliente cliente, Diarista diarista, int horas)
    {
        Cliente = cliente;
        Diarista = diarista;
        Horas = horas;

        validarHoras();
    }

    private void validarHoras()
    {
        if (Horas < 0 || Horas > 6)
        {
            throw new ArgumentException("A quantidade de horas não pode ser menor que 0 e nem maior do que 6");
        }
    }

}