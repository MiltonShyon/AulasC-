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
      
    Console.WriteLine(res);
    Console.WriteLine($"No final de 2022, você terá {c} anos");
    }
  }