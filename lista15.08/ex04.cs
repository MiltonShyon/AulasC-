using System; 

public class Program {

  public static void Main(string[] args) {
    
    Console.WriteLine("Digite sua data de nascimento:");
    string[] data = Console.ReadLine().Split("/");
    string r = data[2];
    int res = int.Parse(r);
    int c = 0;
    while (res < 2022){
      c+=1;
      res+=1;
    }
    
    if (c > 0 && c < 19){
      Console.WriteLine("Você está na faixa etária: Jovem");
    }
    
    if (c > 20 && c < 59){
      Console.WriteLine("Você está na faixa etária: Adulto");
    }

    if (c > 60){
      Console.WriteLine("Você está na faixa etária: Idoso");
    }
    }
  }
    