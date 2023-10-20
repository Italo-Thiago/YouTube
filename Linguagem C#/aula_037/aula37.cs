// Herança/Ordem de execução dos construtores.

using System;

class Base{
  public Base(){
    Console.WriteLine("Construtor da classe Base");
  }
}

class DerivativeOne:Base{
  public DerivativeOne(){
    Console.WriteLine("Construtor da Classe Derivada1");
  }
}
class DerivativeTwo:DerivativeOne{
  public DerivativeTwo(){
    Console.WriteLine("Construtor da Classe Derivada2");
  }
}


class Program{

	static void Main(){
	
    DerivativeTwo derivada2=new DerivativeTwo();
	
	}
}