namespace Aula09.Classes;

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