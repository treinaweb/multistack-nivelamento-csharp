namespace Aula09.Classes;

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