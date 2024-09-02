using System;
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
