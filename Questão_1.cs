using System;
/*
1. Faça um programa que receba duas notas, calcule e mostre a média ponderada dessas notas,
considerando peso 2 para a primeira nota e peso 3 para a segunda nota
2. Faça um programa que receba o preço de um produto, calcule e mostre o novo preço, sabendo-
se que este sofreu um desconto de 10%.
*/
class Program {
  public static void Main (string[] args) {
  int a , b;
  Console.WriteLine("Digite um número");
    a = int.Parse(Console.ReadLine());
    Console.Write("Digite outro número:\n");
    b = int.Parse(Console.ReadLine());
    Console.WriteLine($"a soma de {a} + {b} = {a+b}");

 
  }
}
