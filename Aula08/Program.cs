var contadora = 101;
while (contadora <= 100)
{
    Console.WriteLine("A váriavel contadora vale: " + contadora);
    contadora++;
}
Console.WriteLine("Terminou o while");

do
{
    Console.WriteLine("A váriavel contadora vale: " + contadora);
    contadora++;
} while (contadora <= 100);
Console.WriteLine("Terminou o do while");