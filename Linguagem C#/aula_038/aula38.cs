// Métodos virtuais

using System;

class Base{
  public Base(){
    Console.WriteLine("Construtor da classe Base");
  }
  // Quando sé deseja usar o método como virtual(pode ser subscrito) sé deve usar "virtual" na declaração do método
  virtual public void info(){
    Console.WriteLine("Base");
  }
}

class DerivativeOne:Base{
  public DerivativeOne(){
    Console.WriteLine("Construtor da Classe Derivada1");
  }
  // E importante lembrar de sinalizar o método que será subscrito com "override"
  override public void info(){
    Console.WriteLine("Derivada 1");
  }
}
class DerivativeTwo:DerivativeOne{
  public DerivativeTwo(){
    Console.WriteLine("Construtor da Classe Derivada2");
  }
    public override void info(){
      Console.WriteLine("Derivada 2");
    }
}


class Program{

	static void Main(){
    // Quando usamos "Ref" podemos referenciar valores dentro da classe "Base"
    Base Ref;
    DerivativeOne derivada1=new DerivativeOne();
    DerivativeTwo derivada2=new DerivativeTwo();
  
    // Ref recebe "derivada" assim pode usar o ".info"
    Ref=derivada1;
    Ref.info();
	}
}