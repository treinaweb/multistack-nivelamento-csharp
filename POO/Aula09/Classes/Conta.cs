namespace Aula09.Classes;

using Aula09.Interfaces;

public abstract class Conta : IConta
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