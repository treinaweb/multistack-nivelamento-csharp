namespace Aula09.Interfaces;

public interface IConta
{

    void Sacar(decimal valor);
    void Depositar(decimal valor);
    void Transferir(IConta contaDestino, decimal valor);

}