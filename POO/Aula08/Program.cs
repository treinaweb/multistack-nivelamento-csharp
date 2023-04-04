// var conta1 = new ContaCorrente("Elton Fonseca");
// var conta2 = new ContaCorrente("Cleyson Lima");
// var conta3 = new ContaPoupanca("Amauri");
// Console.WriteLine(conta1);
// Console.WriteLine(conta2);
// Console.WriteLine(conta3);

var conta1 = new ContaCorrente("Elton");
var conta2 = new ContaCorrente("Elton");
conta1.Depositar(100);
Console.WriteLine(conta1.Equals(conta2));
Console.WriteLine(conta1.GetHashCode());
Console.WriteLine(conta2.GetHashCode());

interface IConta
{

    void Sacar(decimal valor);
    void Depositar(decimal valor);
    void Transferir(IConta contaDestino, decimal valor);

}

abstract class Conta : IConta
{
    public string Titular { get; }
    public decimal Saldo { get; protected set; }

    public Conta(string titular)
    {
        Titular = titular;
        Saldo = 0;
    }

    public virtual void Depositar(decimal valor)
    {
        if (valor > 0)
        {
            Saldo += valor;
        }
    }

    public virtual void Sacar(decimal valor)
    {
        if (valor > 0 && valor <= Saldo)
        {
            Saldo -= valor;
        }
    }

    public void Transferir(IConta contaDestino, decimal valor)
    {
        Sacar(valor);
        contaDestino.Depositar(valor);
    }

    public override string ToString()
    {
        return $"Conta = Títular: {Titular}, Saldo: {Saldo}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Conta conta &&
               Titular == conta.Titular &&
               Saldo == conta.Saldo;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(Titular, Saldo);
    }
}

class ContaCorrente : Conta
{

    public ContaCorrente(string titular) : base(titular) {}

    public override void Sacar(decimal valor)
    {
        valor += 10/100M * valor;
        base.Sacar(valor);
    }

    public override string ToString()
    {
        return $"ContaCorrente = Títular: {Titular}, Saldo: {Saldo}";
    }

}

class ContaPoupanca : Conta
{

    public ContaPoupanca(string titular) : base(titular) {}

    public override void Depositar(decimal valor)
    {
        valor += 10/100M * valor;
        base.Depositar(valor);
    }

    public override string ToString()
    {
        return $"ContaPoupanca = Títular: {Titular}, Saldo: {Saldo}";
    }

}