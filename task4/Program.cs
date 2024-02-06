using System;
namespace Serg40in {
  class Program {
    static void Main(string[] args) {
	Console.WriteLine("Введите число");
	int x = Convert.ToInt32(Console.ReadLine());
	x = x * x;
	x = x * x * x;
	Console.Write(x + " в шестой степени = " + x);
	Console.ReadKey();
    }
  }
}



