using DollarsToCents;

Console.WriteLine("Conversor");
Console.WriteLine();
Console.WriteLine("'1' Dollars para Cents");
Console.WriteLine("'2' Cents para Dollars");

string escolha = Console.ReadLine();
Console.Clear();

if (escolha == "1")
{
    Console.WriteLine("Dollars para Cents");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Tipo de formatação: $123.45");
    Console.ResetColor();
    Console.WriteLine();
    Console.Write("Insira a quantidade em Dollars: ");
    string dollars = Console.ReadLine();
    Console.WriteLine("Cents: " + Conversor.ToCents(dollars));
}
else if(escolha == "2")
{
    Console.WriteLine("Cents para Dollars");
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Tipo de formatação: 12345");
    Console.ResetColor();
    Console.WriteLine();
    Console.Write("Insira a quantidade em Cents: ");
    string cents = Console.ReadLine();
    Console.WriteLine("Cents: " + Conversor.ToDollar(cents));
}
else
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Essa escolha não existe.");
}