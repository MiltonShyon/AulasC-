using System; 

class URI {

    static void Main(string[] args) { 

      string nome = Console.ReadLine();
      double sf = double.Parse(Console.ReadLine());
      double tv = double.Parse(Console.ReadLine());
      double sfi = ((tv /100)*15) + sf;
      Console.WriteLine($"TOTAL = R$ {sfi:0.00}");

    }

}