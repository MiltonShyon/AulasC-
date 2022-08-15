using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("Digite sua data de nascimento:");
    string[] data = Console.ReadLine().Split("/");
    string r = data[1];
    int res = int.Parse(r);
    int c = 0;
    while (res < 2022){
      c+=1;
      res+=1;
    }  
    
    if (c == 1){
        Console.WriteLine("Janeiro");
        }
      
    if (c == 2){
        Console.WriteLine("fevereiro ");
        }

    if (c == 3){
        Console.WriteLine("março ");
      }
    
    if (c == 4){
        Console.WriteLine("abril ");
      }

    if (c == 5){
        Console.WriteLine("maio ");
      }

    if (c == 6){
        Console.WriteLine("junho ");
      }
      
    if (c == 7){
        Console.WriteLine("julho ");
      }

    if (c == 8){
        Console.WriteLine("agosto ");
      }

    if (c == 9){
        Console.WriteLine("setembro ");
      }

    if (c == 10){
        Console.WriteLine("outubro ");
      }

    if (c == 11){
        Console.WriteLine("novembro ");
      }

    if (c == 12){
        Console.WriteLine("dezembro");
      }

      
      
      
    }
  }
      