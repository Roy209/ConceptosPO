// See https://aka.ms/new-console-template for more information
using ConceptosPO;

Console.WriteLine("POO concepts");
Console.WriteLine("============");

//crtl + k + s
try
{
    Console.WriteLine(new Date(2022, 9, 12));
    Console.WriteLine(new Date(1982, 2, 12));
    Console.WriteLine(new Date(2024, 02, 29));
}catch (Exception error)
{
    Console.WriteLine(error.Message);
}

