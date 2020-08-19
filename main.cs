using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Insira o peso: ");
    double p = double.Parse(Console.ReadLine());

    double e = 0;
    double m = 0;

    if (p > 50)
    {
      e = p - 50;
      m = e * 4;

      Console.WriteLine("Peso excedente: " + e + "\n" + "Multa: R$" + m);      
    }

    else
    {
      Console.WriteLine("Peso Ok.");
    }

  }
}