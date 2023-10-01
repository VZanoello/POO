// See https://aka.ms/new-console-template for more information
using Encapsulamento;

var r = new Retangulo();
try
{
    Console.WriteLine("Informe o altura: ");
    r.Altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe a largura : ");
    r.Largura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine($"Area do Retangulo: {r.GetArea()}");
}
catch (ArgumentException argEx)
{
    Console.WriteLine($"Erro : {argEx} ");
}
Console.ReadLine();
