// See https://aka.ms/new-console-template for more information
using FactorySample;

Console.WriteLine("Hello, World!");

FactoryMathOpr Addition = new SubstractOprFactory(5, 7);

IMathOpr Add = Addition.OprExec();

decimal resultado = Add.OprExec(5, 2);

Console.WriteLine($"El resultado de la operacion es {resultado}");

Console.ReadLine();
