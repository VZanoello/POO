// See https://aka.ms/new-console-template for more information
using Heranca;
using Heranca.Interface;

Console.WriteLine("Hello, World!");

IFiguraGeometrica figuraGeometrica;
try
{
    var retangulo = new Retangulo();
    Console.WriteLine("*Calcular area do retangulo*");

    Console.WriteLine("Informe o altura: ");
    retangulo.Altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe a largura : ");
    retangulo.Largura = Convert.ToDouble(Console.ReadLine());
    figuraGeometrica = retangulo;
    Console.WriteLine($"Area do Retangulo: {figuraGeometrica.GetArea()}");
    Console.ReadLine();

    var triangulo = new Triangulo();

    Console.WriteLine("*Calcular area do trinagulo*");

    Console.WriteLine("Informe o altura: ");
    triangulo.Altura = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Informe a base: ");
    triangulo.Base = Convert.ToDouble(Console.ReadLine());
    figuraGeometrica = triangulo;
    Console.WriteLine($"Area do trinagulo: {figuraGeometrica.GetArea()}");
}
catch (ArgumentException argEx)
{
    Console.WriteLine($"Erro : {argEx} ");
}
Console.ReadLine();