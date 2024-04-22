using CalculadoraC_;
using System;

Calculadora calculadora = new Calculadora();

while (calculadora.Calcular != 1)
{
    Console.WriteLine("Execultando Calculadora! Digite os números que deseja realizar o calculo.");
    calculadora.executarCalculadora();
}
