var alunos = new List<string>() { "Cleyson", "Elton", "Ariel", "Ana" };

// for (var index = 0; index < alunos.Count; index++)
// {
//     Console.WriteLine(alunos[index]);
// }

foreach (var aluno in alunos)
{
    Console.WriteLine(aluno);
}

var medias = new Dictionary<string, double>()
{
    { "Elton", 10.0 },
    { "Cleyson", 8.7 },
    { "Ariel", 7.7 },
    { "Ana", 9.1 }
};

foreach (var aluno in medias)
{
    Console.WriteLine($"{aluno.Key} - {aluno.Value}");
}
