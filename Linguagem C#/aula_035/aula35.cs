// Cadeia de herança e Construtor da classe base

using System;

class Veiculo
  { //Classe Base
  private int wheels;
  public int velMax;
  private bool active;
  public Veiculo(int wheels){
    this.wheels=wheels;
  }
  public void ligar(){
    active=true;
  }
  public void desligar(){
    active=false;
  }
  public string getLigado(){
    // Uso de operador ternário
    return (active?"sim":"não");
  }
  public int getWheels(){
    return wheels;
  }
}

class Carro:Veiculo
{ //Classe Derivada
  public string name;
  public string color;
  // No caso abaixo existe uma variável que está no objeto base, quando isso acontece podemos usar a herança para pegar o valor do objeto base e repassar para o objeto derivado.
  public Carro(string name,string color):base(4){
    desligar();
    velMax=120;
    this.name=name;
    this.color=color;
  }
}

class Program{

	static void Main(){
    Carro c1=new Carro("Fast","red");

    c1.ligar();

    Console.WriteLine("Cor........:{0}",c1.color);
    Console.WriteLine("Nome.......:{0}",c1.name);
    Console.WriteLine("Rodas......:{0}",c1.getWheels());
    Console.WriteLine("Vel.Máxima.:{0}",c1.velMax);
    Console.WriteLine("Ligado.....:{0}",c1.getLigado());
	}
}