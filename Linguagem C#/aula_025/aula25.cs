// Passagem por valor e por referência 
using System;

class Program{

	static void Main(){
		int num=10;
    dobrar(num);
    Console.WriteLine(num);
	}

  static void dobrar(int valor){
    valor*=2;
  }
}
