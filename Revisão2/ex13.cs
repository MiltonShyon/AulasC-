using System;
public class Program {
  public static void Main(string[] args) {
    string lista = Console.ReadLine();
    
    string[] numero = lista.Split(' ');
    
    Console.WriteLine($"O maior valor é {numero[9]} e o menor é {numero[0]} ");
    
  }
}