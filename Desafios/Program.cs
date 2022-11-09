/*
  A empresa ABC resolveu conceder um aumento de salários a seus funcionários de acordo com a tabela abaixo:
  Leia o salário do funcionário e calcule e mostre o novo salário, bem como o valor de reajuste ganho e o índice reajustado, em percentual.
*/

using System;
using System.Globalization;

class Program
{

  static void Main(string[] args)
  {

    double salario = 0.00;
    double reajuste = 0.00;
    double novoSalario = 0.00;
    double percentual = 0.00;

    salario = Convert.ToDouble(Console.ReadLine());

    if (salario > 400.00 && salario < 800.01)
    {
      percentual = 0.12;

    }
    else if (salario > 800.00 && salario < 1200.01)
    {
      percentual = 0.1;
    }
    else if (salario > 1200 && salario < 2000.01)
    {
      percentual = 0.07;
    }
    else if (salario > 2000.00)
    {
      percentual = 0.04;
    }
    else
    {
      percentual =0.15;
    }

    reajuste = salario * percentual;
    novoSalario = salario*(1+percentual);

    Console.WriteLine("Novo salario: {0:0.00}",novoSalario); 
    Console.WriteLine($"Reajuste ganho: {reajuste.ToString("F2")}");; 
    Console.WriteLine($"Em percentual: {percentual.ToString("P0")}"); 
  }
}