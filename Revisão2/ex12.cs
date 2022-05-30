using System;
public class Program {
  public static void Main(string[] args)
  {
    Console.WriteLine("Digite dois valores inteiros separados por um operador +,-,*,/");
    string lista = Console.ReadLine();
    char[] sinal = {'+','-','*','/'};
    char[] numeros = {'0','1','2','3','4','5','6','7','8','9'};

    string[] numero = lista.Split(sinal);
    string[] operador = lista.Split(numeros);
    
    Console.WriteLine(operador[0]);
    Console.WriteLine(numero[1]);
  }
}
