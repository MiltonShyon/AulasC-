using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("Digite sua data de nascimento:");
    string[] data = Console.ReadLine().Split("/");
    string r = data[1];
    int res = int.Parse(r);
    
    if (res == 01){
        Console.WriteLine("Janeiro");
        }
      
    if (res == 02){
        Console.WriteLine("fevereiro ");
        }

    if (res == 03){
        Console.WriteLine("março ");
      }
    
    if (res == 04){
        Console.WriteLine("abril ");
      }

    if (res == 05){
        Console.WriteLine("maio ");
      }

    if (res == 06){
        Console.WriteLine("junho ");
      }
      
    if (res == 07){
        Console.WriteLine("julho ");
      }

    if (res == 8){
        Console.WriteLine("agosto ");
      }

    if (res == 9){
        Console.WriteLine("setembro ");
      }

    if (res == 10){
        Console.WriteLine("outubro ");
      }

    if (res == 11){
        Console.WriteLine("novembro ");
      }

    if (res == 12){
        Console.WriteLine("dezembro");
      }
    }
  }
      