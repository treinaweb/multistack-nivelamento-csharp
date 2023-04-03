var contaCorrente = new ContaCorrente("Elton Fonseca");
var contaPoupanca = new ContaPoupanca("Cleyson Lima");
Console.WriteLine($"Títular: {contaCorrente.Titular}, Saldo: {contaCorrente.Saldo}");
Console.WriteLine($"Títular: {contaPoupanca.Titular}, Saldo: {contaPoupanca.Saldo}");

contaCorrente.Depositar(100);
contaPoupanca.Depositar(100);
Console.WriteLine($"Títular: {contaCorrente.Titular}, Saldo: {contaCorrente.Saldo}");
Console.WriteLine($"Títular: {contaPoupanca.Titular}, Saldo: {contaPoupanca.Saldo}");

contaCorrente.Sacar(50);
contaPoupanca.Sacar(50);
Console.WriteLine($"Títular: {contaCorrente.Titular}, Saldo: {contaCorrente.Saldo}");
Console.WriteLine($"Títular: {contaPoupanca.Titular}, Saldo: {contaPoupanca.Saldo}");

contaCorrente.Transferir(contaPoupanca, 10);
Console.WriteLine($"Títular: {contaCorrente.Titular}, Saldo: {contaCorrente.Saldo}");
Console.WriteLine($"Títular: {contaPoupanca.Titular}, Saldo: {contaPoupanca.Saldo}");

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
}

class ContaCorrente : Conta
{

    public ContaCorrente(string titular) : base(titular) {}

    public override void Sacar(decimal valor)
    {
        valor += 10/100M * valor;
        base.Sacar(valor);
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

}