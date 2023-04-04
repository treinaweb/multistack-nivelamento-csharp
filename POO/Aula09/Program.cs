using Aula09.Classes;

var conta1 = new ContaCorrente("Elton");
var conta2 = new ContaCorrente("Elton");
conta1.Depositar(100);
Console.WriteLine(conta1.Equals(conta2));
Console.WriteLine(conta1.GetHashCode());
Console.WriteLine(conta2.GetHashCode());
